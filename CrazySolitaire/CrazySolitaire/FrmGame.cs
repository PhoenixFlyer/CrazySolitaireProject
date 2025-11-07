using Accessibility;
using CrazySolitaire.Properties;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Timer = System.Windows.Forms.Timer;

namespace CrazySolitaire {
    public partial class FrmGame : Form
    {
        public static Card CurDragCard { get; private set; }
        public static IDragFrom CardDraggedFrom { get; private set; }
        public static FrmGame Instance { get; private set; }
        public static Stopwatch stopwatch = new();
        public static System.Windows.Forms.Timer stopwatchTimer = new();
        public TimeSpan elapsed;
        public int NumOfMoves = 0;
        public int PowerupUses = 0;
        public int UsedPowerups = 0;
        public int ExtraPowerups = 0;
        public static bool autoplay = false;
        public static int hints = 5;
        public static FrmSettings frmSettings = new();
        public static FrmWin frmWin = new();
        public static FrmQTE frmqte = new();
        public static Timer DeathTimer = new();

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;    // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public FrmGame()
        {
            InitializeComponent();
            DeathTimer.Tick += new EventHandler(DeathTimer_Tick);
            DeathTimer.Interval = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game.GameForm = this;
            Instance = this;
            Panel[] panTableauStacks = new Panel[7];
            for (int i = 0; i < 7; i++)
            {
                panTableauStacks[i] = (Panel)Controls.Find($"panTableauStack_{i}", false)[0];
            }
            Dictionary<Suit, Panel> panFoundationStacks = new()
            {
                [Suit.DIAMONDS] = panFoundationStack_Diamonds,
                [Suit.SPADES] = panFoundationStack_Spades,
                [Suit.HEARTS] = panFoundationStack_Hearts,
                [Suit.CLUBS] = panFoundationStack_Clubs,
            };
            Game.Init(panTalon, panTableauStacks, panFoundationStacks);

            // start time
            stopwatchTimer.Tick += new EventHandler(UpdateTime);
            stopwatchTimer.Interval = 1000;
            stopwatchTimer.Start();
            stopwatch.Start();
            // initialize num of hints
            lblNumOfHints.Text = hints.ToString();
        }

        private void pbStock_Click(object sender, EventArgs e)
        {
            if (pbStock.BackgroundImage is null)
            {
                Game.StockReloadCount++;
                if (Game.StockReloadCount > 3)
                {
                    Random rng = new Random();
                    frmqte.Location = new Point(rng.Next(0, this.Width), rng.Next(0, this.Height));
                    frmqte.Show();
                    DeathTimer.Start();
                }
                else
                {
                    Game.Talon.ReleaseIntoDeck(Game.Deck);
                    pbStock.BackgroundImage = Game.StockReloadCount switch
                    {
                        1 => Resources.back_green,
                        2 => Resources.back_orange,
                        3 => Resources.back_red,
                    };
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Card c = Game.Deck.Acquire();
                    if (c != null)
                    {
                        Game.Talon.AddCard(c);
                        c.AdjustLocation(i * 20, 0);
                        c.PicBox.BringToFront();
                    }
                }
                if (Game.Deck.IsEmpty())
                {
                    pbStock.BackgroundImage = null;
                }
            }
            UpdateMoves();
        }

        public static void StopDeath()
        {
            DeathTimer.Stop();
            ResetStock();
        }

        public void DeathTimer_Tick(object sender, EventArgs e)
        {
            Game.Explode();
            MessageBox.Show("Your computer has been infected with ransomware", "You have been infected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            FrmYouLose frmYouLose = new();
            frmYouLose.Show();
            Hide();
            DeathTimer.Stop();
        }

        public static void ResetStock()
        {
            Game.StockReloadCount = 0;
        }

        public static void DragCard(Card c)
        {
            CurDragCard = c;
            CardDraggedFrom = Game.FindDragFrom(c);
        }
        public static void StopDragCard(Card c)
        {
            if (CurDragCard == c)
                CurDragCard = null;
        }
        public static bool IsDraggingCard(Card c) => CurDragCard == c;

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Game.TitleForm.Close();
        }

        private void UpdateTime(object sender, EventArgs e)
        {
            // gets the current time
            elapsed = stopwatch.Elapsed;

            // updates the time label
            if ((int)elapsed.Seconds < 10)
                lblTime.Text = string.Format("{0}:0{1}", (int)elapsed.Minutes, (int)elapsed.Seconds);
            else
                lblTime.Text = string.Format("{0}:{1}", (int)elapsed.Minutes, (int)elapsed.Seconds);
        }

        public void UpdateMoves()
        {
            NumOfMoves++;
            lblNumMoves.Text = NumOfMoves.ToString();
            Game.CheckWin();

            if (NumOfMoves % 5 == 0 && (UsedPowerups + PowerupUses) < 3)
            {
                PowerupUses++;
                lblPowerups.Text = $"Powerups Available: {PowerupUses + ExtraPowerups}";
            }
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings.Show();
        }

        //public void CheckWin()
        //{
        //    // if the stock is empty, if the talon is empty, if the tableau stacks are all empty, then show the win screen

        //    frmWin.Show();
        //}

        public void btnNewGame_Click(object sender, EventArgs e)
        {
            // destroys all the picboxes of cards
            Game.RemoveAllCards();

            Game.RemoveHighlights();

            // resets variables
            Game.StockReloadCount = 0;
            NumOfMoves = 0;
            PowerupUses = 0;
            UsedPowerups = 0;
            ExtraPowerups = 0;
            hints = 5;
            lblNumMoves.Text = "0";
            lblPowerups.Text = "";
            stopwatch.Restart();

            // new board
            Form1_Load(sender, e);

            // resetting talon
            Game.Talon.ReleaseIntoDeck(Game.Deck);
            pbStock.BackgroundImage = Resources.back_green;

            Instance.Enabled = true;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (hints > 0)
            {
                hints -= 1;
                lblNumOfHints.Text = hints.ToString();
                Game.GiveHint();
            }
            else
            {
                MessageBox.Show("No more hints");
            }
        }

        private void btnGamble_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gamble Button has been clicked!");
            Random random = new();
            int gambledNumber = random.Next(1, 5);
            switch (gambledNumber) {
                case 1:
                    MessageBox.Show("Sorry, gambling is risky! You immediatly lost the game!");
                    Game.Explode();
                    FrmYouLose frmYouLose = new();
                    frmYouLose.Show();
                    Hide();
                    break;
                case 2:
                    MessageBox.Show("Congratulations! You immediatly won the game!");
                    frmWin.Show();
                    Instance.Enabled = false;
                    break;
                case 3:
                    MessageBox.Show("Gambling is fun and can sometimes give hints!");
                    Game.GiveHint();
                    break;
                case 4:
                    MessageBox.Show("Here's an extra powerup!");
                    ExtraPowerups++;
                    lblPowerups.Text = $"Powerups Available: {PowerupUses + ExtraPowerups}";
                    break;
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undo button clicked! This is very hard to do so it didn't get finished.");
        }
    }
}

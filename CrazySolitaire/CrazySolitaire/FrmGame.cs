using Accessibility;
using CrazySolitaire.Properties;
using System.Diagnostics;
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
        public bool autoplay = false;

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
        }

        private void pbStock_Click(object sender, EventArgs e)
        {
            if (pbStock.BackgroundImage is null)
            {
                Game.StockReloadCount++;
                if (Game.StockReloadCount > 3)
                {
                    Game.Explode();
                    MessageBox.Show("You computer has been infected with ransomware", "You have been infected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    FrmYouLose frmYouLose = new();
                    frmYouLose.Show();
                    Hide();
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
            elapsed = stopwatch.Elapsed;

            if ((int)elapsed.Seconds < 10)
                lblTime.Text = string.Format("{0}:0{1}", (int)elapsed.Minutes, (int)elapsed.Seconds);
            else
                lblTime.Text = string.Format("{0}:{1}", (int)elapsed.Minutes, (int)elapsed.Seconds);
        }

        public void UpdateMoves()
        {
            NumOfMoves++;
            lblNumMoves.Text = NumOfMoves.ToString();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new();
            frmSettings.Show();
        }
    }
}

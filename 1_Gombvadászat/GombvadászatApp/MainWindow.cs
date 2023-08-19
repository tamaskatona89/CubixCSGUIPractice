namespace GombvadászatApp
{
    public partial class MainWindow : Form
    {
        readonly Random rnd = new();
        public int HitCounter { get; set; } = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CrazyButton_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;

            HitCounter++;

            if (timer1.Interval >= 1000)
                timer1.Interval -= 500;

            crazyButton.Text = HitCounter.ToString();
            SetNewRandomPosition();
            matchCounterLabel.Text = $"Találatok: {HitCounter}/20";
            CheckExit();

        }

        private void CheckExit()
        {
            if (HitCounter == 20)
            {
                timer1.Enabled = false;
                MessageBox.Show("Nyertél!\nSikeresen elérted a 20 találatot!", "Nyertél!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
        }

        private void SetNewRandomPosition()
        {
            crazyButton.Top = rnd.Next(0, 550 - 25);
            crazyButton.Left = rnd.Next(0, 900 - 100);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            SetNewRandomPosition();
        }

        
    }
}
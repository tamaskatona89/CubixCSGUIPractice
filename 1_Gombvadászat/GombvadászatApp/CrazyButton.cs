using System.Windows.Forms;
namespace GombvadászatApp
{
    public class CrazyButton : Button
    {
        public int HitCounter { get; set; } = 0;

        public System.Windows.Forms.Timer CrazyButtonTimer { get; set; }
        readonly Random rnd = new();

        public CrazyButton() : base()
        {
            this.Text = "Kezdjük!";
            CrazyButtonTimer!.Enabled = false;
            CrazyButtonTimer!.Interval = 5000;
        }

        public void SetNewPlacement() 
        {
            this.Top = rnd.Next(0, 550 - 25);
            this.Left = rnd.Next(0, 900 - 100);

        }
    }
}

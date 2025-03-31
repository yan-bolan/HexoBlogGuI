using System.Windows.Forms;

using Sunny.UI; namespace ChiSaTo
{
    public partial class FMeter : UIPage
    {
        public FMeter()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            value++;
            uiRoundMeter1.Angle = value * 10;
            uiRoundMeter2.Angle = value * 10;
            uiAnalogMeter1.Value = value;
        }

        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int value;

        public override void Init()
        {
            value = 0;
            timer.ReStart();
        }
    }
}

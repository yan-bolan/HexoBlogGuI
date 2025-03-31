using Sunny.UI; namespace ChiSaTo
{
    public partial class FCommon : UIPage
    {
        public FCommon()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, System.EventArgs e)
        {
            MapperDemo.Demo();
        }
    }
}

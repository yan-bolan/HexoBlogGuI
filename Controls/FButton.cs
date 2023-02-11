using System;
using System.Diagnostics;
using System.Windows.Forms;
using Sunny.UI; namespace ChiSaTo
{
    public partial class FButton : UIPage
    {
        public FButton()
        {
            InitializeComponent();
            uiToolTip1.SetToolTip(uiButton1, uiButton1.Text);
            //uiToolTip1.SetToolTip(uiSymbolButton1, uiSymbolButton1.Text, "SunnyUI");
            //uiToolTip1.SetToolTip(uiSymbolButton2, uiSymbolButton2.Text, "SunnyUI",
            //    uiSymbolButton2.Symbol, 32, UIColor.Red);
        }

        /// <summary>
        /// 放在 [窗体Load (NeedReload = true)] 的内容每次页面切换，进入页面都会执行。
        /// 这三个选一个用就行了。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FButton_Load(object sender, EventArgs e)
        {
            Console.WriteLine("1. FButton_Load");

        }

        //放在 [窗体Load (NeedReload = true)] 的内容每次页面切换，进入页面都会执行。
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Console.WriteLine("3. FButton_OnLoad");
        }

        //放在 [重载Init] 的内容每次页面切换，进入页面都会执行。
        public override void Init()
        {
            base.Init();
            //uiSwitch1.Active = uiSwitch4.Active = true;
            //uiSwitch2.Active = uiSwitch3.Active = false;

            LinkLabel_BLOG_PATH.Text = Settings1.Default.BlogCateLog;
            FlowLayoutPanel_Recent.Clear();
            var bm = new Blog_Main();
            var md_file_latest = bm.GetLatestFiles(bm.Base_post_addr, 20).Select(x => Path.GetFileName(x)).ToList();
            foreach (var item in md_file_latest)
            {
                var link = new UILinkLabel();
                link.SetDPIScale();
                link.Text = item;
                link.Name = link.Text;
                link.Click += (object sender, System.EventArgs e) => {
                    var file_name = (UILinkLabel)sender;
                    Process.Start("explorer.exe", Path.Combine(bm.Base_post_addr, file_name.Text));
                };

                //建议用封装的方法Add
                FlowLayoutPanel_Recent.Add(link);
            }

            Console.WriteLine("2. FButton_Init");
        }

        //放在 [Final] 的内容每次页面切换，退出页面都会执行
        public override void Final()
        {
            base.Final();
            Console.WriteLine("4. FButton_Final");
        }

        private void uiSwitch1_ValueChanged(object sender, bool value)
        {
            //Console.WriteLine(uiSwitch1.Active);
        }

        private void uiSymbolButton25_Click(object sender, EventArgs e)
        {
            Frame.SelectPage(5000);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //传值给页面1001
            //设置FAvatar的Label文字
            SendParamToPage(1001, "你好");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            //传值给框架
            SendParamToFrame("传值给框架");
        }



        private void open_dir_buttion_Click(object sender, EventArgs e)
        {
            var bm = new Blog_Main();

            bm.main(Enum_Blog.open_dir, "");
        }

        private void Button_new_post_Click(object sender, EventArgs e)
        {
            var bm = new Blog_Main();

            bm.main(Enum_Blog.New_Post, post_title_input_box.Text.Trim());
        }

        private void uiButton_Commit_Click(object sender, EventArgs e)
        {

            var bm = new Blog_Main();
            var message = uiTextBox_commit_msg.Text.Trim();
            if (!string.IsNullOrWhiteSpace(message))
            {
                string command = $"hexo g & git add . & git commit -a -m \"{message}\"  & exit";
                Process process = new Process();
                process.StartInfo.WorkingDirectory = bm.Base_addr;
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = " /k " + command;
                process.Start();
                process.WaitForExit();

            }
            else
            {
                ShowErrorTip("请输入提交信息！");
            }

            Console.WriteLine("Good Bye !");

        }

        private void uiButton_Push_Click(object sender, EventArgs e)
        {
            var bm = new Blog_Main();
            var message = uiTextBox_commit_msg.Text.Trim();
            if (!string.IsNullOrWhiteSpace(message))
            {
                string command = $"hexo g & git add . & git commit -a -m \"{message}\" & git push & exit";
                Process process = new Process();
                process.StartInfo.WorkingDirectory = bm.Base_addr;
                process.StartInfo.FileName = "CMD.exe";
                process.StartInfo.Arguments = " /k " + command;
                process.Start();
                process.WaitForExit();

            }
            else
            {
                ShowErrorTip("请输入提交信息！");
            }

            Console.WriteLine("Good Bye !");
        }


        private void Button_open_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Settings1.Default.BlogCateLog = dialog.SelectedPath;
                Settings1.Default.Save();
                LinkLabel_BLOG_PATH.Text = Settings1.Default.BlogCateLog;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HeaderEdit frm = new HeaderEdit();
            frm.Render();
            frm.ShowDialog();
            if (frm.IsOK)
            {
                ShowSuccessDialog(frm.Person.ToString());
            }
            frm.Dispose();
        }
        
        
    }
}

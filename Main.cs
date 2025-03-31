using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiSaTo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //获取可执行目录地址
            string exePath = Application.StartupPath;

            //拼接计算html页面路径
            string relativePath = "./wwwroot/index.html";
            string path = Path.GetFullPath(Path.Combine(exePath, relativePath));

            this.webView21.Source = new Uri(@"file:///" + path);

                        
        }
    }
}

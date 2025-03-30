using ChiSaTo.Model;
using Sunny.UI;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.Globalization;
using YamlDotNet.Serialization.Converters;
using System.Diagnostics;
using System.ComponentModel;
using System.Text;

namespace ChiSaTo
{
    public partial class HeaderEdit : UIEditForm
    {
        public HeaderEdit()
        {
            InitializeComponent();
        }

        protected override bool CheckData()
        {
            return CheckEmpty(edttitle, "请输入标题");
            //&& CheckEmpty(edtAge, "请输入年龄")
            //&& CheckRange(edtAge, 18, 60, "输入年龄范围18~60")
            //&& CheckEmpty(cbDepartment, "请选择部门")
            //&& CheckEmpty(edtDate, "请选择生日");
        }

        private Post post;

        /// <summary>
        /// 可用 getter setter 实现双向绑定数据这样一个功能 相当于ui model
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        /// <summary>
        /// 可用 getter setter 实现双向绑定数据这样一个功能 相当于ui model
        /// </summary>
        public Post Person
        {
            get
            {
                if (post == null)
                {
                    post = new Post();
                }

                post.Title = edttitle.Text;
                post.date = DateTime.Now;
                //person.Age = edtAge.IntValue;
                //person.Birthday = edtDate.Value;
                //person.Address = edtAddress.Text;
                //if (rbMale.Checked)
                //    person.Sex = Sex.Male;
                //if (rbFemale.Checked)
                //    person.Sex = Sex.Female;
                //person.Department = cbDepartment.Text;
                return post;
            }

            set
            {
                post = value;
                title.Text = value.Title;


                //edtAge.IntValue = value.Age;
                //cbDepartment.SelectedIndex = cbDepartment.Items.IndexOf(value.Department);
                //rbMale.Checked = value.Sex == Sex.Male;
                //rbFemale.Checked = value.Sex == Sex.Female;
            }
        }

        private void add_tags_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(edttags.Text))
            {
                ShowErrorDialog("请输入tag内容！");
                return;
            }

            if (post == null)
            {
                post = new Post();
            }
            if (post.Tags == null)
            {
                post.Tags = new List<string>();

            }
            post.Tags.Add(edttags.Text);
            var link = new UIButton();
            link.Radius = 18;
            link.UseDoubleClick = true;
            link.AutoSize = true;
            link.SetDPIScale();
            link.Text = edttags.Text;
            link.Name = link.Text;
            link.DoubleClick += (object sender, EventArgs e) =>
            {
                uiFlowLayoutPanelTags.Remove(link);
            };
            uiFlowLayoutPanelTags.Add(link);
            edttags.Text = "";//clear
        }

        private void btnOK_Click2(object sender, EventArgs e)
        {
            if (post == null)
            {
                post = new Post();
            }
            if (string.IsNullOrWhiteSpace(edttitle.Text))
            {
                ShowErrorDialog("请输入文件名！");
                return;
            }

            post.Title = edttitle.Text;
            post.date = DateTime.Now;

            var bm = new Blog_Main();
            var tagtext = post.Tags == null ? "" : string.Join(",", post.Tags);
            string command = $" node  .\\create_post.js \"{post.Title}\" \"{tagtext}\"  &exit";
            Process process = new();
            process.StartInfo.WorkingDirectory = bm.Base_addr;
            process.StartInfo.FileName = "CMD.exe";
            process.StartInfo.Arguments = " /k " + command;
            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                Console.WriteLine($"Node.js脚本执行失败，退出代码: {process.ExitCode}");
                ShowErrorDialog("执行失败");
                return;
            }
            Console.WriteLine("当前工作目录: " + bm.Base_addr);
            // 检查目录是否存在
            if (!Directory.Exists(bm.Base_addr))
            {
                Console.WriteLine("错误：工作目录不存在！");
                ShowErrorDialog("错误：工作目录不");
                return;
            }
            //#region covert to Front Matter YAML


            //var serializer = new SerializerBuilder()
            //.WithNamingConvention(CamelCaseNamingConvention.Instance)
            //.WithTypeConverter(new DateTimeConverter(
            //       //provider: CultureInfo.CurrentCulture,
            //       formats: new[] {  "yyyy-MM-dd hh:mm:ss" , "yyyy-MM-dd"})
            //   )
            //.Build();
            //var yaml = serializer.Serialize(post);
            //#endregion//https://github.com/aaubry/YamlDotNet

            //bm.Post_Content = $"---\n{yaml.Trim()}\n---\n";
            //bm.main(Enum_Blog.New_Post_by_file, post.Title.Trim());
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // 初始化或验证Post对象
                post ??= new Post();

                // 验证必要输入
                if (string.IsNullOrWhiteSpace(edttitle.Text))
                {
                    ShowErrorDialog("请输入文件名！");
                    return;
                }

                // 设置基础属性
                post.Title = edttitle.Text.Trim();
                post.date = DateTime.Now;

                // 初始化博客组件
                var bm = new Blog_Main();
                var tagtext = post.Tags == null ? "" : string.Join(",", post.Tags);

                // 前置验证：工作目录
                if (!Directory.Exists(bm.Base_addr))
                {
                    ShowErrorDialog($"无效的工作目录：{bm.Base_addr}");
                    return;
                }

                // 参数安全处理（防止命令注入）
                var sanitizedTitle = post.Title.Replace("\"", "\\\"");
                var sanitizedTags = tagtext.Replace("\"", "\\\"");

                // 配置进程参数
                using var process = new Process();
                process.StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = bm.Base_addr,
                    FileName = "node",  // 直接调用Node.js
                    Arguments = $".\\create_post.js \"{sanitizedTitle}\" \"{sanitizedTags}\"",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                // 启动进程并捕获输出
                var output = new StringBuilder();
                var error = new StringBuilder();

                process.OutputDataReceived += (sender, args) => output.AppendLine(args.Data);
                process.ErrorDataReceived += (sender, args) => error.AppendLine(args.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit(5000);  // 设置超时时间

                // 结果处理
                if (process.ExitCode != 0 || !string.IsNullOrWhiteSpace(error.ToString()))
                {
                    var errorMessage = $"执行失败（代码：{process.ExitCode}）\n错误信息：{error}";
                    Console.WriteLine(errorMessage);
                    ShowErrorDialog(errorMessage);
                    return;
                }

                // 调试信息输出
                Console.WriteLine($"执行成功！输出：{output}");
                Console.WriteLine($"工作目录：{bm.Base_addr}");

                // 后续处理（原注释掉的YAML处理逻辑）
                // ... [保留原有注释的YAML处理代码]
            }
            catch (Exception ex)
            {
                ShowErrorDialog($"发生未预期错误：{ex.Message}");
                Console.WriteLine($"异常堆栈：{ex.StackTrace}");
            }
        }
        private void enterkeyinput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                add_tags_Click(sender, e);
            }

        }
 
    }
}
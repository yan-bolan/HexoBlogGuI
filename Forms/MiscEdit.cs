﻿using ChiSaTo.Model;
using Sunny.UI;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using System.Globalization;
using YamlDotNet.Serialization.Converters;

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
            link.UseDoubleClick= true;
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

        private void btnOK_Click(object sender, EventArgs e)
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
            post.Title =edttitle.Text;
            post.date= DateTime.Now;

            #region covert to Front Matter YAML


            var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .WithTypeConverter(new DateTimeConverter(
                   //provider: CultureInfo.CurrentCulture,
                   formats: new[] {  "yyyy-MM-dd hh:mm:ss" , "yyyy-MM-dd"})
               )
            .Build();
            var yaml = serializer.Serialize(post);
            #endregion//https://github.com/aaubry/YamlDotNet
            var bm = new Blog_Main();

            bm.Post_Content = $"---\n{yaml.Trim()}\n---\n";
            bm.main(Enum_Blog.New_Post_by_file, post.Title.Trim());
        }
    }
}
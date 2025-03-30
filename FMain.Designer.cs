using Sunny.UI;
namespace ChiSaTo
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("控件");
            TreeNode treeNode2 = new TreeNode("窗体");
            TreeNode treeNode3 = new TreeNode("图表");
            TreeNode treeNode4 = new TreeNode("工控");
            TreeNode treeNode5 = new TreeNode("主题");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            uiAvatar = new UIAvatar();
            StyleManager = new UIStyleManager(components);
            uiContextMenuStrip1 = new UIContextMenuStrip();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            Header.SuspendLayout();
            uiContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Aside
            // 
            Aside.ForeColor = Color.FromArgb(240, 240, 240);
            Aside.ItemHeight = 36;
            Aside.LineColor = Color.Black;
            Aside.Location = new Point(2, 146);
            Aside.MenuStyle = UIMenuStyle.Custom;
            Aside.ScrollBarColor = Color.FromArgb(240, 240, 240);
            Aside.ScrollBarHoverColor = Color.FromArgb(240, 240, 240);
            Aside.ScrollBarPressColor = Color.FromArgb(240, 240, 240);
            Aside.SelectedForeColor = Color.FromArgb(220, 155, 40);
            Aside.SelectedHighColor = Color.FromArgb(220, 155, 40);
            Aside.ShowOneNode = true;
            Aside.ShowSecondBackColor = true;
            Aside.ShowTips = true;
            Aside.Size = new Size(250, 572);
            Aside.Style = UIStyle.Orange;
            // 
            // Header
            // 
            Header.Controls.Add(pictureBox1);
            Header.Controls.Add(uiAvatar);
            Header.Location = new Point(2, 36);
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "节点0";
            treeNode1.Text = "控件";
            treeNode2.Name = "节点1";
            treeNode2.Text = "窗体";
            treeNode3.Name = "节点2";
            treeNode3.Text = "图表";
            treeNode4.Name = "节点0";
            treeNode4.Text = "工控";
            treeNode5.Name = "节点2";
            treeNode5.Text = "主题";
            Header.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
            Header.NodeSize = new Size(110, 45);
            Header.SelectedForeColor = Color.FromArgb(220, 155, 40);
            Header.SelectedHighColor = Color.FromArgb(220, 155, 40);
            Header.SelectedIndex = 0;
            Header.Size = new Size(1020, 110);
            Header.Style = UIStyle.Orange;
            Header.MenuItemClick += Header_MenuItemClick;
            // 
            // uiAvatar
            // 
            uiAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            uiAvatar.Font = new Font("Microsoft YaHei", 12F);
            uiAvatar.ForeColor = Color.FromArgb(220, 155, 40);
            uiAvatar.Icon = UIAvatar.UIIcon.Image;
            uiAvatar.Image = Properties.Resources.avtarhutao;
            uiAvatar.Location = new Point(939, 25);
            uiAvatar.MinimumSize = new Size(1, 1);
            uiAvatar.Name = "uiAvatar";
            uiAvatar.Size = new Size(66, 70);
            uiAvatar.Style = UIStyle.Orange;
            uiAvatar.TabIndex = 4;
            uiAvatar.Text = "uiAvatar1";
            uiAvatar.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // StyleManager
            // 
            StyleManager.DPIScale = true;
            // 
            // uiContextMenuStrip1
            // 
            uiContextMenuStrip1.BackColor = Color.FromArgb(243, 249, 255);
            uiContextMenuStrip1.Font = new Font("Microsoft YaHei", 12F);
            uiContextMenuStrip1.IsScaled = true;
            uiContextMenuStrip1.Items.AddRange(new ToolStripItem[] { 关于ToolStripMenuItem, 关于ToolStripMenuItem1 });
            uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            uiContextMenuStrip1.Size = new Size(113, 56);
            uiContextMenuStrip1.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(112, 26);
            关于ToolStripMenuItem.Text = "主页";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem1
            // 
            关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1";
            关于ToolStripMenuItem1.Size = new Size(112, 26);
            关于ToolStripMenuItem1.Text = "关于";
            关于ToolStripMenuItem1.Click += 关于ToolStripMenuItem1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1024, 720);
            ControlBoxFillHoverColor = Color.FromArgb(227, 175, 83);
            ExtendBox = true;
            ExtendMenu = uiContextMenuStrip1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1024, 720);
            Name = "FMain";
            Padding = new Padding(2, 36, 2, 2);
            RectColor = Color.FromArgb(220, 155, 40);
            ShowDragStretch = true;
            ShowRadius = false;
            ShowShadow = true;
            Style = UIStyle.Orange;
            Text = "博客";
            TitleColor = Color.FromArgb(220, 155, 40);
            ZoomScaleRect = new Rectangle(15, 15, 1024, 720);
            Selecting += FMain_Selecting;
            HotKeyEventHandler += FMain_HotKeyEventHandler;
            ReceiveParams += FMain_ReceiveParams;
            Controls.SetChildIndex(Header, 0);
            Controls.SetChildIndex(Aside, 0);
            Header.ResumeLayout(false);
            uiContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private UIAvatar uiAvatar;
        private UIStyleManager StyleManager;
        private UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem1;
        private PictureBox pictureBox1;
    }
}
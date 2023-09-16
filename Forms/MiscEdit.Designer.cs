using Sunny.UI;
namespace ChiSaTo
{
    partial class HeaderEdit
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
            edttitle = new UITextBox();
            title = new UILabel();
            uiLabel3 = new UILabel();
            edttags = new UITextBox();
            add_tags = new UIButton();
            uiFlowLayoutPanelTags = new UIFlowLayoutPanel();
            pnlBtm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBtm
            // 
            pnlBtm.FillColor = Color.FromArgb(253, 249, 241);
            pnlBtm.FillColor2 = Color.FromArgb(253, 249, 241);
            pnlBtm.Location = new Point(1, 304);
            pnlBtm.RectColor = Color.FromArgb(220, 155, 40);
            pnlBtm.Size = new Size(518, 55);
            pnlBtm.Style = UIStyle.Orange;
            pnlBtm.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.FillColor = Color.FromArgb(220, 155, 40);
            btnCancel.FillColor2 = Color.FromArgb(220, 155, 40);
            btnCancel.FillHoverColor = Color.FromArgb(227, 175, 83);
            btnCancel.FillPressColor = Color.FromArgb(176, 124, 32);
            btnCancel.FillSelectedColor = Color.FromArgb(176, 124, 32);
            btnCancel.Location = new Point(390, 12);
            btnCancel.RectColor = Color.FromArgb(220, 155, 40);
            btnCancel.RectHoverColor = Color.FromArgb(227, 175, 83);
            btnCancel.RectPressColor = Color.FromArgb(176, 124, 32);
            btnCancel.RectSelectedColor = Color.FromArgb(176, 124, 32);
            btnCancel.Style = UIStyle.Orange;
            // 
            // btnOK
            // 
            btnOK.FillColor = Color.FromArgb(220, 155, 40);
            btnOK.FillColor2 = Color.FromArgb(220, 155, 40);
            btnOK.FillHoverColor = Color.FromArgb(227, 175, 83);
            btnOK.FillPressColor = Color.FromArgb(176, 124, 32);
            btnOK.FillSelectedColor = Color.FromArgb(176, 124, 32);
            btnOK.Location = new Point(275, 12);
            btnOK.RectColor = Color.FromArgb(220, 155, 40);
            btnOK.RectHoverColor = Color.FromArgb(227, 175, 83);
            btnOK.RectPressColor = Color.FromArgb(176, 124, 32);
            btnOK.RectSelectedColor = Color.FromArgb(176, 124, 32);
            btnOK.Style = UIStyle.Orange;
            btnOK.Click += btnOK_Click;
            // 
            // edttitle
            // 
            edttitle.ButtonFillColor = Color.FromArgb(220, 155, 40);
            edttitle.ButtonFillHoverColor = Color.FromArgb(227, 175, 83);
            edttitle.ButtonFillPressColor = Color.FromArgb(176, 124, 32);
            edttitle.ButtonRectColor = Color.FromArgb(220, 155, 40);
            edttitle.ButtonRectHoverColor = Color.FromArgb(227, 175, 83);
            edttitle.ButtonRectPressColor = Color.FromArgb(176, 124, 32);
            edttitle.Cursor = Cursors.IBeam;
            edttitle.EnterAsTab = true;
            edttitle.FillColor2 = Color.FromArgb(253, 249, 241);
            edttitle.Font = new Font("Microsoft YaHei", 12F);
            edttitle.Location = new Point(150, 55);
            edttitle.Margin = new Padding(4, 5, 4, 5);
            edttitle.MinimumSize = new Size(1, 16);
            edttitle.Name = "edttitle";
            edttitle.Padding = new Padding(5);
            edttitle.RectColor = Color.FromArgb(220, 155, 40);
            edttitle.ScrollBarColor = Color.FromArgb(220, 155, 40);
            edttitle.ShowText = false;
            edttitle.Size = new Size(340, 29);
            edttitle.Style = UIStyle.Orange;
            edttitle.TabIndex = 0;
            edttitle.TextAlignment = ContentAlignment.MiddleLeft;
            edttitle.Watermark = "";
            edttitle.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Microsoft YaHei", 12F);
            title.Location = new Point(56, 59);
            title.Name = "title";
            title.Size = new Size(58, 21);
            title.Style = UIStyle.Orange;
            title.TabIndex = 4;
            title.Text = "标题：";
            title.TextAlign = ContentAlignment.MiddleLeft;
            title.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            uiLabel3.AutoSize = true;
            uiLabel3.Font = new Font("Microsoft YaHei", 12F);
            uiLabel3.Location = new Point(56, 99);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(58, 21);
            uiLabel3.Style = UIStyle.Orange;
            uiLabel3.TabIndex = 6;
            uiLabel3.Text = "标签：";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            uiLabel3.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // edttags
            // 
            edttags.ButtonFillColor = Color.FromArgb(220, 155, 40);
            edttags.ButtonFillHoverColor = Color.FromArgb(227, 175, 83);
            edttags.ButtonFillPressColor = Color.FromArgb(176, 124, 32);
            edttags.ButtonRectColor = Color.FromArgb(220, 155, 40);
            edttags.ButtonRectHoverColor = Color.FromArgb(227, 175, 83);
            edttags.ButtonRectPressColor = Color.FromArgb(176, 124, 32);
            edttags.Cursor = Cursors.IBeam;
            edttags.FillColor2 = Color.FromArgb(253, 249, 241);
            edttags.Font = new Font("Microsoft YaHei", 12F);
            edttags.Location = new Point(150, 102);
            edttags.Margin = new Padding(4, 5, 4, 5);
            edttags.MinimumSize = new Size(1, 16);
            edttags.Name = "edttags";
            edttags.Padding = new Padding(5);
            edttags.RectColor = Color.FromArgb(220, 155, 40);
            edttags.ScrollBarColor = Color.FromArgb(220, 155, 40);
            edttags.ShowText = false;
            edttags.Size = new Size(170, 29);
            edttags.Style = UIStyle.Orange;
            edttags.TabIndex = 6;
            edttags.TextAlignment = ContentAlignment.MiddleLeft;
            edttags.Watermark = "";
            edttags.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            edttags.KeyPress += enterkeyinput;
            // 
            // add_tags
            // 
            add_tags.FillColor = Color.FromArgb(220, 155, 40);
            add_tags.FillColor2 = Color.FromArgb(220, 155, 40);
            add_tags.FillHoverColor = Color.FromArgb(227, 175, 83);
            add_tags.FillPressColor = Color.FromArgb(176, 124, 32);
            add_tags.FillSelectedColor = Color.FromArgb(176, 124, 32);
            add_tags.Font = new Font("Microsoft YaHei", 12F);
            add_tags.Location = new Point(369, 99);
            add_tags.MinimumSize = new Size(1, 1);
            add_tags.Name = "add_tags";
            add_tags.Radius = 26;
            add_tags.RectColor = Color.FromArgb(220, 155, 40);
            add_tags.RectHoverColor = Color.FromArgb(227, 175, 83);
            add_tags.RectPressColor = Color.FromArgb(176, 124, 32);
            add_tags.RectSelectedColor = Color.FromArgb(176, 124, 32);
            add_tags.Size = new Size(82, 35);
            add_tags.Style = UIStyle.Orange;
            add_tags.TabIndex = 17;
            add_tags.Text = "添加";
            add_tags.UseDoubleClick = true;
            add_tags.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            add_tags.Click += add_tags_Click;
            // 
            // uiFlowLayoutPanelTags
            // 
            uiFlowLayoutPanelTags.FillColor = Color.FromArgb(253, 249, 241);
            uiFlowLayoutPanelTags.FillColor2 = Color.FromArgb(253, 249, 241);
            uiFlowLayoutPanelTags.Font = new Font("Microsoft YaHei", 12F);
            uiFlowLayoutPanelTags.Location = new Point(150, 157);
            uiFlowLayoutPanelTags.Margin = new Padding(4, 5, 4, 5);
            uiFlowLayoutPanelTags.MinimumSize = new Size(1, 1);
            uiFlowLayoutPanelTags.Name = "uiFlowLayoutPanelTags";
            uiFlowLayoutPanelTags.Padding = new Padding(2);
            uiFlowLayoutPanelTags.RectColor = Color.FromArgb(220, 155, 40);
            uiFlowLayoutPanelTags.ScrollBarBackColor = Color.FromArgb(253, 249, 241);
            uiFlowLayoutPanelTags.ScrollBarColor = Color.FromArgb(220, 155, 40);
            uiFlowLayoutPanelTags.ShowText = false;
            uiFlowLayoutPanelTags.Size = new Size(324, 107);
            uiFlowLayoutPanelTags.Style = UIStyle.Orange;
            uiFlowLayoutPanelTags.TabIndex = 18;
            uiFlowLayoutPanelTags.Text = "uiFlowLayoutPanelTags";
            uiFlowLayoutPanelTags.TextAlignment = ContentAlignment.MiddleCenter;
            uiFlowLayoutPanelTags.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // HeaderEdit
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(520, 362);
            ControlBoxFillHoverColor = Color.FromArgb(227, 175, 83);
            Controls.Add(uiFlowLayoutPanelTags);
            Controls.Add(add_tags);
            Controls.Add(edttags);
            Controls.Add(uiLabel3);
            Controls.Add(edttitle);
            Controls.Add(title);
            Name = "HeaderEdit";
            RectColor = Color.FromArgb(220, 155, 40);
            Style = UIStyle.Orange;
            Text = "创建文章";
            TitleColor = Color.FromArgb(220, 155, 40);
            ZoomScaleRect = new Rectangle(15, 15, 520, 362);
            Controls.SetChildIndex(title, 0);
            Controls.SetChildIndex(edttitle, 0);
            Controls.SetChildIndex(uiLabel3, 0);
            Controls.SetChildIndex(edttags, 0);
            Controls.SetChildIndex(pnlBtm, 0);
            Controls.SetChildIndex(add_tags, 0);
            Controls.SetChildIndex(uiFlowLayoutPanelTags, 0);
            pnlBtm.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private UITextBox edttitle;
        private UILabel title;
        private UILabel uiLabel3;
        private UITextBox edttags;
        private UIButton add_tags;
        private UIFlowLayoutPanel uiFlowLayoutPanelTags;
    }
}
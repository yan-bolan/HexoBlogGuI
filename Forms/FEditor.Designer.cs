using Sunny.UI; namespace ChiSaTo
{
    partial class FEditor
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
            uiLine2 = new UILine();
            uiSymbolButton1 = new UISymbolButton();
            btnAdd = new UISymbolButton();
            uiLine1 = new UILine();
            btnEdit = new UISymbolButton();
            SuspendLayout();
            // 
            // uiLine2
            // 
            uiLine2.Font = new Font("微软雅黑", 12F);
            uiLine2.Location = new Point(30, 149);
            uiLine2.MinimumSize = new Size(16, 16);
            uiLine2.Name = "uiLine2";
            uiLine2.Size = new Size(670, 20);
            uiLine2.TabIndex = 27;
            uiLine2.Text = "UIEditForm 代码生成";
            uiLine2.TextAlign = ContentAlignment.MiddleLeft;
            uiLine2.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // uiSymbolButton1
            // 
            uiSymbolButton1.Cursor = Cursors.Hand;
            uiSymbolButton1.Font = new Font("微软雅黑", 12F);
            uiSymbolButton1.Location = new Point(30, 184);
            uiSymbolButton1.MinimumSize = new Size(1, 1);
            uiSymbolButton1.Name = "uiSymbolButton1";
            uiSymbolButton1.Padding = new Padding(28, 0, 0, 0);
            uiSymbolButton1.Size = new Size(100, 35);
            uiSymbolButton1.Symbol = 61543;
            uiSymbolButton1.TabIndex = 26;
            uiSymbolButton1.Text = "增加";
            uiSymbolButton1.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            uiSymbolButton1.Click += uiSymbolButton1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("微软雅黑", 12F);
            btnAdd.Location = new Point(30, 92);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(28, 0, 0, 0);
            btnAdd.Size = new Size(100, 35);
            btnAdd.Symbol = 61543;
            btnAdd.TabIndex = 25;
            btnAdd.Text = "增加";
            btnAdd.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            btnAdd.Click += btnAdd_Click;
            // 
            // uiLine1
            // 
            uiLine1.Font = new Font("微软雅黑", 12F);
            uiLine1.Location = new Point(30, 55);
            uiLine1.MinimumSize = new Size(16, 16);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(670, 20);
            uiLine1.TabIndex = 24;
            uiLine1.Text = "UIEditForm";
            uiLine1.TextAlign = ContentAlignment.MiddleLeft;
            uiLine1.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Font = new Font("微软雅黑", 12F);
            btnEdit.Location = new Point(152, 92);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Padding = new Padding(28, 0, 0, 0);
            btnEdit.Size = new Size(100, 35);
            btnEdit.Symbol = 61508;
            btnEdit.TabIndex = 23;
            btnEdit.Text = "编辑";
            btnEdit.ZoomScaleRect = new Rectangle(0, 0, 0, 0);
            btnEdit.Click += btnEdit_Click;
            // 
            // FEditor
            // 
            AllowShowTitle = true;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1579, 573);
            Controls.Add(uiLine2);
            Controls.Add(uiSymbolButton1);
            Controls.Add(btnAdd);
            Controls.Add(uiLine1);
            Controls.Add(btnEdit);
            Name = "FEditor";
            Padding = new Padding(0, 35, 0, 0);
            ShowTitle = true;
            Symbol = 61508;
            Text = "Editor";
            ResumeLayout(false);

        }

        #endregion

        private UILine uiLine2;
        private UISymbolButton uiSymbolButton1;
        private UISymbolButton btnAdd;
        private UILine uiLine1;
        private UISymbolButton btnEdit;
    }
}
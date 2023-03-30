namespace DLL_Injector
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.appListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creatorLabel = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dllTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.injectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.selectBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // appListView
            // 
            this.appListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appListView.BackColor = System.Drawing.SystemColors.ControlText;
            this.appListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.appListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.appListView.ForeColor = System.Drawing.Color.White;
            this.appListView.FullRowSelect = true;
            this.appListView.HideSelection = false;
            this.appListView.Location = new System.Drawing.Point(25, 275);
            this.appListView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.appListView.MultiSelect = false;
            this.appListView.Name = "appListView";
            this.appListView.Size = new System.Drawing.Size(1480, 371);
            this.appListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.appListView.TabIndex = 4;
            this.appListView.UseCompatibleStateImageBehavior = false;
            this.appListView.View = System.Windows.Forms.View.Details;
            this.appListView.SelectedIndexChanged += new System.EventHandler(this.appListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 387;
            // 
            // creatorLabel
            // 
            this.creatorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.creatorLabel.Location = new System.Drawing.Point(19, 778);
            this.creatorLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(0, 32);
            this.creatorLabel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pictureBox1.Location = new System.Drawing.Point(-44, -69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1615, 944);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(135)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(1449, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 54);
            this.label5.TabIndex = 13;
            this.label5.Text = "✕";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1546, 102);
            this.guna2Panel1.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(35, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 46);
            this.label9.TabIndex = 26;
            this.label9.Text = "dll injector";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dllTxtBox
            // 
            this.dllTxtBox.BackColor = System.Drawing.Color.White;
            this.dllTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dllTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dllTxtBox.DefaultText = "";
            this.dllTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dllTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dllTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dllTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dllTxtBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dllTxtBox.ForeColor = System.Drawing.Color.Transparent;
            this.dllTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dllTxtBox.Location = new System.Drawing.Point(25, 179);
            this.dllTxtBox.Margin = new System.Windows.Forms.Padding(19);
            this.dllTxtBox.Name = "dllTxtBox";
            this.dllTxtBox.PasswordChar = '\0';
            this.dllTxtBox.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.dllTxtBox.PlaceholderText = "";
            this.dllTxtBox.ReadOnly = true;
            this.dllTxtBox.SelectedText = "";
            this.dllTxtBox.Size = new System.Drawing.Size(1142, 55);
            this.dllTxtBox.TabIndex = 83;
            // 
            // injectBtn
            // 
            this.injectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.injectBtn.BorderThickness = 1;
            this.injectBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.injectBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Green;
            this.injectBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.injectBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.injectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.injectBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.injectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.injectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.injectBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.injectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.injectBtn.Location = new System.Drawing.Point(1194, 691);
            this.injectBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(311, 81);
            this.injectBtn.TabIndex = 84;
            this.injectBtn.Text = "inject";
            this.injectBtn.Click += new System.EventHandler(this.injectBtn_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // selectBtn
            // 
            this.selectBtn.AllowDrop = true;
            this.selectBtn.Animated = true;
            this.selectBtn.AnimatedGIF = true;
            this.selectBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.selectBtn.BorderThickness = 1;
            this.selectBtn.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.selectBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Green;
            this.selectBtn.CheckedState.FillColor = System.Drawing.Color.Green;
            this.selectBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.selectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.selectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.selectBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.selectBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.selectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.selectBtn.Location = new System.Drawing.Point(1207, 167);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(298, 81);
            this.selectBtn.TabIndex = 85;
            this.selectBtn.Text = "select dll";
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1546, 842);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.dllTxtBox);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.appListView);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "dll injector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView appListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.LinkLabel creatorLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button injectBtn;
        private Guna.UI2.WinForms.Guna2TextBox dllTxtBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button selectBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}


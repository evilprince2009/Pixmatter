namespace Pixmatter
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FormatBox = new System.Windows.Forms.ComboBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.OutDirectory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox
            // 
            this.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox.Location = new System.Drawing.Point(28, 73);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(409, 262);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 0;
            this.PictureBox.TabStop = false;
            this.PictureBox.DoubleClick += new System.EventHandler(this.PictureBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click inside the box to select image";
            // 
            // FormatBox
            // 
            this.FormatBox.BackColor = System.Drawing.SystemColors.Window;
            this.FormatBox.FormattingEnabled = true;
            this.FormatBox.Items.AddRange(new object[] {
            "jpeg",
            "png",
            "tiff",
            "bmp",
            "ico",
            "emf",
            "wmf",
            "gif"});
            this.FormatBox.Location = new System.Drawing.Point(28, 342);
            this.FormatBox.Name = "FormatBox";
            this.FormatBox.Size = new System.Drawing.Size(103, 23);
            this.FormatBox.TabIndex = 2;
            this.FormatBox.Text = "Choose Format";
            this.FormatBox.SelectedIndexChanged += new System.EventHandler(this.FormatBox_SelectedIndexChanged);
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonConvert.Location = new System.Drawing.Point(27, 371);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(410, 30);
            this.ButtonConvert.TabIndex = 3;
            this.ButtonConvert.Text = "Convert";
            this.ButtonConvert.UseVisualStyleBackColor = true;
            this.ButtonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // OutDirectory
            // 
            this.OutDirectory.Location = new System.Drawing.Point(137, 342);
            this.OutDirectory.Name = "OutDirectory";
            this.OutDirectory.PlaceholderText = "Output directory";
            this.OutDirectory.Size = new System.Drawing.Size(300, 23);
            this.OutDirectory.TabIndex = 4;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.OutDirectory);
            this.Controls.Add(this.ButtonConvert);
            this.Controls.Add(this.FormatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBox);
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pixmatter";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FormatBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.TextBox OutDirectory;
    }
}


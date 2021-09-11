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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.format_Box = new System.Windows.Forms.ComboBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.outDirectory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(28, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(409, 262);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Double click the box to select image";
            // 
            // format_Box
            // 
            this.format_Box.BackColor = System.Drawing.SystemColors.Window;
            this.format_Box.FormattingEnabled = true;
            this.format_Box.Items.AddRange(new object[] {
            "jpeg",
            "png",
            "tiff",
            "bmp",
            "ico",
            "emf",
            "wmf"});
            this.format_Box.Location = new System.Drawing.Point(28, 342);
            this.format_Box.Name = "format_Box";
            this.format_Box.Size = new System.Drawing.Size(103, 23);
            this.format_Box.TabIndex = 2;
            this.format_Box.Text = "Choose Format";
            // 
            // btn_Convert
            // 
            this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Convert.Location = new System.Drawing.Point(27, 371);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(410, 30);
            this.btn_Convert.TabIndex = 3;
            this.btn_Convert.Text = "Convert";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // outDirectory
            // 
            this.outDirectory.Location = new System.Drawing.Point(137, 342);
            this.outDirectory.Name = "outDirectory";
            this.outDirectory.PlaceholderText = "Output directory";
            this.outDirectory.Size = new System.Drawing.Size(300, 23);
            this.outDirectory.TabIndex = 4;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.outDirectory);
            this.Controls.Add(this.btn_Convert);
            this.Controls.Add(this.format_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "AppForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Pixmatter";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox format_Box;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btn_Convert;
        private System.Windows.Forms.TextBox outDirectory;
    }
}


using System;
using System.Drawing;
using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;

namespace Pixmatter
{
    public partial class AppForm : MetroForm
    {
        private string _imagePath;
        private string _imageFormat;
        public AppForm()
        {
            InitializeComponent();
        }

        private void CheckDestination()
        {
            string directory = outDirectory.Text;
            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch (Exception)
                {
                    MessageBox.Show("Path doesn't exist. Couldn't create a directory for  you", "Oops !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            CheckDestination();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog filePicker = new OpenFileDialog())
            {
                if (filePicker.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.ImageLocation = filePicker.FileName;
                    _imagePath = filePicker.FileName;
                }
            }
        }

        private void ConvertImage(string format)
        {
            try
            {
                Image image = Image.FromFile(_imagePath);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void format_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (format_Box.SelectedIndex)
            {
                case 0:
                    _imageFormat = "jpeg";
                    break;
                case 1:
                    _imageFormat = "png";
                    break;
                case 2:
                    _imageFormat = "tiff";
                    break;
                case 3:
                    _imageFormat = "bmp";
                    break;
                case 4:
                    _imageFormat = "ico";
                    break;
                case 5:
                    _imageFormat = "emf";
                    break;
                case 6:
                    _imageFormat = "wmf";
                    break;
                default:
                    _imageFormat = null;
                    break;
            }
        }
    }
}

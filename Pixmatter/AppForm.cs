using System;
using System.Drawing;
using System.Drawing.Imaging;
using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;

namespace Pixmatter
{
    public partial class AppForm : MetroForm
    {
        private string _imagePath;
        private string _imageFormat;
        private string _directory;
        public AppForm()
        {
            InitializeComponent();
        }

        private void CheckDestination()
        {
            _directory = outDirectory.Text;
            if (!Directory.Exists(_directory))
            {
                try
                {
                    Directory.CreateDirectory(_directory);
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
            if (_imagePath != null)
            {
                ConvertImage(_imageFormat);
                }
            else
            {
                MessageBox.Show("No image selected for conversion." , "Hang on !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            using OpenFileDialog filePicker = new();
            if (filePicker.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = filePicker.FileName;
                _imagePath = filePicker.FileName;
            }
        }

        private void ConvertImage(string format)
        {
            string imageBuffer = _directory + "\\" + 
                                 Path.GetFileNameWithoutExtension(_imagePath) + "." + format;
            try
            {
                Image image = Image.FromFile(_imagePath);
                
                switch (format)
                {
                    case "jpeg":
                        image.Save(imageBuffer, ImageFormat.Jpeg);
                        break;
                    case "png":
                        image.Save(imageBuffer, ImageFormat.Png);
                        break;
                    case "tiff":
                        image.Save(imageBuffer, ImageFormat.Tiff);
                        break;
                    case "bmp":
                        image.Save(imageBuffer, ImageFormat.Bmp);
                        break;
                    case "ico":
                        image.Save(imageBuffer, ImageFormat.Icon);
                        break;
                    case "emf":
                        image.Save(imageBuffer, ImageFormat.Emf);
                        break;
                    case "wmf":
                        image.Save(imageBuffer, ImageFormat.Wmf);
                        break;
                    case "gif":
                        image.Save(imageBuffer, ImageFormat.Gif);
                        break;
                    case null:
                        MessageBox.Show("Select a format to proceed.", "Invalid operation !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                }
                MessageBox.Show("Image converted successfully.\n Saved to " + _directory, "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Something unusual happened.", "Hang on !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void format_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            _imageFormat = format_Box.SelectedIndex switch
            {
                0 => "jpeg",
                1 => "png",
                2 => "tiff",
                3 => "bmp",
                4 => "ico",
                5 => "emf",
                6 => "wmf",
                7 => "gif",
                _ => null
            };
        }
    }
}

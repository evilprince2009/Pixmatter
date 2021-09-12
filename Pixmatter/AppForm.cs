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
                    MessageBox.Show("Path doesn't exist. Couldn't create a directory for  you", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
           
            if (_imagePath != null)
            {
                CheckDestination();
                ConvertImage(_imageFormat);
            }
            else
            {
                MessageBox.Show("No image selected for conversion." , "Hang On", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (_directory != "")
            {

                string imageBuffer = _directory + "\\" + 
                                     Path.GetFileNameWithoutExtension(_imagePath) + "." + format;
                try
                {
                    Image image = Image.FromFile(_imagePath);
                    if (format != null)
                    {
                        if (format == "jpeg")
                        {
                            image.Save(imageBuffer, ImageFormat.Jpeg);
                            SuccessMessage();
                        }
                        else if (format == "png")
                        {
                            image.Save(imageBuffer, ImageFormat.Png);
                            SuccessMessage();
                        }
                        else if (format == "tiff")
                        {
                            image.Save(imageBuffer, ImageFormat.Tiff);
                            SuccessMessage();
                        }
                        else if (format == "bmp")
                        {
                            image.Save(imageBuffer, ImageFormat.Bmp);
                            SuccessMessage();
                        }
                        else if (format == "bmp")
                        {
                            image.Save(imageBuffer, ImageFormat.Bmp);
                            SuccessMessage();
                        }
                        else if (format == "ico")
                        {
                            image.Save(imageBuffer, ImageFormat.Icon);
                            SuccessMessage();
                        }
                        else if (format == "emf")
                        {
                            image.Save(imageBuffer, ImageFormat.Emf);
                            SuccessMessage();
                        }
                        else if (format == "wmf")
                        {
                            image.Save(imageBuffer, ImageFormat.Wmf);
                            SuccessMessage();
                        }
                        else if (format == "gif")
                        {
                            image.Save(imageBuffer, ImageFormat.Gif);
                            SuccessMessage();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a format to proceed.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Something unusual happened.", "Hang On", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SuccessMessage()
        {
            MessageBox.Show("Image converted successfully.\n Saved to " + _directory, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

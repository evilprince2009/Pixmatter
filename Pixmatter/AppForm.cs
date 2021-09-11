using System;
using MetroFramework.Forms;
using System.IO;
using System.Windows.Forms;

namespace Pixmatter
{
    public partial class AppForm : MetroForm
    {
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
    }
}

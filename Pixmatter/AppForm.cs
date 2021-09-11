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
            // CheckDestination();
        }

        private void CheckDestination()
        {
            if (!Directory.Exists(outDirectory.Text))
            {
                try
                {
                    Directory.CreateDirectory(outDirectory.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Path doesn't exist. Couldn't create a directory for  you","Oops !", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}

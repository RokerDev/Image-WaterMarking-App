using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Viewier
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void ClearPictureBox()
        {
            if (pbImage.Image != null)
                pbImage.Image.Dispose();
            pbImage.Image = null;
        }

        private void AddTextToImage()
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofdOpen.ShowDialog();

            if (!File.Exists(ofdOpen.FileName))
                return;

            pScroll.Controls.Add(pbImage);
            Bitmap bitmap = new Bitmap(ofdOpen.FileName);
            pbImage.Image = (Image)bitmap;            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClearPictureBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.ShowDialog();

            if (sfdSave.CheckPathExists)
                return;

            pbImage.Image.Save(sfdSave.FileName);
            ClearPictureBox();
        }
    }
}

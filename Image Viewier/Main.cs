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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofdOpen.ShowDialog();

            if (!File.Exists(ofdOpen.FileName))
                return;

            panel1.Controls.Add(pbImage);
            Bitmap bitmap = new Bitmap(ofdOpen.FileName);
            pbImage.Image = (Image)bitmap;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
                pbImage.Image.Dispose();
                pbImage.Image = null;
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Image_Viewier
{
    public partial class mainWindow : Form
    {
        private int _X;
        private int _Y;
        private int _fontSize;
        private bool _wantAdd;
        private Font _font;
        private Color _fontColor;
        private string _waterMarkText;
        private Brush _brush;
        private Bitmap _bitmap;
        private Graphics _graphics;


        public mainWindow()
        {
            InitializeComponent();
            _fontSize = 20;
            _wantAdd = false;
            fdChangeFont.Font = new Font("Arial", _fontSize, FontStyle.Regular);
            _font = fdChangeFont.Font;
            _fontColor = Color.FromKnownColor(KnownColor.Black);
            _waterMarkText = "";                        
        }

        private void ResetApp()
        {
            HideOptionButtons();
            HideImageOptionButtons();
            ClearPictureBox();
        }

        private void ClearPictureBox()
        {
            if (pbImage.Image != null)
                pbImage.Image.Dispose();
            if (_bitmap != null)
                _bitmap.Dispose();
            if (_graphics != null)
                _graphics.Dispose();
            if (_brush != null)
                _brush.Dispose();

            pbImage.Image = null;
        }

        private void RefreshPictureBox()
        {
            if (!_wantAdd)
                return;

            ClearPictureBox();
            _bitmap = new Bitmap(ofdOpen.FileName);
            pbImage.Image = (Image)_bitmap;
            AddTextToImage();
        }

        private void RefreshChanges()
        {
            _wantAdd = true;
            RefreshPictureBox();
            _wantAdd = false;
        }

        private void AddTextToImage()
        {

            _graphics = Graphics.FromImage((Bitmap)pbImage.Image);
            _graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            _brush = new SolidBrush(_fontColor);

            Point point = new Point(_X, _Y);

            _graphics.DrawString(_waterMarkText, _font, _brush, point);            

            pbImage.Image = (Image)pbImage.Image;            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                ofdOpen.Filter = "" +
                        "Image Files (*.png)|*.png|" +
                        "Image Files (*.jpg)|*.jpg|" +
                        "Image Files (*.gif)|*.gif|" +
                        "All Files (*.*)|*.*";

                ofdOpen.ShowDialog();

                if (!File.Exists(ofdOpen.FileName))
                    return;

                pScroll.Controls.Add(pbImage);
                Bitmap bitmap = new Bitmap(ofdOpen.FileName);
                if (bitmap != null)
                {
                    pbImage.Height = bitmap.Height;
                    pbImage.Width = bitmap.Width;
                    pbImage.Load(ofdOpen.FileName);
                    bitmap.Dispose();
                    ShowOptionButtons();
                }                               
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong File. Please try Again");
            }
        }

        private void HideOptionButtons()
        {
            btnSave.Visible = false;
            btnClose.Visible = false;
            btnAddText.Visible = false;
            btnOpen.Visible = true;
        }

        private void ShowOptionButtons()
        {
            btnSave.Visible = true;
            btnClose.Visible = true;
            btnAddText.Visible = true;
            btnOpen.Visible = false;
        }

        private void ShowImageOptionButtons()
        {
            tbWaterMarkText.Visible = true;
            btnChangeFont.Visible = true;
            btnChangeTextColor.Visible = true;
            btnAddText.Visible = false;
            lbHelp.Visible = true;
            lbHelp1.Visible = true;
        }

        private void HideImageOptionButtons()
        {
            tbWaterMarkText.Visible = false;
            btnChangeFont.Visible = false;
            btnChangeTextColor.Visible = false;
            btnAddText.Visible = false;
            lbHelp.Visible = false;
            lbHelp1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ResetApp();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.DefaultExt = "png";
            sfdSave.Filter = "Image Files (*.png)|*.png|All Files (*.*)|*.*";
            sfdSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            sfdSave.ShowDialog();

            pbImage.Image.Save(sfdSave.FileName);
            ResetApp();
        }

        private void pbImage_MouseDown(object sender, MouseEventArgs e)
        {
            _wantAdd = true;
        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_wantAdd)
            {
                _X = e.X;
                _Y = e.Y;
                RefreshPictureBox();
            }
        }

        private void btnAddText_Click(object sender, EventArgs e)
        {
            _X = 0;
            _Y = 0;
            tbWaterMarkText.Text = "Default Text";
            ShowImageOptionButtons();
        }

        private void pbImage_MouseUp(object sender, MouseEventArgs e)
        {
            _wantAdd = false;
        }

        private void btnChangeTextColor_Click(object sender, EventArgs e)
        {
            cdChangeColor.ShowDialog();
            btnChangeTextColor.BackColor = cdChangeColor.Color;
            _fontColor = cdChangeColor.Color;
            
            _brush.Dispose();
            _brush = new SolidBrush(_fontColor);
            RefreshChanges();
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fdChangeFont.ShowDialog();
            btnChangeFont.Text = fdChangeFont.Font.Name;
            _font = fdChangeFont.Font;
            RefreshChanges();
        }

        private void tbWaterMarkText_TextChanged(object sender, EventArgs e)
        {
            _waterMarkText = tbWaterMarkText.Text;
            RefreshChanges();
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClearPictureBox();
        }
    }
}

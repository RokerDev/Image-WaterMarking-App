namespace Image_Viewier
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pScroll = new System.Windows.Forms.Panel();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.btnAddText = new System.Windows.Forms.Button();
            this.tbWaterMarkText = new System.Windows.Forms.TextBox();
            this.cdChangeColor = new System.Windows.Forms.ColorDialog();
            this.btnChangeTextColor = new System.Windows.Forms.Button();
            this.fdChangeFont = new System.Windows.Forms.FontDialog();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbHelp1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(163, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Import Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 41);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbImage
            // 
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(94, 81);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseDown);
            this.pbImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseMove);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImage_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 70);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pScroll
            // 
            this.pScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pScroll.AutoScroll = true;
            this.pScroll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pScroll.Controls.Add(this.pbImage);
            this.pScroll.Location = new System.Drawing.Point(181, 13);
            this.pScroll.Name = "pScroll";
            this.pScroll.Size = new System.Drawing.Size(957, 581);
            this.pScroll.TabIndex = 6;
            // 
            // btnAddText
            // 
            this.btnAddText.Location = new System.Drawing.Point(12, 99);
            this.btnAddText.Name = "btnAddText";
            this.btnAddText.Size = new System.Drawing.Size(163, 23);
            this.btnAddText.TabIndex = 3;
            this.btnAddText.Text = "Add Text";
            this.btnAddText.UseVisualStyleBackColor = true;
            this.btnAddText.Visible = false;
            this.btnAddText.Click += new System.EventHandler(this.btnAddText_Click);
            // 
            // tbWaterMarkText
            // 
            this.tbWaterMarkText.Location = new System.Drawing.Point(12, 164);
            this.tbWaterMarkText.Name = "tbWaterMarkText";
            this.tbWaterMarkText.Size = new System.Drawing.Size(163, 20);
            this.tbWaterMarkText.TabIndex = 3;
            this.tbWaterMarkText.Visible = false;
            this.tbWaterMarkText.TextChanged += new System.EventHandler(this.tbWaterMarkText_TextChanged);
            // 
            // btnChangeTextColor
            // 
            this.btnChangeTextColor.BackColor = System.Drawing.Color.Black;
            this.btnChangeTextColor.Location = new System.Drawing.Point(12, 190);
            this.btnChangeTextColor.Name = "btnChangeTextColor";
            this.btnChangeTextColor.Size = new System.Drawing.Size(24, 23);
            this.btnChangeTextColor.TabIndex = 7;
            this.btnChangeTextColor.UseVisualStyleBackColor = false;
            this.btnChangeTextColor.Visible = false;
            this.btnChangeTextColor.Click += new System.EventHandler(this.btnChangeTextColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(42, 190);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(133, 23);
            this.btnChangeFont.TabIndex = 8;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Visible = false;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHelp.Location = new System.Drawing.Point(12, 125);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(166, 18);
            this.lbHelp.TabIndex = 9;
            this.lbHelp.Text = "Set WaterMark Position";
            this.lbHelp.Visible = false;
            // 
            // lbHelp1
            // 
            this.lbHelp1.AutoSize = true;
            this.lbHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHelp1.Location = new System.Drawing.Point(39, 143);
            this.lbHelp1.Name = "lbHelp1";
            this.lbHelp1.Size = new System.Drawing.Size(104, 18);
            this.lbHelp1.TabIndex = 10;
            this.lbHelp1.Text = "Just Drag Text";
            this.lbHelp1.Visible = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1144, 606);
            this.Controls.Add(this.lbHelp1);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnChangeTextColor);
            this.Controls.Add(this.tbWaterMarkText);
            this.Controls.Add(this.btnAddText);
            this.Controls.Add(this.pScroll);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Watermarking App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pScroll.ResumeLayout(false);
            this.pScroll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pScroll;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.Button btnAddText;
        private System.Windows.Forms.TextBox tbWaterMarkText;
        private System.Windows.Forms.ColorDialog cdChangeColor;
        private System.Windows.Forms.Button btnChangeTextColor;
        private System.Windows.Forms.FontDialog fdChangeFont;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Label lbHelp;
        private System.Windows.Forms.Label lbHelp1;
    }
}


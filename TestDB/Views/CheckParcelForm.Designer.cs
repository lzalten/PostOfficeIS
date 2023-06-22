namespace PostOfficeIS.Views
{
    partial class CheckParcelForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Heighttxt = new TextBox();
            Weighttxt = new TextBox();
            Nametxt = new TextBox();
            Previousbtn = new MaterialSkin.Controls.MaterialButton();
            Confirmbtn = new MaterialSkin.Controls.MaterialButton();
            Nextbtn = new MaterialSkin.Controls.MaterialButton();
            label5 = new Label();
            Frangilitybtn = new MaterialSkin.Controls.MaterialSwitch();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(424, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(24, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 329);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 357);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Weight";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 329);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(424, 357);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 5;
            label4.Text = "Frangility";
            // 
            // Heighttxt
            // 
            Heighttxt.Location = new Point(86, 326);
            Heighttxt.Name = "Heighttxt";
            Heighttxt.Size = new Size(138, 23);
            Heighttxt.TabIndex = 6;
            // 
            // Weighttxt
            // 
            Weighttxt.Location = new Point(86, 357);
            Weighttxt.Name = "Weighttxt";
            Weighttxt.Size = new Size(138, 23);
            Weighttxt.TabIndex = 7;
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(479, 326);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(145, 23);
            Nametxt.TabIndex = 8;
            // 
            // Previousbtn
            // 
            Previousbtn.AutoSize = false;
            Previousbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Previousbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Previousbtn.Depth = 0;
            Previousbtn.HighEmphasis = true;
            Previousbtn.Icon = null;
            Previousbtn.Location = new Point(149, 424);
            Previousbtn.Margin = new Padding(4, 6, 4, 6);
            Previousbtn.MouseState = MaterialSkin.MouseState.HOVER;
            Previousbtn.Name = "Previousbtn";
            Previousbtn.NoAccentTextColor = Color.Empty;
            Previousbtn.Size = new Size(75, 36);
            Previousbtn.TabIndex = 10;
            Previousbtn.Text = "<<";
            Previousbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Previousbtn.UseAccentColor = false;
            Previousbtn.UseVisualStyleBackColor = true;
            Previousbtn.Click += Previousbtn_Click;
            // 
            // Confirmbtn
            // 
            Confirmbtn.AutoSize = false;
            Confirmbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Confirmbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Confirmbtn.Depth = 0;
            Confirmbtn.HighEmphasis = true;
            Confirmbtn.Icon = null;
            Confirmbtn.Location = new Point(262, 424);
            Confirmbtn.Margin = new Padding(4, 6, 4, 6);
            Confirmbtn.MouseState = MaterialSkin.MouseState.HOVER;
            Confirmbtn.Name = "Confirmbtn";
            Confirmbtn.NoAccentTextColor = Color.Empty;
            Confirmbtn.Size = new Size(130, 36);
            Confirmbtn.TabIndex = 11;
            Confirmbtn.Text = "Confirm";
            Confirmbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Confirmbtn.UseAccentColor = false;
            Confirmbtn.UseVisualStyleBackColor = true;
            Confirmbtn.Click += Confirmbtn_Click;
            // 
            // Nextbtn
            // 
            Nextbtn.AutoSize = false;
            Nextbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Nextbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Nextbtn.Depth = 0;
            Nextbtn.HighEmphasis = true;
            Nextbtn.Icon = null;
            Nextbtn.Location = new Point(424, 423);
            Nextbtn.Margin = new Padding(4, 6, 4, 6);
            Nextbtn.MouseState = MaterialSkin.MouseState.HOVER;
            Nextbtn.Name = "Nextbtn";
            Nextbtn.NoAccentTextColor = Color.Empty;
            Nextbtn.Size = new Size(75, 36);
            Nextbtn.TabIndex = 12;
            Nextbtn.Text = ">>";
            Nextbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Nextbtn.UseAccentColor = false;
            Nextbtn.UseVisualStyleBackColor = true;
            Nextbtn.Click += Nextbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 117);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 13;
            label5.Text = "Id:";
            label5.Click += label5_Click;
            // 
            // Frangilitybtn
            // 
            Frangilitybtn.AutoSize = true;
            Frangilitybtn.Depth = 0;
            Frangilitybtn.Location = new Point(518, 350);
            Frangilitybtn.Margin = new Padding(0);
            Frangilitybtn.MouseLocation = new Point(-1, -1);
            Frangilitybtn.MouseState = MaterialSkin.MouseState.HOVER;
            Frangilitybtn.Name = "Frangilitybtn";
            Frangilitybtn.Ripple = true;
            Frangilitybtn.Size = new Size(58, 37);
            Frangilitybtn.TabIndex = 14;
            Frangilitybtn.UseVisualStyleBackColor = true;
            // 
            // CheckParcelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 469);
            Controls.Add(Frangilitybtn);
            Controls.Add(label5);
            Controls.Add(Nextbtn);
            Controls.Add(Confirmbtn);
            Controls.Add(Previousbtn);
            Controls.Add(Nametxt);
            Controls.Add(Weighttxt);
            Controls.Add(Heighttxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CheckParcelForm";
            Text = "CheckParcelForm";
            Load += CheckParcelForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox Heighttxt;
        public TextBox Weighttxt;
        public TextBox Nametxt;
        public MaterialSkin.Controls.MaterialButton Previousbtn;
        public MaterialSkin.Controls.MaterialButton Confirmbtn;
        public MaterialSkin.Controls.MaterialButton Nextbtn;
        private Label label5;
        public MaterialSkin.Controls.MaterialSwitch Frangilitybtn;
    }
}
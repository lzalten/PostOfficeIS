namespace PostOfficeIS.Views
{
    partial class ReceiveParcel
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
            Nametxt = new TextBox();
            Surnametxt = new TextBox();
            Phonetxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            ShowParcelsbtn = new MaterialSkin.Controls.MaterialButton();
            TakeParcels = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(133, 86);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(212, 23);
            Nametxt.TabIndex = 0;
            // 
            // Surnametxt
            // 
            Surnametxt.Location = new Point(133, 131);
            Surnametxt.Name = "Surnametxt";
            Surnametxt.Size = new Size(212, 23);
            Surnametxt.TabIndex = 1;
            // 
            // Phonetxt
            // 
            Phonetxt.Location = new Point(133, 173);
            Phonetxt.Name = "Phonetxt";
            Phonetxt.Size = new Size(212, 23);
            Phonetxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 94);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 139);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 181);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Phone";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(397, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(400, 335);
            dataGridView1.TabIndex = 6;
            // 
            // ShowParcelsbtn
            // 
            ShowParcelsbtn.AutoSize = false;
            ShowParcelsbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ShowParcelsbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ShowParcelsbtn.Depth = 0;
            ShowParcelsbtn.HighEmphasis = true;
            ShowParcelsbtn.Icon = null;
            ShowParcelsbtn.Location = new Point(29, 228);
            ShowParcelsbtn.Margin = new Padding(4, 6, 4, 6);
            ShowParcelsbtn.MouseState = MaterialSkin.MouseState.HOVER;
            ShowParcelsbtn.Name = "ShowParcelsbtn";
            ShowParcelsbtn.NoAccentTextColor = Color.Empty;
            ShowParcelsbtn.Size = new Size(316, 57);
            ShowParcelsbtn.TabIndex = 7;
            ShowParcelsbtn.Text = "Show parcels";
            ShowParcelsbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ShowParcelsbtn.UseAccentColor = false;
            ShowParcelsbtn.UseVisualStyleBackColor = true;
            // 
            // TakeParcels
            // 
            TakeParcels.AutoSize = false;
            TakeParcels.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TakeParcels.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            TakeParcels.Depth = 0;
            TakeParcels.HighEmphasis = true;
            TakeParcels.Icon = null;
            TakeParcels.Location = new Point(29, 297);
            TakeParcels.Margin = new Padding(4, 6, 4, 6);
            TakeParcels.MouseState = MaterialSkin.MouseState.HOVER;
            TakeParcels.Name = "TakeParcels";
            TakeParcels.NoAccentTextColor = Color.Empty;
            TakeParcels.Size = new Size(316, 57);
            TakeParcels.TabIndex = 8;
            TakeParcels.Text = "Take parcels";
            TakeParcels.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            TakeParcels.UseAccentColor = false;
            TakeParcels.UseVisualStyleBackColor = true;
            // 
            // ReceiveParcel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 457);
            Controls.Add(TakeParcels);
            Controls.Add(ShowParcelsbtn);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Phonetxt);
            Controls.Add(Surnametxt);
            Controls.Add(Nametxt);
            Name = "ReceiveParcel";
            Text = "ReceiveParcel";
            Load += ReceiveParcel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Nametxt;
        private TextBox Surnametxt;
        private TextBox Phonetxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton ShowParcelsbtn;
        private MaterialSkin.Controls.MaterialButton TakeParcels;
    }
}
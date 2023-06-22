namespace PostOfficeIS.Views
{
    partial class MenuForm
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
            SendParcelbtn = new MaterialSkin.Controls.MaterialButton();
            ReceiveParcelbtn = new MaterialSkin.Controls.MaterialButton();
            SignInbtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // SendParcelbtn
            // 
            SendParcelbtn.AutoSize = false;
            SendParcelbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SendParcelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SendParcelbtn.Depth = 0;
            SendParcelbtn.HighEmphasis = true;
            SendParcelbtn.Icon = null;
            SendParcelbtn.Location = new Point(33, 76);
            SendParcelbtn.Margin = new Padding(4, 6, 4, 6);
            SendParcelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            SendParcelbtn.Name = "SendParcelbtn";
            SendParcelbtn.NoAccentTextColor = Color.Empty;
            SendParcelbtn.Size = new Size(293, 75);
            SendParcelbtn.TabIndex = 0;
            SendParcelbtn.Text = "Send parcel";
            SendParcelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SendParcelbtn.UseAccentColor = false;
            SendParcelbtn.UseVisualStyleBackColor = true;
            SendParcelbtn.Click += SendParcelbtn_Click;
            // 
            // ReceiveParcelbtn
            // 
            ReceiveParcelbtn.AutoSize = false;
            ReceiveParcelbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ReceiveParcelbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            ReceiveParcelbtn.Depth = 0;
            ReceiveParcelbtn.HighEmphasis = true;
            ReceiveParcelbtn.Icon = null;
            ReceiveParcelbtn.Location = new Point(33, 163);
            ReceiveParcelbtn.Margin = new Padding(4, 6, 4, 6);
            ReceiveParcelbtn.MouseState = MaterialSkin.MouseState.HOVER;
            ReceiveParcelbtn.Name = "ReceiveParcelbtn";
            ReceiveParcelbtn.NoAccentTextColor = Color.Empty;
            ReceiveParcelbtn.Size = new Size(293, 75);
            ReceiveParcelbtn.TabIndex = 1;
            ReceiveParcelbtn.Text = "Receive Parcel";
            ReceiveParcelbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            ReceiveParcelbtn.UseAccentColor = false;
            ReceiveParcelbtn.UseVisualStyleBackColor = true;
            ReceiveParcelbtn.Click += ReceiveParcelbtn_Click;
            // 
            // SignInbtn
            // 
            SignInbtn.AutoSize = false;
            SignInbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignInbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SignInbtn.Depth = 0;
            SignInbtn.HighEmphasis = true;
            SignInbtn.Icon = null;
            SignInbtn.Location = new Point(33, 250);
            SignInbtn.Margin = new Padding(4, 6, 4, 6);
            SignInbtn.MouseState = MaterialSkin.MouseState.HOVER;
            SignInbtn.Name = "SignInbtn";
            SignInbtn.NoAccentTextColor = Color.Empty;
            SignInbtn.Size = new Size(293, 75);
            SignInbtn.TabIndex = 2;
            SignInbtn.Text = "Sign in";
            SignInbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SignInbtn.UseAccentColor = false;
            SignInbtn.UseVisualStyleBackColor = true;
            SignInbtn.Click += SignInbtn_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 341);
            Controls.Add(SignInbtn);
            Controls.Add(ReceiveParcelbtn);
            Controls.Add(SendParcelbtn);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton SendParcelbtn;
        private MaterialSkin.Controls.MaterialButton ReceiveParcelbtn;
        private MaterialSkin.Controls.MaterialButton SignInbtn;
    }
}
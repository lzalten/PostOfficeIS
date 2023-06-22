namespace PostOfficeIS.Views
{
    partial class AutorizationForm
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
            label1 = new Label();
            label2 = new Label();
            Logintxt = new TextBox();
            Passwordtxt = new TextBox();
            SignInbtn = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 105);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 0;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(52, 142);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // Logintxt
            // 
            Logintxt.Location = new Point(163, 105);
            Logintxt.Name = "Logintxt";
            Logintxt.Size = new Size(143, 23);
            Logintxt.TabIndex = 2;
            // 
            // Passwordtxt
            // 
            Passwordtxt.Location = new Point(163, 147);
            Passwordtxt.Name = "Passwordtxt";
            Passwordtxt.PasswordChar = '*';
            Passwordtxt.Size = new Size(143, 23);
            Passwordtxt.TabIndex = 3;
            // 
            // SignInbtn
            // 
            SignInbtn.AutoSize = false;
            SignInbtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SignInbtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            SignInbtn.Depth = 0;
            SignInbtn.HighEmphasis = true;
            SignInbtn.Icon = null;
            SignInbtn.Location = new Point(52, 205);
            SignInbtn.Margin = new Padding(4, 6, 4, 6);
            SignInbtn.MouseState = MaterialSkin.MouseState.HOVER;
            SignInbtn.Name = "SignInbtn";
            SignInbtn.NoAccentTextColor = Color.Empty;
            SignInbtn.Size = new Size(254, 54);
            SignInbtn.TabIndex = 4;
            SignInbtn.Text = "Sign in";
            SignInbtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            SignInbtn.UseAccentColor = false;
            SignInbtn.UseVisualStyleBackColor = true;
            SignInbtn.Click += SignInbtn_Click;
            // 
            // AutorizationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 317);
            Controls.Add(SignInbtn);
            Controls.Add(Passwordtxt);
            Controls.Add(Logintxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AutorizationForm";
            Text = "AutorizationForm";
            Load += AutorizationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox Logintxt;
        public TextBox Passwordtxt;
        private MaterialSkin.Controls.MaterialButton SignInbtn;
    }
}
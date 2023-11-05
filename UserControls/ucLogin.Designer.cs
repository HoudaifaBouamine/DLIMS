namespace UserControls
{
    partial class ucLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnl_Main = new Guna.UI2.WinForms.Guna2Panel();
            pnl_Right = new Guna.UI2.WinForms.Guna2Panel();
            pnl_LoginWindow = new Guna.UI2.WinForms.Guna2ShadowPanel();
            linkLabel1 = new LinkLabel();
            btn_Login = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            label3 = new Label();
            tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            tb_Email = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            pnl_Left = new Guna.UI2.WinForms.Guna2Panel();
            pnl_Main.SuspendLayout();
            pnl_Right.SuspendLayout();
            pnl_LoginWindow.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Main
            // 
            pnl_Main.BackColor = Color.FromArgb(30, 30, 30);
            pnl_Main.Controls.Add(pnl_Right);
            pnl_Main.Controls.Add(pnl_Left);
            pnl_Main.CustomizableEdges = customizableEdges11;
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.Location = new Point(0, 0);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnl_Main.Size = new Size(1440, 953);
            pnl_Main.TabIndex = 1;
            // 
            // pnl_Right
            // 
            pnl_Right.BackColor = Color.FromArgb(30, 30, 30);
            pnl_Right.Controls.Add(pnl_LoginWindow);
            pnl_Right.CustomizableEdges = customizableEdges7;
            pnl_Right.Dock = DockStyle.Fill;
            pnl_Right.Location = new Point(720, 0);
            pnl_Right.Name = "pnl_Right";
            pnl_Right.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnl_Right.Size = new Size(720, 953);
            pnl_Right.TabIndex = 1;
            pnl_Right.Paint += pnl_Right_Paint_1;
            // 
            // pnl_LoginWindow
            // 
            pnl_LoginWindow.Anchor = AnchorStyles.None;
            pnl_LoginWindow.BackColor = Color.Transparent;
            pnl_LoginWindow.Controls.Add(linkLabel1);
            pnl_LoginWindow.Controls.Add(btn_Login);
            pnl_LoginWindow.Controls.Add(label4);
            pnl_LoginWindow.Controls.Add(label3);
            pnl_LoginWindow.Controls.Add(tb_Password);
            pnl_LoginWindow.Controls.Add(label2);
            pnl_LoginWindow.Controls.Add(tb_Email);
            pnl_LoginWindow.Controls.Add(label1);
            pnl_LoginWindow.FillColor = Color.FromArgb(44, 44, 44);
            pnl_LoginWindow.Location = new Point(115, 165);
            pnl_LoginWindow.Name = "pnl_LoginWindow";
            pnl_LoginWindow.Padding = new Padding(10, 13, 10, 13);
            pnl_LoginWindow.Radius = 12;
            pnl_LoginWindow.ShadowColor = Color.Black;
            pnl_LoginWindow.ShadowDepth = 200;
            pnl_LoginWindow.ShadowShift = 8;
            pnl_LoginWindow.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            pnl_LoginWindow.Size = new Size(490, 623);
            pnl_LoginWindow.TabIndex = 0;
            pnl_LoginWindow.LocationChanged += pnl_LoginWindow_LocationChanged;
            pnl_LoginWindow.Resize += Form1_Resize;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            linkLabel1.ForeColor = Color.FromArgb(213, 213, 213);
            linkLabel1.LinkColor = Color.FromArgb(213, 213, 213);
            linkLabel1.Location = new Point(40, 435);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(91, 21);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.Visible = false;
            // 
            // btn_Login
            // 
            btn_Login.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Login.Animated = true;
            btn_Login.BorderRadius = 4;
            btn_Login.CustomizableEdges = customizableEdges1;
            btn_Login.DisabledState.BorderColor = Color.DarkGray;
            btn_Login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_Login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_Login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_Login.FillColor = Color.FromArgb(255, 209, 0);
            btn_Login.Font = new Font("Arial", 23F, FontStyle.Bold, GraphicsUnit.Pixel);
            btn_Login.ForeColor = Color.Black;
            btn_Login.HoverState.BorderColor = Color.Red;
            btn_Login.HoverState.FillColor = Color.Blue;
            btn_Login.Location = new Point(27, 470);
            btn_Login.Name = "btn_Login";
            btn_Login.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_Login.Size = new Size(431, 50);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.Click += btn_Login_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.FromArgb(213, 213, 213);
            label4.Location = new Point(27, 414);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 3;
            label4.Text = "forget password ?";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 316);
            label3.Name = "label3";
            label3.Size = new Size(116, 26);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tb_Password
            // 
            tb_Password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Password.BorderRadius = 4;
            tb_Password.CustomizableEdges = customizableEdges3;
            tb_Password.DefaultText = "";
            tb_Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tb_Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tb_Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tb_Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tb_Password.FillColor = Color.FromArgb(44, 44, 44);
            tb_Password.FocusedState.BorderColor = Color.FromArgb(255, 209, 0);
            tb_Password.Font = new Font("Calibri Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Password.ForeColor = Color.White;
            tb_Password.HoverState.BorderColor = Color.FromArgb(255, 209, 0);
            tb_Password.Location = new Point(27, 352);
            tb_Password.Margin = new Padding(10);
            tb_Password.Name = "tb_Password";
            tb_Password.PasswordChar = '●';
            tb_Password.PlaceholderForeColor = Color.FromArgb(95, 95, 95);
            tb_Password.PlaceholderText = "●●●●●●●●●●●●●";
            tb_Password.SelectedText = "";
            tb_Password.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tb_Password.Size = new Size(431, 52);
            tb_Password.TabIndex = 1;
            tb_Password.TextOffset = new Point(24, 0);
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 190);
            label2.Name = "label2";
            label2.Size = new Size(60, 26);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // tb_Email
            // 
            tb_Email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_Email.BorderRadius = 4;
            tb_Email.CustomizableEdges = customizableEdges5;
            tb_Email.DefaultText = "";
            tb_Email.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tb_Email.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tb_Email.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tb_Email.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tb_Email.FillColor = Color.FromArgb(44, 44, 44);
            tb_Email.FocusedState.BorderColor = Color.FromArgb(255, 209, 0);
            tb_Email.Font = new Font("Calibri Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            tb_Email.ForeColor = Color.White;
            tb_Email.HoverState.BorderColor = Color.FromArgb(255, 209, 0);
            tb_Email.Location = new Point(27, 226);
            tb_Email.Margin = new Padding(10);
            tb_Email.Name = "tb_Email";
            tb_Email.PasswordChar = '\0';
            tb_Email.PlaceholderForeColor = Color.FromArgb(95, 95, 95);
            tb_Email.PlaceholderText = "e.g email@gmail.com";
            tb_Email.SelectedText = "";
            tb_Email.ShadowDecoration.CustomizableEdges = customizableEdges6;
            tb_Email.Size = new Size(431, 52);
            tb_Email.TabIndex = 0;
            tb_Email.TextOffset = new Point(24, 0);
            tb_Email.Load += guna2TextBox1_Load;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 37.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(145, 63);
            label1.Name = "label1";
            label1.Size = new Size(202, 73);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pnl_Left
            // 
            pnl_Left.BackColor = Color.FromArgb(255, 209, 0);
            pnl_Left.CustomizableEdges = customizableEdges9;
            pnl_Left.Dock = DockStyle.Left;
            pnl_Left.Location = new Point(0, 0);
            pnl_Left.Name = "pnl_Left";
            pnl_Left.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnl_Left.Size = new Size(720, 953);
            pnl_Left.TabIndex = 0;
            // 
            // ucLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_Main);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ucLogin";
            Size = new Size(1440, 953);
            pnl_Main.ResumeLayout(false);
            pnl_Right.ResumeLayout(false);
            pnl_LoginWindow.ResumeLayout(false);
            pnl_LoginWindow.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_Main;
        private Guna.UI2.WinForms.Guna2Panel pnl_Right;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_LoginWindow;
        private Guna.UI2.WinForms.Guna2Button btn_Login;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tb_Email;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnl_Left;
        private LinkLabel linkLabel1;
    }
}

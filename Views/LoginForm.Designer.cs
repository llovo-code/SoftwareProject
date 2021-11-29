
namespace Powertronic.Views
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            Guna.UI.Animation.Animation animation2 = new Guna.UI.Animation.Animation();
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.FirstPanel = new Guna.UI.WinForms.GunaPanel();
            this.Sign_In = new Guna.UI.WinForms.GunaPanel();
            this.btnSignInHidePassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnSignInShowPassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.linkCreateAcount = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSignIn = new Guna.UI.WinForms.GunaButton();
            this.txtSignInPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSignInUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaCirclePictureBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.Sign_Up = new Guna.UI.WinForms.GunaPanel();
            this.btnBackToLogin = new Guna.UI.WinForms.GunaPictureBox();
            this.btnSignUpReConfHidePassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnSignUpHidePassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnSignUpReConfShowPassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.txtSignUpReConfPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSignUpShowPassword = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.txtSignUpPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSignUpUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaCirclePictureBox4 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnExitFromApplication = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.labelEnterpriceName = new Guna.UI.WinForms.GunaLabel();
            this.SignIn_SignUp_animate = new Guna.UI.WinForms.GunaTransition(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.SignInTransition = new Guna.UI.WinForms.GunaTransition(this.components);
            this.FirstPanel.SuspendLayout();
            this.Sign_In.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).BeginInit();
            this.Sign_Up.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpReConfHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpReConfShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFromApplication)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstPanel
            // 
            this.FirstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.FirstPanel.Controls.Add(this.Sign_In);
            this.FirstPanel.Controls.Add(this.Sign_Up);
            this.FirstPanel.Controls.Add(this.btnExitFromApplication);
            this.FirstPanel.Controls.Add(this.gunaPanel1);
            this.SignInTransition.SetDecoration(this.FirstPanel, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.FirstPanel, Guna.UI.Animation.DecorationType.None);
            this.FirstPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstPanel.Location = new System.Drawing.Point(0, 0);
            this.FirstPanel.Name = "FirstPanel";
            this.FirstPanel.Size = new System.Drawing.Size(790, 555);
            this.FirstPanel.TabIndex = 0;
            // 
            // Sign_In
            // 
            this.Sign_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.Sign_In.Controls.Add(this.btnSignInHidePassword);
            this.Sign_In.Controls.Add(this.btnSignInShowPassword);
            this.Sign_In.Controls.Add(this.linkCreateAcount);
            this.Sign_In.Controls.Add(this.gunaPictureBox1);
            this.Sign_In.Controls.Add(this.btnSignIn);
            this.Sign_In.Controls.Add(this.txtSignInPassword);
            this.Sign_In.Controls.Add(this.txtSignInUsername);
            this.Sign_In.Controls.Add(this.gunaCirclePictureBox2);
            this.SignInTransition.SetDecoration(this.Sign_In, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.Sign_In, Guna.UI.Animation.DecorationType.None);
            this.Sign_In.Location = new System.Drawing.Point(394, 23);
            this.Sign_In.Name = "Sign_In";
            this.Sign_In.Size = new System.Drawing.Size(374, 514);
            this.Sign_In.TabIndex = 1;
            // 
            // btnSignInHidePassword
            // 
            this.btnSignInHidePassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignInHidePassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignInHidePassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignInHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignInHidePassword.Image")));
            this.btnSignInHidePassword.Location = new System.Drawing.Point(289, 265);
            this.btnSignInHidePassword.Name = "btnSignInHidePassword";
            this.btnSignInHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignInHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignInHidePassword.TabIndex = 10;
            this.btnSignInHidePassword.TabStop = false;
            this.btnSignInHidePassword.UseTransfarantBackground = false;
            this.btnSignInHidePassword.Visible = false;
            this.btnSignInHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
            // 
            // btnSignInShowPassword
            // 
            this.btnSignInShowPassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignInShowPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignInShowPassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignInShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignInShowPassword.Image")));
            this.btnSignInShowPassword.Location = new System.Drawing.Point(289, 266);
            this.btnSignInShowPassword.Name = "btnSignInShowPassword";
            this.btnSignInShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignInShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignInShowPassword.TabIndex = 4;
            this.btnSignInShowPassword.TabStop = false;
            this.btnSignInShowPassword.UseTransfarantBackground = false;
            this.btnSignInShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // linkCreateAcount
            // 
            this.linkCreateAcount.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.linkCreateAcount.AutoSize = true;
            this.SignInTransition.SetDecoration(this.linkCreateAcount, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.linkCreateAcount, Guna.UI.Animation.DecorationType.None);
            this.linkCreateAcount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkCreateAcount.LinkColor = System.Drawing.Color.Silver;
            this.linkCreateAcount.Location = new System.Drawing.Point(150, 436);
            this.linkCreateAcount.Name = "linkCreateAcount";
            this.linkCreateAcount.Size = new System.Drawing.Size(76, 15);
            this.linkCreateAcount.TabIndex = 4;
            this.linkCreateAcount.TabStop = true;
            this.linkCreateAcount.Text = "Crear Cuenta";
            this.linkCreateAcount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAcount_LinkClicked);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaPictureBox1, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(123, 54);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 3;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.Black;
            this.SignInTransition.SetDecoration(this.btnSignIn, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignIn, Guna.UI.Animation.DecorationType.None);
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIn.Location = new System.Drawing.Point(50, 364);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Size = new System.Drawing.Size(264, 42);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignInPassword
            // 
            this.txtSignInPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSignInPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSignInPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSignInPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignInTransition.SetDecoration(this.txtSignInPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.txtSignInPassword, Guna.UI.Animation.DecorationType.None);
            this.txtSignInPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSignInPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignInPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtSignInPassword.HintText = "Password";
            this.txtSignInPassword.isPassword = true;
            this.txtSignInPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSignInPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSignInPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSignInPassword.LineThickness = 3;
            this.txtSignInPassword.Location = new System.Drawing.Point(50, 262);
            this.txtSignInPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignInPassword.MaxLength = 32767;
            this.txtSignInPassword.Name = "txtSignInPassword";
            this.txtSignInPassword.Size = new System.Drawing.Size(264, 33);
            this.txtSignInPassword.TabIndex = 1;
            this.txtSignInPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSignInUsername
            // 
            this.txtSignInUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSignInUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSignInUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSignInUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignInTransition.SetDecoration(this.txtSignInUsername, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.txtSignInUsername, Guna.UI.Animation.DecorationType.None);
            this.txtSignInUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSignInUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignInUsername.HintForeColor = System.Drawing.Color.Silver;
            this.txtSignInUsername.HintText = "Usuario";
            this.txtSignInUsername.isPassword = false;
            this.txtSignInUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSignInUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSignInUsername.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSignInUsername.LineThickness = 3;
            this.txtSignInUsername.Location = new System.Drawing.Point(50, 193);
            this.txtSignInUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignInUsername.MaxLength = 32767;
            this.txtSignInUsername.Name = "txtSignInUsername";
            this.txtSignInUsername.Size = new System.Drawing.Size(264, 33);
            this.txtSignInUsername.TabIndex = 0;
            this.txtSignInUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaCirclePictureBox2
            // 
            this.gunaCirclePictureBox2.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.gunaCirclePictureBox2, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaCirclePictureBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox2.Image")));
            this.gunaCirclePictureBox2.Location = new System.Drawing.Point(289, 266);
            this.gunaCirclePictureBox2.Name = "gunaCirclePictureBox2";
            this.gunaCirclePictureBox2.Size = new System.Drawing.Size(25, 25);
            this.gunaCirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox2.TabIndex = 5;
            this.gunaCirclePictureBox2.TabStop = false;
            this.gunaCirclePictureBox2.UseTransfarantBackground = false;
            // 
            // Sign_Up
            // 
            this.Sign_Up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.Sign_Up.Controls.Add(this.btnBackToLogin);
            this.Sign_Up.Controls.Add(this.btnSignUpReConfHidePassword);
            this.Sign_Up.Controls.Add(this.btnSignUpHidePassword);
            this.Sign_Up.Controls.Add(this.btnSignUpReConfShowPassword);
            this.Sign_Up.Controls.Add(this.txtSignUpReConfPassword);
            this.Sign_Up.Controls.Add(this.btnSignUpShowPassword);
            this.Sign_Up.Controls.Add(this.gunaPictureBox2);
            this.Sign_Up.Controls.Add(this.gunaButton2);
            this.Sign_Up.Controls.Add(this.txtSignUpPassword);
            this.Sign_Up.Controls.Add(this.txtSignUpUsername);
            this.Sign_Up.Controls.Add(this.gunaCirclePictureBox4);
            this.SignInTransition.SetDecoration(this.Sign_Up, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.Sign_Up, Guna.UI.Animation.DecorationType.None);
            this.Sign_Up.Location = new System.Drawing.Point(394, 23);
            this.Sign_Up.Name = "Sign_Up";
            this.Sign_Up.Size = new System.Drawing.Size(374, 514);
            this.Sign_Up.TabIndex = 2;
            this.Sign_Up.Visible = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnBackToLogin, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnBackToLogin, Guna.UI.Animation.DecorationType.None);
            this.btnBackToLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToLogin.Image")));
            this.btnBackToLogin.Location = new System.Drawing.Point(0, 0);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(25, 25);
            this.btnBackToLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBackToLogin.TabIndex = 11;
            this.btnBackToLogin.TabStop = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnSignUpReConfHidePassword
            // 
            this.btnSignUpReConfHidePassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignUpReConfHidePassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignUpReConfHidePassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignUpReConfHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpReConfHidePassword.Image")));
            this.btnSignUpReConfHidePassword.Location = new System.Drawing.Point(289, 319);
            this.btnSignUpReConfHidePassword.Name = "btnSignUpReConfHidePassword";
            this.btnSignUpReConfHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignUpReConfHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignUpReConfHidePassword.TabIndex = 9;
            this.btnSignUpReConfHidePassword.TabStop = false;
            this.btnSignUpReConfHidePassword.UseTransfarantBackground = false;
            this.btnSignUpReConfHidePassword.Visible = false;
            this.btnSignUpReConfHidePassword.Click += new System.EventHandler(this.btnSignUpReConfHidePassword_Click);
            // 
            // btnSignUpHidePassword
            // 
            this.btnSignUpHidePassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignUpHidePassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignUpHidePassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignUpHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpHidePassword.Image")));
            this.btnSignUpHidePassword.Location = new System.Drawing.Point(289, 266);
            this.btnSignUpHidePassword.Name = "btnSignUpHidePassword";
            this.btnSignUpHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignUpHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignUpHidePassword.TabIndex = 8;
            this.btnSignUpHidePassword.TabStop = false;
            this.btnSignUpHidePassword.UseTransfarantBackground = false;
            this.btnSignUpHidePassword.Visible = false;
            this.btnSignUpHidePassword.Click += new System.EventHandler(this.btnSignUpHidePassword_Click);
            // 
            // btnSignUpReConfShowPassword
            // 
            this.btnSignUpReConfShowPassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignUpReConfShowPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignUpReConfShowPassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignUpReConfShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpReConfShowPassword.Image")));
            this.btnSignUpReConfShowPassword.Location = new System.Drawing.Point(289, 319);
            this.btnSignUpReConfShowPassword.Name = "btnSignUpReConfShowPassword";
            this.btnSignUpReConfShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignUpReConfShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignUpReConfShowPassword.TabIndex = 7;
            this.btnSignUpReConfShowPassword.TabStop = false;
            this.btnSignUpReConfShowPassword.UseTransfarantBackground = false;
            this.btnSignUpReConfShowPassword.Click += new System.EventHandler(this.btnSignUpReConfShowPassword_Click);
            // 
            // txtSignUpReConfPassword
            // 
            this.txtSignUpReConfPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSignUpReConfPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSignUpReConfPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSignUpReConfPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignInTransition.SetDecoration(this.txtSignUpReConfPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.txtSignUpReConfPassword, Guna.UI.Animation.DecorationType.None);
            this.txtSignUpReConfPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSignUpReConfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignUpReConfPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtSignUpReConfPassword.HintText = "Confirmar Password";
            this.txtSignUpReConfPassword.isPassword = false;
            this.txtSignUpReConfPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSignUpReConfPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSignUpReConfPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSignUpReConfPassword.LineThickness = 3;
            this.txtSignUpReConfPassword.Location = new System.Drawing.Point(50, 319);
            this.txtSignUpReConfPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpReConfPassword.MaxLength = 32767;
            this.txtSignUpReConfPassword.Name = "txtSignUpReConfPassword";
            this.txtSignUpReConfPassword.Size = new System.Drawing.Size(264, 33);
            this.txtSignUpReConfPassword.TabIndex = 6;
            this.txtSignUpReConfPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSignUpShowPassword
            // 
            this.btnSignUpShowPassword.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnSignUpShowPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnSignUpShowPassword, Guna.UI.Animation.DecorationType.None);
            this.btnSignUpShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUpShowPassword.Image")));
            this.btnSignUpShowPassword.Location = new System.Drawing.Point(289, 266);
            this.btnSignUpShowPassword.Name = "btnSignUpShowPassword";
            this.btnSignUpShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnSignUpShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignUpShowPassword.TabIndex = 4;
            this.btnSignUpShowPassword.TabStop = false;
            this.btnSignUpShowPassword.UseTransfarantBackground = false;
            this.btnSignUpShowPassword.Click += new System.EventHandler(this.btnSingUpShowPassword_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.gunaPictureBox2, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaPictureBox2, Guna.UI.Animation.DecorationType.None);
            this.gunaPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox2.Image")));
            this.gunaPictureBox2.Location = new System.Drawing.Point(123, 54);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 3;
            this.gunaPictureBox2.TabStop = false;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.SignInTransition.SetDecoration(this.gunaButton2, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaButton2, Guna.UI.Animation.DecorationType.None);
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(50, 403);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(264, 42);
            this.gunaButton2.TabIndex = 2;
            this.gunaButton2.Text = "Sign Up";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSignUpPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSignUpPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSignUpPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignInTransition.SetDecoration(this.txtSignUpPassword, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.txtSignUpPassword, Guna.UI.Animation.DecorationType.None);
            this.txtSignUpPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSignUpPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignUpPassword.HintForeColor = System.Drawing.Color.Silver;
            this.txtSignUpPassword.HintText = "Password";
            this.txtSignUpPassword.isPassword = false;
            this.txtSignUpPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSignUpPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSignUpPassword.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSignUpPassword.LineThickness = 3;
            this.txtSignUpPassword.Location = new System.Drawing.Point(50, 262);
            this.txtSignUpPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpPassword.MaxLength = 32767;
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(264, 33);
            this.txtSignUpPassword.TabIndex = 1;
            this.txtSignUpPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSignUpUsername
            // 
            this.txtSignUpUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSignUpUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSignUpUsername.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSignUpUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SignInTransition.SetDecoration(this.txtSignUpUsername, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.txtSignUpUsername, Guna.UI.Animation.DecorationType.None);
            this.txtSignUpUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSignUpUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSignUpUsername.HintForeColor = System.Drawing.Color.Silver;
            this.txtSignUpUsername.HintText = "Usuario";
            this.txtSignUpUsername.isPassword = false;
            this.txtSignUpUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.txtSignUpUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSignUpUsername.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSignUpUsername.LineThickness = 3;
            this.txtSignUpUsername.Location = new System.Drawing.Point(50, 193);
            this.txtSignUpUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignUpUsername.MaxLength = 32767;
            this.txtSignUpUsername.Name = "txtSignUpUsername";
            this.txtSignUpUsername.Size = new System.Drawing.Size(264, 33);
            this.txtSignUpUsername.TabIndex = 0;
            this.txtSignUpUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gunaCirclePictureBox4
            // 
            this.gunaCirclePictureBox4.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.gunaCirclePictureBox4, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaCirclePictureBox4, Guna.UI.Animation.DecorationType.None);
            this.gunaCirclePictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox4.Image")));
            this.gunaCirclePictureBox4.Location = new System.Drawing.Point(289, 266);
            this.gunaCirclePictureBox4.Name = "gunaCirclePictureBox4";
            this.gunaCirclePictureBox4.Size = new System.Drawing.Size(25, 25);
            this.gunaCirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaCirclePictureBox4.TabIndex = 5;
            this.gunaCirclePictureBox4.TabStop = false;
            this.gunaCirclePictureBox4.UseTransfarantBackground = false;
            // 
            // btnExitFromApplication
            // 
            this.btnExitFromApplication.BaseColor = System.Drawing.Color.White;
            this.SignInTransition.SetDecoration(this.btnExitFromApplication, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.btnExitFromApplication, Guna.UI.Animation.DecorationType.None);
            this.btnExitFromApplication.Image = ((System.Drawing.Image)(resources.GetObject("btnExitFromApplication.Image")));
            this.btnExitFromApplication.Location = new System.Drawing.Point(762, 0);
            this.btnExitFromApplication.Name = "btnExitFromApplication";
            this.btnExitFromApplication.Size = new System.Drawing.Size(25, 25);
            this.btnExitFromApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExitFromApplication.TabIndex = 11;
            this.btnExitFromApplication.TabStop = false;
            this.btnExitFromApplication.Click += new System.EventHandler(this.btnExitFromApplication_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.labelEnterpriceName);
            this.SignInTransition.SetDecoration(this.gunaPanel1, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaPanel1, Guna.UI.Animation.DecorationType.None);
            this.gunaPanel1.Location = new System.Drawing.Point(17, 23);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(374, 514);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.SignInTransition.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaLabel4, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel4.Location = new System.Drawing.Point(124, 250);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(23, 28);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Y";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.SignInTransition.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaLabel3, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel3.Location = new System.Drawing.Point(137, 278);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 28);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Servicios";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.SignInTransition.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.gunaLabel2, Guna.UI.Animation.DecorationType.None);
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.Silver;
            this.gunaLabel2.Location = new System.Drawing.Point(27, 222);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(142, 28);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Computadoras";
            // 
            // labelEnterpriceName
            // 
            this.labelEnterpriceName.AutoSize = true;
            this.SignInTransition.SetDecoration(this.labelEnterpriceName, Guna.UI.Animation.DecorationType.None);
            this.SignIn_SignUp_animate.SetDecoration(this.labelEnterpriceName, Guna.UI.Animation.DecorationType.None);
            this.labelEnterpriceName.Font = new System.Drawing.Font("Segoe UI", 35F);
            this.labelEnterpriceName.ForeColor = System.Drawing.Color.Silver;
            this.labelEnterpriceName.Location = new System.Drawing.Point(5, 151);
            this.labelEnterpriceName.Name = "labelEnterpriceName";
            this.labelEnterpriceName.Size = new System.Drawing.Size(346, 62);
            this.labelEnterpriceName.TabIndex = 0;
            this.labelEnterpriceName.Text = "POWERTRONIC";
            // 
            // SignIn_SignUp_animate
            // 
            this.SignIn_SignUp_animate.AnimationType = Guna.UI.Animation.AnimationType.Scale;
            this.SignIn_SignUp_animate.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.SignIn_SignUp_animate.DefaultAnimation = animation2;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.FirstPanel;
            // 
            // SignInTransition
            // 
            this.SignInTransition.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.SignInTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.SignInTransition.DefaultAnimation = animation1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 555);
            this.Controls.Add(this.FirstPanel);
            this.SignIn_SignUp_animate.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.SignInTransition.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FirstPanel.ResumeLayout(false);
            this.Sign_In.ResumeLayout(false);
            this.Sign_In.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignInShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox2)).EndInit();
            this.Sign_Up.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBackToLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpReConfHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpReConfShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignUpShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitFromApplication)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel FirstPanel;
        private Guna.UI.WinForms.GunaPanel Sign_In;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel labelEnterpriceName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnSignIn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSignInPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSignInUsername;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignInShowPassword;
        private Guna.UI.WinForms.GunaLinkLabel linkCreateAcount;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox2;
        private Guna.UI.WinForms.GunaPanel Sign_Up;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignUpShowPassword;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSignUpPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSignUpUsername;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox4;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignInHidePassword;
        private Guna.UI.WinForms.GunaTransition SignIn_SignUp_animate;
        private Guna.UI.WinForms.GunaPictureBox btnBackToLogin;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignUpReConfHidePassword;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignUpHidePassword;
        private Guna.UI.WinForms.GunaCirclePictureBox btnSignUpReConfShowPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSignUpReConfPassword;
        private Guna.UI.WinForms.GunaPictureBox btnExitFromApplication;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaTransition SignInTransition;
    }
}
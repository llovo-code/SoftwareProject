using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Powertronic.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            SignInTransition.Show(labelEnterpriceName);
        }

 
        //Animations for panels betwen login and register
        private void linkCreateAcount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn_SignUp_animate.HideSync(Sign_In);
            SignIn_SignUp_animate.Show(Sign_Up);
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            SignIn_SignUp_animate.HideSync(Sign_Up);
            SignIn_SignUp_animate.ShowSync(Sign_In);
        }

        //Exit applications button
        private void btnExitFromApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Sign In show and hide password Buttons
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnSignInHidePassword.Visible = true;
            btnSignInShowPassword.Visible = false;
            txtSignInPassword.isPassword = false;
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {
            btnSignInHidePassword.Visible = false;
            btnSignInShowPassword.Visible = true;

            txtSignInPassword.isPassword = true;
        }

        //SingUp show and hide password buttons 
        private void btnSingUpShowPassword_Click(object sender, EventArgs e)
        {
            btnSignUpHidePassword.Visible = true;
            btnSignUpShowPassword.Visible = false;
        }

        private void btnSignUpHidePassword_Click(object sender, EventArgs e)
        {
            btnSignUpHidePassword.Visible = false;
            btnSignUpShowPassword.Visible = true;
        }

        private void btnSignUpReConfShowPassword_Click(object sender, EventArgs e)
        {
            btnSignUpReConfHidePassword.Visible = true;
            btnSignUpReConfShowPassword.Visible = false;
        }

        private void btnSignUpReConfHidePassword_Click(object sender, EventArgs e)
        {
            btnSignUpReConfHidePassword.Visible = false ;
            btnSignUpReConfShowPassword.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class LoginWindowView : Form
    {
        public LoginWindowView()
        {
            InitializeComponent();
        }

        private LoginWindowModel loginWindowModel = new LoginWindowModel();
        private int loginCounter = 0;

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (loginWindowModel.CheckPassword(tb_Username.Text, tb_Password.Text))
            {
                MessageView messageView = new MessageView("Congratulations, you remembered your login and password. Good job!");
                messageView.ShowDialog();
            }
            else
            {
                if (loginCounter++ > 5)
                {
                    MessageView messageView = new MessageView("Wrong login information. The app is now locked");
                    messageView.ShowDialog();
                    tb_Username.Enabled = false;
                    tb_Password.Enabled = false;
                    btn_login.Enabled = false;
                }
                else
                {
                    MessageView messageView = new MessageView($"Wrong login information. You have {5-loginCounter} tries");
                    messageView.ShowDialog();
                }
            }
        }
    }
}

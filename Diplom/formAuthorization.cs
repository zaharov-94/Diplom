using Diplom.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class formAuthorization : Form
    {
        Context db = new Context();
        string error = "";
        
        public formAuthorization()
        {
            InitializeComponent();
            this.CancelButton = buttonCancel;
            this.AcceptButton = buttonLogin;
        }

        private void fromAuthorization_Load(object sender, EventArgs e)
        {


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            var log = loginTextBox.Text;
            var pass = passwordTextBox.Text;
            var query = from employes in db.employes
                        where employes.login == log
                        select new
                        {
                            login = employes.login,
                            password = employes.password,
                            employeeID = employes.employeeID,
                            userName = employes.firstName
                        };
            if (query.ToList().Count == 0) { error = "Не правильный логин!"; }
            else if (query.ToList().Count == 1)
            {
                if(pass == query.FirstOrDefault(x => x.login == log).password)
                {
                    Settings.userID = query.FirstOrDefault(x => x.login == log).employeeID;
                    Settings.userName = query.FirstOrDefault(x => x.login == log).userName;
                    //error = "Готово!";
                    this.Hide();
                    mainForm mf = new mainForm();
                    mf.ShowDialog();
                }
                else
                {
                    error = "Не правильный пароль!";
                }
            }
            labelError.Text = error;
        }

        private void formAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

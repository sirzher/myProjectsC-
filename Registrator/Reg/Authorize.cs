using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg
{
    public partial class Authorize : Form
    {
      
        public Authorize()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = AccountsList.users.Where(i => i.Login == loginTB.Text && i.Password == passTB.Text).FirstOrDefault();
            if (user != null)
            {
                if (user.Blocked)
                {
                    MessageBox.Show("Данный пользователь заблокирован.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide();
                }              
            }
            else
            {
                Administrator admin = AccountsList.admins.Where(i => i.Login == loginTB.Text && i.Password == passTB.Text).FirstOrDefault();
                if (admin != null)
                {

                }
                else
                {
                    MessageBox.Show("Неверноый логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
                   
                }              
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegForm rf = new RegForm();
            this.Hide();
            rf.Show();
        }
    }
}

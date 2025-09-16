using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class FormCreateUser : Form
    {
        AppDbContext db = new AppDbContext();
        public FormCreateUser()
        {
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserDTO? userDTO = db.User.Where(item => item.Username == "superadmin").FirstOrDefault();
            if(textBoxUsername.Text == null || textBoxPassword.Text == null)
            {
                MessageBox.Show("Username or Password cannot be empty", "no value error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(textBoxOwnerPassword.Text != userDTO!.Password) {

                MessageBox.Show("You cannot create the account without the owner permission");
                return;
            }
            UserDTO user = new UserDTO() {
                
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text,
            
            };
            db.User.Add(user);
            db.SaveChanges();
            MessageBox.Show("User Created!","new user created",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}

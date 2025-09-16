using System.Collections.Generic;

namespace practice
{
    public partial class Form1 : Form
    {
        AppDbContext db = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
            
        {
            List<UserDTO> list = db.User.ToList();
            bool IsAuthenticated  = list.Any(item => item.Username == textBox_Username.Text && item.Password == textBox_Password.Text);
            if(IsAuthenticated == false)
            {
                MessageBox.Show("Incorrect username or password", "verification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
                
            

            
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

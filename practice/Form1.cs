namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(textBox_Username.Text != "admin" || textBox_Password.Text != "admin") {
            
                MessageBox.Show("Incorrect Username or Password", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.ShowDialog();
        }
    }
}

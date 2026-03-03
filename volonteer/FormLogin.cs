using volonteer.Models;

namespace volonteer
{
    public partial class FormLogin : Form
    {
        public User CurrentUser { get; private set; }

        public bool IsGuest { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text) || String.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            using (var db = new VolonteerContext())
            {
                var user = db.Users
                    .Where(w=>w.Login ==  txtLogin.Text && w.Pass ==  txtPassword.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    CurrentUser = user;
                    IsGuest = false;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnGuest_Click(object sender, EventArgs e)
        {
            CurrentUser = null;
            IsGuest = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

using volonteer.Models;

namespace volonteer
{
    public partial class FormEvents : Form
    {
        public User CurrentUser { get; private set; }

        public bool IsGuest { get; private set; }

        public FormEvents(User user, bool guest)
        {
            InitializeComponent();

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullName;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using Services;

namespace GameCard_SE172121
{
    public partial class LoginForm : Form
    {
        //admin@GameCardStore.info @2
        //staff@GameCardStore.info
        //manager@GameCardStore.info
        public LoginForm()
        {
            InitializeComponent();
        }
        private MemberAccountService _accountService = new();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("All fields are required!!!",
                    "Field required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error); 
                return;
            }

            var account = _accountService.CheckLogin(txtUsername.Text);
            if ((account == null) || (txtPassword.Text != account.MemberAccountPassword))
            {
                MessageBox.Show("Wrong account!",
                "", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (account.Role != 2 &&
                account.Role != 3)
            {
                MessageBox.Show("You have no permission to access this function!",
                "", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            GameCardManagementForm gameCardManagementForm = new GameCardManagementForm();
            gameCardManagementForm.account = account;
            gameCardManagementForm.Show();
            this.Hide();
        }
    }
}
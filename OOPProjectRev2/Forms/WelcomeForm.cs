using OOPProjectRev2.Forms;

namespace OOPProjectRev2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            CustomerOrdering newform = new CustomerOrdering();
            newform.Show();
        }

        private void btnAdminPortal_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
        }
    }
}

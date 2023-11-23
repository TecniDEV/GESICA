using TecniDev.Tools.Controllers;
using TecniDev.Tools.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GESICA.UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                TextPassword.Focus();
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                ButtonLogin_Click(sender, null);
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs? e)
        {
            if (LoginController.Login(TextUser.Text, TextPassword.Text))
            {
                SessionHelper.Logged = true;
                SessionHelper.User = TextUser.Text;
                Close();
            } else
            {
                SessionHelper.Logged = false;
                MessageBox.Show("No se encontraron estas credenciales", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextUser.Focus();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}

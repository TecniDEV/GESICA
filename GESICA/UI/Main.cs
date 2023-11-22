using GESICA.UI;
using TecniDev.Tools.Data;

namespace GESICA
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Session.User == null)
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}

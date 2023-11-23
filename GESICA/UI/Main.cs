using GESICA.UI;
using TecniDev.Tools.Helpers;

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
            if (SessionHelper.User == null)
            {
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}

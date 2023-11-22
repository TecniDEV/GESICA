using TecniDev.Tools.Controllers;
using TecniDev.Tools.Data.Models;

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
            LoginController controller = new();
            foreach (var item in controller.GetRoles())
            {
                MessageBox.Show(item.Name);
            }
        }
    }
}

using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renting_Car_Project.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            FontManager.ApplyCustomFont(this.Controls);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

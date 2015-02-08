using System.Windows.Forms;

namespace mvp_template
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void Open()
        {
            Application.Run(this);
        }
    }
}

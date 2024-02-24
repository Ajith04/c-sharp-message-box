using System.Diagnostics.Eventing.Reader;

namespace Sample_Messagebox
{
    public partial class frmmessagebox : Form
    {
        public frmmessagebox()
        {
            InitializeComponent();
        }

        private void frmmessagebox_Load(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            String message = "Are you sure?";
            String title = "Caution";
            MessageBox.Show(message, title);
        }

        private void btnnext2_Click(object sender, EventArgs e)
        {
            String message = "Are you sure?";
            String title = "Caution";
            MessageBoxButtons button = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, button, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if (result == DialogResult.Retry)
            {
                txt1.Text = "Success";
            }
            else
            {
                txt2.Text = "Please";
            }
        }

        private void btnnext3_Click(object sender, EventArgs e)
        {

        }
    }
}

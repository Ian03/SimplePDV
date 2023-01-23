using _0._1.Forms;

namespace _0._1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Length > 0 & textBoxPass.Text.Length > 0) 
            {
                FrmData FormData = new FrmData();
                FormData.Show();
                this.Hide();
            }
            else
            {
                FrmMessagebox messagebox = new FrmMessagebox();
                messagebox.Show("Mensagem de Erro", Color.FromArgb(255, 0, 0), Properties.Resources.Erro, "Favor informar um usuario e senha valido", FrmMessagebox.MessageBoxButon.OK);
            }

        }
    }
}

namespace projet1
{
    public partial class Form1 : Form
    {
        

        Boolean bouton = false;
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (bouton) {
                form2.Show();
                checkBox1.Checked = false;
                bouton = false;
            }
            else
            {
                MessageBox.Show("fini ta séance");
            }
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            bouton = true;
            //soundplayer.Play();
        }
    }
}

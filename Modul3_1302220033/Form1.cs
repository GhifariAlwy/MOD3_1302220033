namespace Modul3_1302220033
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b;
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(label2.Text);
            label2.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(label2.Text);
            label2.Text = Convert.ToString(a + b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + button9.Text;
        }
    }
}

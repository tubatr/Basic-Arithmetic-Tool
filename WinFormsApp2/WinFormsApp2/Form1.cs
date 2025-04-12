namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x + y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x - y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(x * y);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x;
            double y;
            double.TryParse(textBox1.Text, out x);
            double.TryParse(textBox2.Text, out y);
            textBox3.Text = Convert.ToString(x / y);
        }
    }
}

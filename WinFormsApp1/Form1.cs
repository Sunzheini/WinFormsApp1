namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeButtonColor_Click(sender, e);
            label2.Text = "Hello World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeButtonColor_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeButtonColor_Click(sender, e);
            MessageBox.Show($"You typed: {textBox1.Text}");
            textBox1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void changeButtonColor_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Red;
        }
    }
}
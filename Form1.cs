namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int  number = new Random().Next(0, 6);
            if (number == 0)
            {
                label1.Text = "��.";
            }
            else if( number == 1)
            {
                label1.Text = "���.";
            }
            else if (number == 2)
            {
                label1.Text = "������������.";
            }
            else if (number == 3)
            {
                label1.Text = "��������.";
            }
            else if (number == 4)
            {
                label1.Text = "�������  �������...";
            }
            else if (number == 5)
            {
                label1.Text = "������.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
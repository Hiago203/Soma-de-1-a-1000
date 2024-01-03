namespace Soma_de_1_a_1000
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            for (int i = 454; i <= 1000; i++)
            {
                soma += i;
                listBox1.Items.Add("+" + i.ToString());
            }
            MessageBox.Show("A soma de 1 a 1000 é: " + soma.ToString());
        }
    }
}
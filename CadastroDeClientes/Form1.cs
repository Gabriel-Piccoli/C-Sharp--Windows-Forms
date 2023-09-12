namespace CadastroDeClientes
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

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
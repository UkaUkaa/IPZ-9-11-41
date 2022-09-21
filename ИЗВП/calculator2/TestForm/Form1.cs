namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string s_number_one = number1.Text;
            string s_number_two = number2.Text;
            
            int number_one = int.Parse(s_number_one);
            int number_two = int.Parse(s_number_two);

            

            switch (operation.Text){
                case "*":
                    result.Text = (number_one * number_two).ToString(); 
                    break;

                case "+":
                    result.Text = (number_one + number_two).ToString();
                    break;

                case "-":
                    result.Text = (number_one - number_two).ToString();
                    break;

                case "/":
                    result.Text = (number_one / number_two).ToString();
                    break;

                default:
                    result.Text = "ERROR";
                    break;
            }

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
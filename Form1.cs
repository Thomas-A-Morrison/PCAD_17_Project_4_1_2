namespace PCAD_17_Project_4_1_2
{
    public partial class Form1 : Form
    {
        public double a = 0;
        public double b = 0;
        public double x = 0;
        public double y = 0;
        public string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 10 * a + 1;
            label1.Text = a.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a = 10 * a + 2;
            label1.Text = a.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a = 10 * a + 3;
            label1.Text = a.ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            a = 10 * a + 4;
            label1.Text = a.ToString();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            a = 10 * a + 5;
            label1.Text = a.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            a = 10 * a + 6;
            label1.Text = a.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            a = 10 * a + 7;
            label1.Text = a.ToString();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            a = 10 * a + 8;
            label1.Text = a.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            a = 10 * a + 9;
            label1.Text = a.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = 10 * a + 0;
            label1.Text = a.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = 0;
            label1.Text = a.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operation = "Add";
            label1.Text = "";
            x = a;
            a = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operation = "Subtract";
            label1.Text = "";
            x = a;
            a = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operation = "Multiply";
            label1.Text = "";
            x = a;
            a = 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operation = "Divide";
            label1.Text = "";
            x = a;
            a = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var calculator = new Calculator();
            y = a;
            switch (operation) 
            { 
                case "Add":
                    label1.Text = Convert.ToString(calculator.Add(x, y)); 
                    break;
                case "Subtract":
                    label1.Text = Convert.ToString(calculator.Subtract(x, y));
                    break;
                case "Multiply":
                    label1.Text = Convert.ToString(calculator.Multiply(x, y));
                    break;
                case "Divide":
                    label1.Text = Convert.ToString(calculator.Divide(x, y));
                    break;
            }
        }
    }
}

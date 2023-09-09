namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string calcTotal;
        int numberOne;
        int numberTwo;
        string option;
        int result;


        private void button1_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text + button10.Text;
        }



        // calculation
        private void button11_Click(object sender, EventArgs e)
        {
            option = "+";
            numberOne = int.Parse(textBoxTotal.Text);
            textBoxTotal.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            option = "-";
            numberOne = int.Parse(textBoxTotal.Text);
            textBoxTotal.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "*";
            numberOne = int.Parse(textBoxTotal.Text);
            textBoxTotal.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            option = "/";
            numberOne = int.Parse(textBoxTotal.Text);
            textBoxTotal.Clear();
        }


        private void button15_Click(object sender, EventArgs e)
        {
            option = "%";
            numberOne = int.Parse(textBoxTotal.Text);
            textBoxTotal.Clear();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            numberTwo = int.Parse(textBoxTotal.Text);

            if (option.Equals("+"))
                result = numberOne + numberTwo;
            if (option.Equals("-"))
                result = numberOne - numberTwo;
            if (option.Equals("*"))
                result = numberOne * numberTwo;
            if (option.Equals("/"))
                result = numberOne / numberTwo;

            if (option.Equals("%"))
                result = (numberOne / 100) * numberTwo;
            

            textBoxTotal.Text = result + "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxTotal.Clear();

            numberOne = (0);
            numberTwo = (0);
            result = (0);
        }
    }
}
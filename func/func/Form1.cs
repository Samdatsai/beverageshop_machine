namespace func
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
        private void maketea()
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�m���˶i����\r\n";
            textBox1.Text += "3.���˶i�M�l\r\n";
            textBox1.Text += "4.�[�f�c\r\n";
        }
        private void makecoffee(string suger)
        {
            textBox1.Text += "1.����N�}\r\n";
            textBox1.Text += "2.�Ϊm���R�@��\r\n";
            textBox1.Text += "3.�@�ح˶i�M�l\r\n";
            textBox1.Text += "4.�["+suger+"�}�M����\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maketea();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suger = "�L";
                if (radioButton1.Checked == true)
            {
                suger = "3��";
            }
                else if (radioButton2.Checked == true)
            {
                suger = "5��";
            }
                else if(radioButton3.Checked == true)
            {
                suger = "7��";
            }
            else
            {
                suger = "�L";
            }
                makecoffee(suger);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makedumpling();
        }
        private void makedumpling()
        {
            textBox1.Text += "�b�J���[�J���C���ѯ�'�[�Ť����ͩ�'\r\n";
            textBox1.Text += "���R����ӤB+�Q\r\n";
            textBox1.Text += "�ަפ��p��+�Q+��\r\n";
            textBox1.Text += "�׵�V�X'�ѹα쥭'�P��g���]��";
            textBox1.Text += "�N��'�U��l";
        }
    }
}


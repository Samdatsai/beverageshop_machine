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
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.沸水倒進茶葉\r\n";
            textBox1.Text += "3.茶倒進杯子\r\n";
            textBox1.Text += "4.加檸檬\r\n";
        }
        private void makecoffee(string suger)
        {
            textBox1.Text += "1.把水煮開\r\n";
            textBox1.Text += "2.用沸水沖咖啡\r\n";
            textBox1.Text += "3.咖啡倒進杯子\r\n";
            textBox1.Text += "4.加"+suger+"糖和牛奶\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maketea();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string suger = "無";
                if (radioButton1.Checked == true)
            {
                suger = "3分";
            }
                else if (radioButton2.Checked == true)
            {
                suger = "5分";
            }
                else if(radioButton3.Checked == true)
            {
                suger = "7分";
            }
            else
            {
                suger = "無";
            }
                makecoffee(suger);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            makedumpling();
        }
        private void makedumpling()
        {
            textBox1.Text += "在碗中加入高低筋麵粉'加溫水並攪拌'\r\n";
            textBox1.Text += "高麗菜切細丁+鹽\r\n";
            textBox1.Text += "豬肉切小塊+鹽+薑\r\n";
            textBox1.Text += "肉菜混合'麵團桿平'周圍沾水包肉";
            textBox1.Text += "煮水'下餃子";
        }
    }
}


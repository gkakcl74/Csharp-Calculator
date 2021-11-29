using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C샵_마우스계산기_이수형
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool flag_check = false;
        bool clear_flag = false;
        double number_store = 0;
        string operation_store = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if(clear_flag == true)
            {             
                textBox1.Text = "";
                clear_flag = false;               
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clear_flag == true)
            {
                textBox1.Text = "";
                clear_flag = false;
            }
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                textBox1.Text += "0";


        }

        private void button11_Click(object sender, EventArgs e)
        { 
            if (textBox1.Text != "")
                textBox1.Text += "000";
        }

        private void button14_Click(object sender, EventArgs e)
        {// Dot
            if (flag_check == false)
            {
                if(textBox1.Text == "")
                {
                    textBox1.Text = "0"; 
                }
                textBox1.Text += ".";
                flag_check = true;
            }          
        }

        private void button13_Click(object sender, EventArgs e)
        { //Clear
            textBox1.Text = "";
            textBox2.Text = "";
            number_store = 0;
            operation_store = "";
            flag_check = false;
        }

        private void button10_Click(object sender, EventArgs e)
        { //Delete
            if (textBox1.Text != "")
            {
                if (textBox1.Text.Substring(textBox1.TextLength - 1) == ".")
                    flag_check = false;
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.Text == "0" || textBox1.Text == "-")
                    textBox1.Text = "";

            }                           
        }
        public void Operation()
        {
            if (operation_store == "+")
                textBox1.Text = (number_store + double.Parse(textBox1.Text)).ToString();
            else if (operation_store == "-")
                textBox1.Text = (number_store - double.Parse(textBox1.Text)).ToString();
            else if (operation_store == "X")
                textBox1.Text = (number_store * double.Parse(textBox1.Text)).ToString();
            else if (operation_store == "÷")
                textBox1.Text = (number_store / double.Parse(textBox1.Text)).ToString();
            else if (operation_store == "^")
                textBox1.Text = Math.Pow(number_store, double.Parse(textBox1.Text)).ToString();
            else if (operation_store == "%")
                textBox1.Text = (number_store % double.Parse(textBox1.Text)).ToString();
        }
        private void button16_Click(object sender, EventArgs e)
        { //plus botton          
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "+";
            operation_store = "+";
            flag_check = false;
            clear_flag = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "-";
            operation_store = "-";
            flag_check = false;
            clear_flag = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "X";
            operation_store = "X";
            flag_check = false;
            clear_flag = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "÷";
            operation_store = "÷";
            flag_check = false;
            clear_flag = true;
        }

        private void button19_Click(object sender, EventArgs e)
        { //　＝　
            Operation();
            number_store = 0;
            operation_store = "";
            flag_check = false;
            clear_flag = true;
            textBox2.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        { //   1/x
            if (textBox1.Text != "")
            {
                textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
                textBox2.Text = "";
            }                         
        }

        private void button22_Click(object sender, EventArgs e)
        {// 제곱
            if (textBox1.Text != "")
            { 
                // double.Parse(textBox1.Text) * double.Parse(textBox1.Text); 
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
                textBox2.Text = "";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        { // +/- 부호변환
            if (textBox1.Text != "")
            {
                /*textBox1.Text = (-double.Parse(textBox1.Text)).ToString();*/ // -1 *
                if (double.Parse(textBox1.Text) > 0)
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
                else if(double.Parse(textBox1.Text) < 0)
                {
                    textBox1.Text = textBox1.Text.Substring(1, textBox1.TextLength - 1);
                }
            }
        }
        public double Factorial(double n)
        {
            if (n == 1)
                return 1;
            else
                return Factorial(n - 1) * n; 
        }
        private void button25_Click(object sender, EventArgs e)
        {
            // n!
            if (textBox1.Text != "")
            {
                textBox2.Text = textBox1.Text + "!";
                textBox1.Text = Factorial(double.Parse(textBox1.Text)).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        { //x^3
            if (textBox1.Text != "")
            {
                textBox2.Text = "x^" + textBox1.Text;
                textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 3).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        { // sin
            if (textBox1.Text != "")
            {
                textBox2.Text = "Sin(" + textBox1.Text + ")";
                textBox1.Text = Math.Sin(double.Parse(textBox1.Text)*Math.PI/180).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true; 
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = "Cos(" + textBox1.Text + ")";
                textBox1.Text = Math.Cos(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox2.Text = "Tan(" + textBox1.Text + ")";
                textBox1.Text = Math.Tan(double.Parse(textBox1.Text) * Math.PI / 180).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        { //x^y
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "^";
            operation_store = "^";
            flag_check = false;
            clear_flag = true;
        }

        private void button33_Click(object sender, EventArgs e)
        {  //10 ^ x
            if (textBox1.Text != "")
            {
                textBox2.Text = "10^" + textBox1.Text;
                textBox1.Text = Math.Pow(10, double.Parse(textBox1.Text)).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        { //  | x |
            if (textBox1.Text != "")
            {
                //textBox1.Text = Math.Abs(double.Parse(textBox1.Text)).ToString();
                if (textBox1.Text.Substring(0, 1) == "-") // math.abs 쓰지 않는 코드
                {                                         // if(double.parse(textBox.Text) < 0)를 써도 된다. 오히려 더 가독성이 좋다.                                                      
                    textBox1.Text = (-double.Parse(textBox1.Text)).ToString();
                }
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;
                textBox2.Text = "";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {  // MOD
            if (textBox1.Text == "")
                return;
            if (operation_store != "")
                Operation();
            number_store = double.Parse(textBox1.Text);
            textBox2.Text = textBox1.Text + "%";
            operation_store = "%";
            flag_check = false;
            clear_flag = true;
        }

        private void button34_Click(object sender, EventArgs e)
        { // √
            if (textBox1.Text != "")
            {
                textBox2.Text = "√(" + textBox1.Text + ")";
                textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;             
            }
        }

        private void button28_Click(object sender, EventArgs e)
        { //  1/|x|
            if (textBox1.Text != "")
            {
                textBox2.Text = "1/" + "|" + textBox1.Text + "|";
                textBox1.Text = (1 / Math.Abs(double.Parse(textBox1.Text))).ToString();
                number_store = 0;
                operation_store = "";
                flag_check = false;
                clear_flag = true;  
            }
        }

        private void button30_Click(object sender, EventArgs e)
        { //  pi
            textBox1.Text = Math.PI.ToString();
            //number_store = 0;
            //operation_store = "";
            //flag_check = false;
            //clear_flag = true;
        }

        private Form4 directions_for_use;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { //계산기사용법
            directions_for_use = new Form4();
            directions_for_use.Owner = this;
            directions_for_use.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 353;
            textBox1.Width = 317;
            textBox2.Width = 317;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
        }

        private void 일반계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            this.Text = "일반 계산기";
            this.Width = 353;
            textBox1.Width = 317;
            textBox2.Width = 317;
            일반계산기ToolStripMenuItem.Checked = true;
            공학계산기ToolStripMenuItem.Checked = false;
            label1.Text = "By LEE SUE HYUNG Dept Software Engineering of Seoil University";
        }

        private void 공학계산기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "공학 계산기";
            groupBox1.Show();
            this.Width = 520;
            textBox1.Width = 485;
            textBox2.Width = 485;
            일반계산기ToolStripMenuItem.Checked = false;
            공학계산기ToolStripMenuItem.Checked = true;
            label1.Text = "This calculator is maded By LEE SUE HYUNG Dept Software Engineering of Seoil University ";
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private Form2 developer_intro;
        private void 개발자소개ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            developer_intro = new Form2();
            developer_intro.Owner = this;
            developer_intro.Show();
            this.Hide();
        }

        private Form3 to_professor;
        private void 교수님에게하고픈말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            to_professor = new Form3();
            to_professor.Owner = this;
            to_professor.Show();
            this.Hide();
        }

        private void 개발환경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("운영체제: Windows 11 prerelease . 210917-1503" 
                + "\r\n" + "개발도구: Microsoft Visual Studio Community 2019," + "\r\n" +
                "\t한글 워드 프로세서", "   개발환경   ");
        }

        private void 버전정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("마우스로 동작하는 계산기 1.0", "Ver 1.0");
        }
    }
}

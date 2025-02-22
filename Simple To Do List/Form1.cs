using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_To_Do_List
{
    public partial class Form1 : Form
    {
        bool tsk1 = false;
        bool tsk2 = false;
        bool tsk3 = false;
        bool tsk4 = false;
        bool tsk5 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textNewTask.Text))
            {
                MessageBox.Show("Silakan Masukkan Tugas Baru.");
                return;
            }

            if (textBox1.Text == "")
            {
                panel1.Visible = true;
                textBox1.Text = textNewTask.Text;
                
            }
            else if (textBox2.Text == "")
            {
                panel2.Visible = true;
                textBox2.Text = textNewTask.Text;
                
            }
            else if (textBox3.Text == "")
            {
                panel3.Visible = true;
                textBox3.Text = textNewTask.Text;
                
            }
            else if (textBox4.Text == "")
            {
                panel4.Visible = true;
                textBox4.Text = textNewTask.Text;
                
            }
            else if (textBox5.Text == "")
            {
                panel5.Visible = true;
                textBox5.Text = textNewTask.Text;
                
            }
            else if (tsk1 == true)
            {
                panel1.Visible = true;
                textBox2.Text = textNewTask.Text;
            }
            else if (tsk2 == true)
            {
                panel2.Visible = true;
                textBox2.Text = textNewTask.Text;
            }
            else if (tsk3 == true)
            {
                panel3.Visible = true;
                textBox3.Text = textNewTask.Text;
            }
            else if (tsk4 == true)
            {
                panel4.Visible = true;
                textBox4.Text = textNewTask.Text;
            }
            else if (tsk5 == true)
            {
                panel5.Visible = true;
                textBox5.Text = textNewTask.Text;
            }
            else
            {
                MessageBox.Show("Semua slot tugas penuh. Silakan selesaikan tugas terlebih dahulu sebelum menambahkan yang baru.");
            }

            textNewTask.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void ShiftTasksUp()
        {
            textBox1.Text = textBox2.Text;
            textBox2.Text = textBox3.Text;
            textBox3.Text = textBox4.Text;
            textBox4.Text = textBox5.Text;
            textBox5.Text = "";

            panel1.Visible = !string.IsNullOrWhiteSpace(textBox1.Text);
            panel2.Visible = !string.IsNullOrWhiteSpace(textBox2.Text);
            panel3.Visible = !string.IsNullOrWhiteSpace(textBox3.Text);
            panel4.Visible = !string.IsNullOrWhiteSpace(textBox4.Text);
            panel5.Visible = !string.IsNullOrWhiteSpace(textBox5.Text);

            tsk1 = !string.IsNullOrWhiteSpace(textBox1.Text);
            tsk2 = !string.IsNullOrWhiteSpace(textBox2.Text);
            tsk3 = !string.IsNullOrWhiteSpace(textBox3.Text);
            tsk4 = !string.IsNullOrWhiteSpace(textBox4.Text);
            tsk5 = !string.IsNullOrWhiteSpace(textBox5.Text);
        }

        private void delete1_Click(object sender, EventArgs e)
        {
            tsk1 = false;
            ShiftTasksUp();
        }

        private void delete2_Click(object sender, EventArgs e)
        {
            tsk2 = false;
            ShiftTasksUp();
        }

        private void delete3_Click(object sender, EventArgs e)
        {
            tsk3 = false;
            ShiftTasksUp();
        }

        private void delete4_Click(object sender, EventArgs e)
        {
            tsk4 = false;
            ShiftTasksUp();
        }

        private void delete5_Click(object sender, EventArgs e)
        {
            tsk5 = false;
            ShiftTasksUp();
        }

        private void done1_Click(object sender, EventArgs e)
        {
            if (textBox1.Font.Strikeout)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Strikeout);
            }
        }

        private void done2_Click(object sender, EventArgs e)
        {
            if (textBox2.Font.Strikeout)
            {
                textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
            }
            else
            {
                textBox2.Font = new Font(textBox2.Font, FontStyle.Strikeout);
            }
        }

        private void done3_Click(object sender, EventArgs e)
        {
            if (textBox3.Font.Strikeout)
            {
                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
            }
            else
            {
                textBox3.Font = new Font(textBox3.Font, FontStyle.Strikeout);
            }
        }

        private void done4_Click(object sender, EventArgs e)
        {
            if (textBox4.Font.Strikeout)
            {
                textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
            }
            else
            {
                textBox4.Font = new Font(textBox4.Font, FontStyle.Strikeout);
            }
        }

        private void done5_Click(object sender, EventArgs e)
        {
            if (textBox5.Font.Strikeout)
            {
                textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
            }
            else
            {
                textBox5.Font = new Font(textBox5.Font, FontStyle.Strikeout);
            }
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            ok1.Visible = true;
            textBox1.ReadOnly = false;
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            ok2.Visible = true;
            textBox2.ReadOnly = false;
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            ok3.Visible = true;
            textBox3.ReadOnly = false;
        }

        private void edit4_Click(object sender, EventArgs e)
        {
            ok4.Visible = true;
            textBox4.ReadOnly = false;
        }

        private void edit5_Click(object sender, EventArgs e)
        {
            ok5.Visible = true;
            textBox5.ReadOnly = false;
        }

        private void ok1_Click(object sender, EventArgs e)
        {
            ok1.Visible = false;
            textBox1.ReadOnly = true;
        }

        private void ok2_Click(object sender, EventArgs e)
        {
            ok2.Visible = false;
            textBox2.ReadOnly = true;
        }

        private void ok3_Click(object sender, EventArgs e)
        {
            ok3.Visible = false;
            textBox3.ReadOnly = true;
        }

        private void ok4_Click(object sender, EventArgs e)
        {
            ok4.Visible = false;
            textBox4.ReadOnly = true;
        }

        private void ok5_Click(object sender, EventArgs e)
        {
            ok5.Visible = false;
            textBox5.ReadOnly = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace блокнот
{
    public partial class Form1 : Form
    {
        Random rnd;
        char[] spec_char = new char[] {'%', '*', '#', '$', '^', '&' };
        Dictionary<string, double> metrica;

        public Form1()
        {
            InitializeComponent();
            rnd =  new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 10000);
            metrica.Add("mile", 160093);


        }

        private void insertDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void insertTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("notepad.rtf");
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.LoadFile("notepad1.rtf");
            }
            catch
            {
                MessageBox.Show("Error loading");
            }

        }

        private void BtnCreatePsw_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return;
            string password = "";
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int n = rnd.Next(0, checkedListBox1.CheckedItems.Count);
                string s = checkedListBox1.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Digits":
                        password += rnd.Next(10).ToString();
                        break;
                    case "Uppercase letters":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Lower case":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_char[rnd.Next(spec_char.Length)];
                        break;
                }
                textBox1.Text = password;
                Clipboard.SetText(password); //копирует в бувер обмена 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.SetItemChecked(1, true);

        }

        private void btConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (n*m1/m2).ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string s = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = s;
        }

        private void cbMetric_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbMetric.Text)
            {
                case "Длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 10000);
                    metrica.Add("mile", 160093);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("miile");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("miile");
                    cbFrom.Text = "mm";
                    cbTo.Text = "mm";
                    break;
                case ("Вес"):
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");
                 
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;

                default:
                    break;
            }
        }
    }
}

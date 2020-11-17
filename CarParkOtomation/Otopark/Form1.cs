using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
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

        private void btnProgramcikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAracgiris_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ARAÇ GİRİŞ =  Ad-Soyad: " + textBox1.Text + "-" + textBox2.Text +" | "+" Telefon No: " +maskedTextBox1.Text);
            listBox1.Items.Add("ARAÇ BİLGİLERİ =  Araç Model: "+comboBox1.Text+" | "+" Araç Plaka: "+textBox3.Text);
            listBox1.Items.Add("PARK YERİ= " + comboBox2.Text);
            

            if (comboBox2.Text == "A1")
            {

                button1.Enabled = true;
                button1.BackColor = Color.Red;
                label8.Text = textBox1.Text +" "+ textBox2.Text;
                label10.Text = maskedTextBox1.Text;
                label9.Text = textBox3.Text;
            }
            if (comboBox2.Text == "A2")
            {

                button2.Enabled = true;
                button2.BackColor = Color.Red;
                label13.Text = textBox1.Text + " " + textBox2.Text;
                label11.Text = maskedTextBox1.Text;
                label12.Text = textBox3.Text;
            }
            if (comboBox2.Text == "A3")
            {

                button3.Enabled = true;
                button3.BackColor = Color.Red;
                label16.Text = textBox1.Text + " " + textBox2.Text;
                label14.Text = maskedTextBox1.Text;
                label15.Text = textBox3.Text;
            }
            if (comboBox2.Text == "A4")
            {

                button4.Enabled = true;
                button4.BackColor = Color.Red;
                label19.Text = textBox1.Text + " " + textBox2.Text;
                label17.Text = maskedTextBox1.Text;
                label18.Text = textBox3.Text;
            }
            if (comboBox2.Text == "A5")
            {

                button5.Enabled = true;
                button5.BackColor = Color.Red;
                label22.Text = textBox1.Text + " " + textBox2.Text;
                label20.Text = maskedTextBox1.Text;
                label21.Text = textBox3.Text;
            }
            if (comboBox2.Text == "B1")
            {

                button6.Enabled = true;
                button6.BackColor = Color.Red;
                lblB1.Text = textBox1.Text + " " + textBox2.Text;
                lblB1a.Text = maskedTextBox1.Text;
                lblB1b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "B2")
            {

                button7.Enabled = true;
                button7.BackColor = Color.Red;
                lblB2.Text = textBox1.Text + " " + textBox2.Text;
                lblB2a.Text = maskedTextBox1.Text;
                lblB2b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "B3")
            {

                button8.Enabled = true;
                button1.BackColor = Color.Red;
                lblB3.Text = textBox1.Text + " " + textBox2.Text;
                lblB3a.Text = maskedTextBox1.Text;
                lblB3b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "B4")
            {

                button9.Enabled = true;
                button9.BackColor = Color.Red;
                lblB4.Text = textBox1.Text + " " + textBox2.Text;
                lblB4a.Text = maskedTextBox1.Text;
                lblB4b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "B5")
            {

                button10.Enabled = true;
                button10.BackColor = Color.Red;
                lblB5.Text = textBox1.Text + " " + textBox2.Text;
                lblB5a.Text = maskedTextBox1.Text;
                lblB5b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "C1")
            {

                button11.Enabled = true;
                button11.BackColor = Color.Red;
                lblC1.Text = textBox1.Text + " " + textBox2.Text;
                lblC1a.Text = maskedTextBox1.Text;
                lblC1b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "C2")
            {

                button12.Enabled = true;
                button12.BackColor = Color.Red;
                lblC2.Text = textBox1.Text + " " + textBox2.Text;
                lblC2a.Text = maskedTextBox1.Text;
                lblC2b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "C3")
            {

                button13.Enabled = true;
                button13.BackColor = Color.Red;
                lblC3.Text = textBox1.Text + " " + textBox2.Text;
                lblC3a.Text = maskedTextBox1.Text;
                lblC3b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "C4")
            {

                button14.Enabled = true;
                button14.BackColor = Color.Red;
                lblC4.Text = textBox1.Text + " " + textBox2.Text;
                lblC4a.Text = maskedTextBox1.Text;
                lblC4b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "C5")
            {

                button15.Enabled = true;
                button15.BackColor = Color.Red;
                lblC5.Text = textBox1.Text + " " + textBox2.Text;
                lblC5a.Text = maskedTextBox1.Text;
                lblC5b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "D1")
            {

                button16.Enabled = true;
                button16.BackColor = Color.Red;
                lblD1.Text = textBox1.Text + " " + textBox2.Text;
                lblD1a.Text = maskedTextBox1.Text;
                lblD1b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "D2")
            {

                button17.Enabled = true;
                button17.BackColor = Color.Red;
                lblD2.Text = textBox1.Text + " " + textBox2.Text;
                lblD2a.Text = maskedTextBox1.Text;
                lblD2b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "D3")
            {

                button18.Enabled = true;
                button18.BackColor = Color.Red;
                lblD3.Text = textBox1.Text + " " + textBox2.Text;
                lblD3a.Text = maskedTextBox1.Text;
                lblD3b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "D4")
            {

                button19.Enabled = true;
                button19.BackColor = Color.Red;
                lblD4.Text = textBox1.Text + " " + textBox2.Text;
                lblD4a.Text = maskedTextBox1.Text;
                lblD4b.Text = textBox3.Text;
            }
            if (comboBox2.Text == "D5")
            {

                button20.Enabled = true;
                button20.BackColor = Color.Red;
                lblD5.Text = textBox1.Text + " " + textBox2.Text;
                lblD5a.Text = maskedTextBox1.Text;
                lblD5b.Text = textBox3.Text;
            }
        }

        private void btnAraccikis_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "A1")
            {

                button1.Enabled = false;
                button1.BackColor = Color.Green;
                label8.Text ="";
                label10.Text ="";
                label9.Text = "";
            }
            if (comboBox2.Text == "A2")
            {

                button2.Enabled = false;
                button2.BackColor = Color.Green;
                label13.Text = "";
                label11.Text ="";
                label12.Text = "";
            }
            if (comboBox2.Text == "A3")
            {

                button3.Enabled = false;
                button3.BackColor = Color.Green;
                label16.Text = "";
                label14.Text ="";
                label15.Text = "";
            }
            if (comboBox2.Text == "A4")
            {

                button4.Enabled = false;
                button4.BackColor = Color.Green;
                label19.Text = "";
                label17.Text = "";
                label18.Text = "";
            }
            if (comboBox2.Text == "A5")
            {

                button5.Enabled = false;
                button5.BackColor = Color.Green;
                label22.Text = "";
                label20.Text = "";
                label21.Text = "";
            }
            if (comboBox2.Text == "B1")
            {

                button6.Enabled = false;
                button6.BackColor = Color.Green;
                lblB1.Text = "";
                lblB1a.Text = "";
                lblB1b.Text ="";
            }
            if (comboBox2.Text == "B2")
            {

                button7.Enabled = false;
                button7.BackColor = Color.Green;
                lblB2.Text = "";
                lblB2a.Text ="";
                lblB2b.Text = "";
            }
            if (comboBox2.Text == "B3")
            {

                button8.Enabled = false;
                button8.BackColor = Color.Green;
                lblB3.Text = "";
                lblB3a.Text = "";
                lblB3b.Text = "";
            }
            if (comboBox2.Text == "B4")
            {

                button9.Enabled = false;
                button9.BackColor = Color.Green;
                lblB4.Text = "";
                lblB4a.Text ="";
                lblB4b.Text = "";
            }
            if (comboBox2.Text == "B5")
            {

                button10.Enabled = false;
                button10.BackColor = Color.Green;
                lblB5.Text = "";
                lblB5a.Text = "";
                lblB5b.Text = "";
            }
            if (comboBox2.Text == "C1")
            {

                button11.Enabled = false;
                button11.BackColor = Color.Green;
                lblC1.Text = "";
                lblC1a.Text = "";
                lblC1b.Text ="";
            }
            if (comboBox2.Text == "C2")
            {

                button12.Enabled = false;
                button12.BackColor = Color.Green;
                lblC2.Text = "";
                lblC2a.Text ="";
                lblC2b.Text = "";
            }
            if (comboBox2.Text == "C3")
            {

                button13.Enabled = false;
                button13.BackColor = Color.Green;
                lblC3.Text = "";
                lblC3a.Text = "";
                lblC3b.Text = "";
            }
            if (comboBox2.Text == "C4")
            {

                button14.Enabled = false;
                button14.BackColor = Color.Green;
                lblC4.Text ="";
                lblC4a.Text = "";
                lblC4b.Text ="";
            }
            if (comboBox2.Text == "C5")
            {

                button15.Enabled = false;
                button15.BackColor = Color.Green;
                lblC5.Text = "";
                lblC5a.Text = "";
                lblC5b.Text = "";
            }
            if (comboBox2.Text == "D1")
            {

                button16.Enabled = false;
                button16.BackColor = Color.Green;
                lblD1.Text = "";
                lblD1a.Text = "";
                lblD1b.Text = "";
            }
            if (comboBox2.Text == "D2")
            {

                button17.Enabled = false;
                button17.BackColor = Color.Green;
                lblD2.Text = "";
                lblD2a.Text = "";
                lblD2b.Text = "";
            }
            if (comboBox2.Text == "D3")
            {

                button18.Enabled = false;
                button18.BackColor = Color.Green;
                lblD3.Text ="";
                lblD3a.Text = "";
                lblD3b.Text = "";
            }
            if (comboBox2.Text == "D4")
            {

                button19.Enabled = false;
                button19.BackColor = Color.Green;
                lblD4.Text = "";
                lblD4a.Text ="";
                lblD4b.Text ="";
            }
            if (comboBox2.Text == "D5")
            {

                button20.Enabled = false;
                button20.BackColor = Color.Green;
                lblD5.Text = "";
                lblD5a.Text = "";
                lblD5b.Text = "";
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
    
}

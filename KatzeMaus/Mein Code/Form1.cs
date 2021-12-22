using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatzeMaus1
{
    public partial class Form1 : Form 
    {
        bool spielerEinsIstKatze = true;
        int groesse = 0;
        int zeit = 1;
        public Form1()
        {
           

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.Lime)
                button1.BackColor = Color.Lime;
            button2.BackColor = Color.Gray;
            spielerEinsIstKatze = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button1.BackColor == Color.Lime)
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Lime;
            spielerEinsIstKatze = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.Lime || button5.BackColor == Color.Lime)
                button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button3.BackColor = Color.Lime;
            groesse = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Lime || button5.BackColor == Color.Lime)
                button4.BackColor = Color.Lime;
            button5.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            groesse = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.Lime || button4.BackColor == Color.Lime)
                button4.BackColor = Color.Gray;
            button5.BackColor = Color.Lime;
            button3.BackColor = Color.Gray;
            groesse = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Lime || button9.BackColor == Color.Lime)
                button7.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button6.BackColor = Color.Lime;
            zeit = 0;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.Lime || button9.BackColor == Color.Lime)
                button6.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button7.BackColor = Color.Lime;
            zeit = 1;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.Lime || button7.BackColor == Color.Lime)
                button7.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button9.BackColor = Color.Lime;
            zeit = 2;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2(groesse,zeit,spielerEinsIstKatze);
            f2.ShowDialog();           
            this.Close();
        }
    }
}

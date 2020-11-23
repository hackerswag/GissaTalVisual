using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GissaTalVisual
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        
        Random slumpTal3 = new Random();

        int slumpTal = 0;
        int rakna = 0;


        private void button2_Click(object sender, EventArgs e)
        {
            slumpTal = slumpTal3.Next(1, 100);
            rakna = 0;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > slumpTal)
            {
                label1.Text = "För stort! Prova igen";
                rakna += 1;
            }
            if (int.Parse(textBox1.Text) < slumpTal)
            {
                label1.Text = "För litet! Prova igen";
                rakna += 1;
            }
            if (int.Parse(textBox1.Text) == slumpTal)
            {
                rakna += 1;
                label1.Text = ("Rätt! Antal gissningar: " + rakna);
            }
            

        }

        
    }
}

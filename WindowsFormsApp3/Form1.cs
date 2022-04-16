using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int i = int.Parse(textBox1.Text) - 1;
           int j = int.Parse(textBox2.Text) - 1;
           string[] stroka = listBox1.Text.Split(' ');
           foreach (string t in stroka)
           {         
                label3.Text += zamena(t, i, j);
           }
        }
           static string zamena(string text, int pos1, int pos2)
           {
               char[] swap = text.ToCharArray();
               char temp = swap[pos1];
               swap[pos1] = swap[pos2];
               swap[pos2] = temp;
               return new string(swap);
           }  
    }  
}
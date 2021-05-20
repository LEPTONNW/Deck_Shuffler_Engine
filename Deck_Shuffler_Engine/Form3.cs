using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deck_Shuffler_Engine
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static string Passvalue { get; set; }
        private void Input_Click(object sender, EventArgs e)
        {
            Passvalue = textBox1.Text;
            textBox1.Text = "";
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Input.FlatAppearance.BorderColor = Color.Black;
        }
    }
}

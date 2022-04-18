using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_first_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Exiting Program";
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblcard.Text = "Seven of Diamonds";
        }

        private void picClubs_Click(object sender, EventArgs e)
        {
            lblcard.Text = "Two of Clubs";
        }

        private void picHearts_Click(object sender, EventArgs e)
        {
            lblcard.Text = "Ace of Hearts";
        }

        private void picJoker_Click(object sender, EventArgs e)
        {
            lblcard.Text = "Black Joker";
        }

        private void picSpades_Click(object sender, EventArgs e)
        {
            lblcard.Text = "King of Spades";
        }
    }
}

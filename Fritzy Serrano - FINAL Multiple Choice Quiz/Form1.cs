using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fritzy_Serrano___FINAL_Multiple_Choice_Quiz
{
    public partial class openingScreen : Form
    {
        public openingScreen()
        {
            InitializeComponent();
        }
        
        private void startButton1_Click_1(object sender, EventArgs e)
        {
            //when the 'Intructions' button is clicked, openingScreen will go invisible and move to Instructions
            this.Visible = false; //note that the 'Visible' property is a boolean
            Instructions form2 = new Instructions();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sentence_Builder
{
    public partial class Form1 : Form
    {
        private string output = "";
        

                       
            
        public Form1()
        {
            InitializeComponent();
        }

        private void sentenceOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void theButton_Click(object sender, EventArgs e)
        {
            output += "The";

            sentenceOutput.Text = output;
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            output += "All";
            sentenceOutput.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            output = "";
            sentenceOutput.Text = output;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myButton_Click(object sender, EventArgs e)
        {
            output += "My";
            sentenceOutput.Text = output;
        }

        private void iButton_Click(object sender, EventArgs e)
        {
            output += "I";
            sentenceOutput.Text = output;
        }

        private void weButton_Click(object sender, EventArgs e)
        {
            output += "We";
            sentenceOutput.Text = output;
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            output += "This";
            sentenceOutput.Text = output;
        }

        private void yourButton_Click(object sender, EventArgs e)
        {
            output += "your";
            sentenceOutput.Text = output;
        }

        private void walkedButton_Click(object sender, EventArgs e)
        {
            output += "walked";
            sentenceOutput.Text = output;
        }

        private void ateButton_Click(object sender, EventArgs e)
        {
            output += "ate";
            sentenceOutput.Text = output;
        }

        private void rainButton_Click(object sender, EventArgs e)
        {
            output += "rain";
            sentenceOutput.Text = output;
        }

        private void inButton_Click(object sender, EventArgs e)
        {
            output += "in";
            sentenceOutput.Text = output;
        }

        private void sidewalkButton_Click(object sender, EventArgs e)
        {
            output += "sidewalk";
            sentenceOutput.Text = output;
        }

        private void ballButton_Click(object sender, EventArgs e)
        {
            output += "ball";
            sentenceOutput.Text = output;
        }

        private void isButton_Click(object sender, EventArgs e)
        {
            output += "is";
            sentenceOutput.Text = output;
        }

        private void areButton_Click(object sender, EventArgs e)
        {
            output += "are";
            sentenceOutput.Text = output;
        }

        private void dogButton_Click(object sender, EventArgs e)
        {
            output += "dog";
            sentenceOutput.Text = output;
        }

        private void baseButton_Click(object sender, EventArgs e)
        {
            output += "base";
            sentenceOutput.Text = output;
        }

        private void usButton_Click(object sender, EventArgs e)
        {
            output += "us";
            sentenceOutput.Text = output;
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            output += "down";
            sentenceOutput.Text = output;
        }

        private void ranButton_Click(object sender, EventArgs e)
        {
            output += "ran";
            sentenceOutput.Text = output;
        }

        private void belongButton_Click(object sender, EventArgs e)
        {
            output += "belong";
            sentenceOutput.Text = output;
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            output += "like";
            sentenceOutput.Text = output;
        }

        private void toButton_Click(object sender, EventArgs e)
        {
            output += "to";
            sentenceOutput.Text = output;
        }

        private void yardButton_Click(object sender, EventArgs e)
        {
            output += "yard";
            sentenceOutput.Text = output;
        }

        private void cheeseButton_Click(object sender, EventArgs e)
        {
            output += "cheese";
            sentenceOutput.Text = output;
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            output += "on";
            sentenceOutput.Text = output;
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            output += "a";
            sentenceOutput.Text = output;
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            output += "car";
            sentenceOutput.Text = output;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {
            output += ".";
            sentenceOutput.Text = output;
        }

        private void exclamationButton_Click(object sender, EventArgs e)
        {
            output += "!";
            sentenceOutput.Text = output;
        }

        private void spaceButton_Click(object sender, EventArgs e)
        {
            output += " ";
            sentenceOutput.Text = output;
        }

        private void _theButton_Click(object sender, EventArgs e)
        {
            output += "the";
            sentenceOutput.Text = output;
        }

        private void _allButton_Click(object sender, EventArgs e)
        {
            output += "all";
            sentenceOutput.Text = output;
        }

        private void _myButton_Click(object sender, EventArgs e)
        {
            output += "my";
            sentenceOutput.Text = output;
        }

        private void _yourButton_Click(object sender, EventArgs e)
        {
            output += "Your";
            sentenceOutput.Text = output;
        }

        private void _weButton_Click(object sender, EventArgs e)
        {
            output += "we";
            sentenceOutput.Text = output;
        }

        private void _thisButton_Click(object sender, EventArgs e)
        {
            output += "this";
            sentenceOutput.Text = output;
        }
    }
}

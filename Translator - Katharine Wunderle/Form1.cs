using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 02/08/2021
    //Goal: To translate three japanese words into english words
    public partial class japaneseTranslator : Form
    {
        public japaneseTranslator()
        {
            InitializeComponent();
        }

        private void ichiButton_Click(object sender, EventArgs e)
        {
            // Show the translation of ichi as one in translation label
            translationLabel.Text = "one";
        }

        private void niButton_Click(object sender, EventArgs e)
        {
            // Show the translation of ni as two in translation label
            translationLabel.Text = "two";
        }

        private void sanButton_Click(object sender, EventArgs e)
        {
            // Show the translation of san as three in translation label
            translationLabel.Text = "three";
        }
    }
}

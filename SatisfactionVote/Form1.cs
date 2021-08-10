using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatisfactionVote
{
    public partial class Form1 : Form
    {

        public int counterSim = 0;
        public int counterNao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnsim_Click(object sender, EventArgs e)
        {
            counterSim += 1;
            counterSimlbl.Text = counterSim.ToString();
        }

        private void btnnao_Click(object sender, EventArgs e)
        {
            counterNao += 1;
            counterNaolbl.Text = counterNao.ToString();
        }
        private void updateCountersLabels()
        {
            counterSimlbl.Text = counterSim.ToString();
            counterNaolbl.Text = counterNao.ToString();
        }
    }
}

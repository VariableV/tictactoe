/*
 * Author: VariableV
 * Date: 06/11/2017
 */

using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private GameLogic gL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gL = new GameLogic(this);
        }

        private void pos00_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos00.Name);
        }

        private void pos01_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos01.Name);
        }

        private void pos02_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos02.Name);
        }

        private void pos10_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos10.Name);
        }

        private void pos11_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos11.Name);
        }

        private void pos12_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos12.Name);
        }

        private void pos20_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos20.Name);
        }

        private void pos21_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos21.Name);
        }

        private void pos22_Click(object sender, EventArgs e)
        {
            gL.PlayerInput(pos22.Name);
        }
        
        public void UpdateButton(String name, String piece)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name.Equals(name))
                {
                    ctrl.Enabled = false;
                    ctrl.Text = piece;
                }
            }
        }

        public void ColorWinner(String name)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl.Name.Equals(name))
                {
                    ctrl.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        public void ClearBoard()
        {
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Enabled = true;
                ctrl.Text = "";
                ctrl.BackColor = Control.DefaultBackColor;
            }
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gL.SetCpuMode(0);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gL.SetPiece('X');
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gL.SetPiece('O');
        }
        
        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gL.SetCpuMode(1);
        }
    }
}

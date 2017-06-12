/*
 * Author: VariableV
 * Date: 06/11/2017
 */

namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pos00 = new System.Windows.Forms.Button();
            this.pos01 = new System.Windows.Forms.Button();
            this.pos02 = new System.Windows.Forms.Button();
            this.pos12 = new System.Windows.Forms.Button();
            this.pos11 = new System.Windows.Forms.Button();
            this.pos10 = new System.Windows.Forms.Button();
            this.pos22 = new System.Windows.Forms.Button();
            this.pos21 = new System.Windows.Forms.Button();
            this.pos20 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pieceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pos00
            // 
            this.pos00.BackColor = System.Drawing.SystemColors.Control;
            this.pos00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos00.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos00.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pos00.Location = new System.Drawing.Point(3, 36);
            this.pos00.Name = "pos00";
            this.pos00.Size = new System.Drawing.Size(115, 91);
            this.pos00.TabIndex = 0;
            this.pos00.UseVisualStyleBackColor = false;
            this.pos00.Click += new System.EventHandler(this.pos00_Click);
            // 
            // pos01
            // 
            this.pos01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos01.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos01.Location = new System.Drawing.Point(124, 36);
            this.pos01.Name = "pos01";
            this.pos01.Size = new System.Drawing.Size(115, 91);
            this.pos01.TabIndex = 1;
            this.pos01.UseVisualStyleBackColor = true;
            this.pos01.Click += new System.EventHandler(this.pos01_Click);
            // 
            // pos02
            // 
            this.pos02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos02.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos02.Location = new System.Drawing.Point(243, 36);
            this.pos02.Name = "pos02";
            this.pos02.Size = new System.Drawing.Size(115, 91);
            this.pos02.TabIndex = 2;
            this.pos02.UseVisualStyleBackColor = true;
            this.pos02.Click += new System.EventHandler(this.pos02_Click);
            // 
            // pos12
            // 
            this.pos12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos12.Location = new System.Drawing.Point(243, 133);
            this.pos12.Name = "pos12";
            this.pos12.Size = new System.Drawing.Size(115, 91);
            this.pos12.TabIndex = 5;
            this.pos12.UseVisualStyleBackColor = true;
            this.pos12.Click += new System.EventHandler(this.pos12_Click);
            // 
            // pos11
            // 
            this.pos11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos11.Location = new System.Drawing.Point(124, 133);
            this.pos11.Name = "pos11";
            this.pos11.Size = new System.Drawing.Size(115, 91);
            this.pos11.TabIndex = 4;
            this.pos11.UseVisualStyleBackColor = true;
            this.pos11.Click += new System.EventHandler(this.pos11_Click);
            // 
            // pos10
            // 
            this.pos10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos10.Location = new System.Drawing.Point(3, 134);
            this.pos10.Name = "pos10";
            this.pos10.Size = new System.Drawing.Size(115, 91);
            this.pos10.TabIndex = 3;
            this.pos10.UseVisualStyleBackColor = true;
            this.pos10.Click += new System.EventHandler(this.pos10_Click);
            // 
            // pos22
            // 
            this.pos22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos22.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos22.Location = new System.Drawing.Point(243, 231);
            this.pos22.Name = "pos22";
            this.pos22.Size = new System.Drawing.Size(115, 91);
            this.pos22.TabIndex = 8;
            this.pos22.UseVisualStyleBackColor = true;
            this.pos22.Click += new System.EventHandler(this.pos22_Click);
            // 
            // pos21
            // 
            this.pos21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos21.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos21.Location = new System.Drawing.Point(124, 231);
            this.pos21.Name = "pos21";
            this.pos21.Size = new System.Drawing.Size(115, 91);
            this.pos21.TabIndex = 7;
            this.pos21.UseVisualStyleBackColor = true;
            this.pos21.Click += new System.EventHandler(this.pos21_Click);
            // 
            // pos20
            // 
            this.pos20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pos20.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pos20.Location = new System.Drawing.Point(3, 231);
            this.pos20.Name = "pos20";
            this.pos20.Size = new System.Drawing.Size(115, 91);
            this.pos20.TabIndex = 6;
            this.pos20.UseVisualStyleBackColor = true;
            this.pos20.Click += new System.EventHandler(this.pos20_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pos00);
            this.panel1.Controls.Add(this.pos22);
            this.panel1.Controls.Add(this.pos01);
            this.panel1.Controls.Add(this.pos21);
            this.panel1.Controls.Add(this.pos02);
            this.panel1.Controls.Add(this.pos20);
            this.panel1.Controls.Add(this.pos10);
            this.panel1.Controls.Add(this.pos12);
            this.panel1.Controls.Add(this.pos11);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 325);
            this.panel1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.pieceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(361, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // pieceToolStripMenuItem
            // 
            this.pieceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.oToolStripMenuItem});
            this.pieceToolStripMenuItem.Name = "pieceToolStripMenuItem";
            this.pieceToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.pieceToolStripMenuItem.Text = "Piece";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xToolStripMenuItem.Text = "X";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // oToolStripMenuItem
            // 
            this.oToolStripMenuItem.Name = "oToolStripMenuItem";
            this.oToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oToolStripMenuItem.Text = "O";
            this.oToolStripMenuItem.Click += new System.EventHandler(this.oToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 327);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe | By Variable @ V3rmillion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pos00;
        private System.Windows.Forms.Button pos01;
        private System.Windows.Forms.Button pos02;
        private System.Windows.Forms.Button pos12;
        private System.Windows.Forms.Button pos11;
        private System.Windows.Forms.Button pos10;
        private System.Windows.Forms.Button pos22;
        private System.Windows.Forms.Button pos21;
        private System.Windows.Forms.Button pos20;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pieceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
    }
}


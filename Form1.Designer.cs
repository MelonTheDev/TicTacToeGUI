
namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.game = new System.Windows.Forms.ToolStripMenuItem();
            this.newgamemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.website = new System.Windows.Forms.ToolStripMenuItem();
            this.githubrp = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldbox = new System.Windows.Forms.GroupBox();
            this.C_2_2 = new System.Windows.Forms.Button();
            this.C_2_1 = new System.Windows.Forms.Button();
            this.C_2_0 = new System.Windows.Forms.Button();
            this.B_1_2 = new System.Windows.Forms.Button();
            this.B_1_1 = new System.Windows.Forms.Button();
            this.B_1_0 = new System.Windows.Forms.Button();
            this.A_0_2 = new System.Windows.Forms.Button();
            this.A_0_1 = new System.Windows.Forms.Button();
            this.A_0_0 = new System.Windows.Forms.Button();
            this.playerbox = new System.Windows.Forms.GroupBox();
            this.infotext = new System.Windows.Forms.Label();
            this.options = new System.Windows.Forms.ToolStripMenuItem();
            this.newgame = new System.Windows.Forms.ToolStripMenuItem();
            this.winnerausgabe = new System.Windows.Forms.Label();
            this.playagain = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.fieldbox.SuspendLayout();
            this.playerbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.game,
            this.about});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.menuStrip.Size = new System.Drawing.Size(285, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // game
            // 
            this.game.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newgamemenu,
            this.toolStripSeparator1,
            this.optionsmenu,
            this.exitmenu});
            this.game.ForeColor = System.Drawing.Color.DarkGray;
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(50, 24);
            this.game.Text = "Game";
            // 
            // newgamemenu
            // 
            this.newgamemenu.BackColor = System.Drawing.SystemColors.Control;
            this.newgamemenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newgamemenu.Name = "newgamemenu";
            this.newgamemenu.Size = new System.Drawing.Size(132, 22);
            this.newgamemenu.Text = "New Game";
            this.newgamemenu.Click += new System.EventHandler(this.Newgame);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // optionsmenu
            // 
            this.optionsmenu.BackColor = System.Drawing.SystemColors.Control;
            this.optionsmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsmenu.Name = "optionsmenu";
            this.optionsmenu.Size = new System.Drawing.Size(132, 22);
            this.optionsmenu.Text = "Options";
            this.optionsmenu.Click += new System.EventHandler(this.optionsmenu_Click);
            // 
            // exitmenu
            // 
            this.exitmenu.Name = "exitmenu";
            this.exitmenu.Size = new System.Drawing.Size(132, 22);
            this.exitmenu.Text = "Beenden";
            this.exitmenu.Click += new System.EventHandler(this.exitmenu_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.about.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.website,
            this.githubrp});
            this.about.ForeColor = System.Drawing.Color.DarkGray;
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(52, 24);
            this.about.Text = "About";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem1.Text = "Coded by Melonthedev";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(195, 6);
            // 
            // website
            // 
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(198, 22);
            this.website.Text = "Webseite";
            // 
            // githubrp
            // 
            this.githubrp.Name = "githubrp";
            this.githubrp.Size = new System.Drawing.Size(198, 22);
            this.githubrp.Text = "GitHub repository";
            // 
            // fieldbox
            // 
            this.fieldbox.Controls.Add(this.C_2_2);
            this.fieldbox.Controls.Add(this.C_2_1);
            this.fieldbox.Controls.Add(this.C_2_0);
            this.fieldbox.Controls.Add(this.B_1_2);
            this.fieldbox.Controls.Add(this.B_1_1);
            this.fieldbox.Controls.Add(this.B_1_0);
            this.fieldbox.Controls.Add(this.A_0_2);
            this.fieldbox.Controls.Add(this.A_0_1);
            this.fieldbox.Controls.Add(this.A_0_0);
            this.fieldbox.Location = new System.Drawing.Point(12, 80);
            this.fieldbox.Name = "fieldbox";
            this.fieldbox.Size = new System.Drawing.Size(261, 268);
            this.fieldbox.TabIndex = 2;
            this.fieldbox.TabStop = false;
            this.fieldbox.Text = "Field";
            // 
            // C_2_2
            // 
            this.C_2_2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.C_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_2_2.Location = new System.Drawing.Point(174, 183);
            this.C_2_2.Name = "C_2_2";
            this.C_2_2.Size = new System.Drawing.Size(77, 75);
            this.C_2_2.TabIndex = 8;
            this.C_2_2.Tag = "b";
            this.C_2_2.UseVisualStyleBackColor = true;
            this.C_2_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C_2_1
            // 
            this.C_2_1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.C_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_2_1.Location = new System.Drawing.Point(91, 183);
            this.C_2_1.Name = "C_2_1";
            this.C_2_1.Size = new System.Drawing.Size(77, 75);
            this.C_2_1.TabIndex = 7;
            this.C_2_1.Tag = "b";
            this.C_2_1.UseVisualStyleBackColor = true;
            this.C_2_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C_2_0
            // 
            this.C_2_0.Cursor = System.Windows.Forms.Cursors.Cross;
            this.C_2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C_2_0.Location = new System.Drawing.Point(8, 183);
            this.C_2_0.Name = "C_2_0";
            this.C_2_0.Size = new System.Drawing.Size(77, 75);
            this.C_2_0.TabIndex = 6;
            this.C_2_0.Tag = "b";
            this.C_2_0.UseVisualStyleBackColor = true;
            this.C_2_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // B_1_2
            // 
            this.B_1_2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.B_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_1_2.Location = new System.Drawing.Point(174, 102);
            this.B_1_2.Name = "B_1_2";
            this.B_1_2.Size = new System.Drawing.Size(77, 75);
            this.B_1_2.TabIndex = 5;
            this.B_1_2.Tag = "b";
            this.B_1_2.UseVisualStyleBackColor = true;
            this.B_1_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B_1_1
            // 
            this.B_1_1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.B_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_1_1.Location = new System.Drawing.Point(91, 102);
            this.B_1_1.Name = "B_1_1";
            this.B_1_1.Size = new System.Drawing.Size(77, 75);
            this.B_1_1.TabIndex = 4;
            this.B_1_1.Tag = "b";
            this.B_1_1.UseVisualStyleBackColor = true;
            this.B_1_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // B_1_0
            // 
            this.B_1_0.Cursor = System.Windows.Forms.Cursors.Cross;
            this.B_1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_1_0.Location = new System.Drawing.Point(8, 102);
            this.B_1_0.Name = "B_1_0";
            this.B_1_0.Size = new System.Drawing.Size(77, 75);
            this.B_1_0.TabIndex = 3;
            this.B_1_0.Tag = "b";
            this.B_1_0.UseVisualStyleBackColor = true;
            this.B_1_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // A_0_2
            // 
            this.A_0_2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.A_0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_0_2.Location = new System.Drawing.Point(174, 21);
            this.A_0_2.Name = "A_0_2";
            this.A_0_2.Size = new System.Drawing.Size(77, 75);
            this.A_0_2.TabIndex = 2;
            this.A_0_2.Tag = "b";
            this.A_0_2.UseVisualStyleBackColor = true;
            this.A_0_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // A_0_1
            // 
            this.A_0_1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.A_0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_0_1.Location = new System.Drawing.Point(91, 21);
            this.A_0_1.Name = "A_0_1";
            this.A_0_1.Size = new System.Drawing.Size(77, 75);
            this.A_0_1.TabIndex = 1;
            this.A_0_1.Tag = "b";
            this.A_0_1.UseVisualStyleBackColor = true;
            this.A_0_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A_0_0
            // 
            this.A_0_0.Cursor = System.Windows.Forms.Cursors.Cross;
            this.A_0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.A_0_0.Location = new System.Drawing.Point(8, 21);
            this.A_0_0.Name = "A_0_0";
            this.A_0_0.Size = new System.Drawing.Size(77, 75);
            this.A_0_0.TabIndex = 0;
            this.A_0_0.Tag = "b";
            this.A_0_0.UseVisualStyleBackColor = true;
            this.A_0_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // playerbox
            // 
            this.playerbox.Controls.Add(this.infotext);
            this.playerbox.Location = new System.Drawing.Point(12, 28);
            this.playerbox.Name = "playerbox";
            this.playerbox.Size = new System.Drawing.Size(261, 46);
            this.playerbox.TabIndex = 3;
            this.playerbox.TabStop = false;
            this.playerbox.Text = "Player";
            // 
            // infotext
            // 
            this.infotext.AutoSize = true;
            this.infotext.Location = new System.Drawing.Point(6, 19);
            this.infotext.Name = "infotext";
            this.infotext.Size = new System.Drawing.Size(181, 15);
            this.infotext.TabIndex = 0;
            this.infotext.Text = "Player 1 ist am Zug mit Symbol X";
            // 
            // options
            // 
            this.options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(132, 22);
            this.options.Text = "Options";
            // 
            // newgame
            // 
            this.newgame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(67)))), ((int)(((byte)(120)))));
            this.newgame.ForeColor = System.Drawing.Color.White;
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(132, 22);
            this.newgame.Text = "New Game";
            // 
            // winnerausgabe
            // 
            this.winnerausgabe.AutoSize = true;
            this.winnerausgabe.Location = new System.Drawing.Point(12, 351);
            this.winnerausgabe.Name = "winnerausgabe";
            this.winnerausgabe.Size = new System.Drawing.Size(0, 15);
            this.winnerausgabe.TabIndex = 5;
            // 
            // playagain
            // 
            this.playagain.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playagain.Location = new System.Drawing.Point(9, 369);
            this.playagain.Name = "playagain";
            this.playagain.Size = new System.Drawing.Size(264, 45);
            this.playagain.TabIndex = 6;
            this.playagain.Text = "Play again!";
            this.playagain.UseVisualStyleBackColor = true;
            this.playagain.Visible = false;
            this.playagain.Click += new System.EventHandler(this.Newgame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(285, 422);
            this.Controls.Add(this.playagain);
            this.Controls.Add(this.winnerausgabe);
            this.Controls.Add(this.playerbox);
            this.Controls.Add(this.fieldbox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.fieldbox.ResumeLayout(false);
            this.playerbox.ResumeLayout(false);
            this.playerbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem game;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.GroupBox fieldbox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem website;
        private System.Windows.Forms.ToolStripMenuItem githubrp;
        private System.Windows.Forms.Button C_2_2;
        private System.Windows.Forms.Button C_2_1;
        private System.Windows.Forms.Button C_2_0;
        private System.Windows.Forms.Button B_1_2;
        private System.Windows.Forms.Button B_1_1;
        private System.Windows.Forms.Button B_1_0;
        private System.Windows.Forms.Button A_0_2;
        private System.Windows.Forms.Button A_0_1;
        private System.Windows.Forms.Button A_0_0;
        private System.Windows.Forms.GroupBox playerbox;
        private System.Windows.Forms.Label infotext;
        private System.Windows.Forms.ToolStripMenuItem options;
        private System.Windows.Forms.ToolStripMenuItem newgame;
        private System.Windows.Forms.ToolStripMenuItem newgamemenu;
        private System.Windows.Forms.ToolStripMenuItem optionsmenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitmenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label winnerausgabe;
        private System.Windows.Forms.Button playagain;
    }
}


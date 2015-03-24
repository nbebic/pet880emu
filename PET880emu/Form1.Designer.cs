namespace PET880emu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memory = new System.Windows.Forms.DataGridView();
            this.R0Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.R1Test = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.R2Test = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.R3Test = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PCText = new System.Windows.Forms.TextBox();
            this.ZFlagCheck = new System.Windows.Forms.CheckBox();
            this.CFlagCheck = new System.Windows.Forms.CheckBox();
            this.MFlagCheck = new System.Windows.Forms.CheckBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.stopToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memory
            // 
            this.memory.AllowUserToAddRows = false;
            this.memory.AllowUserToDeleteRows = false;
            this.memory.AllowUserToResizeColumns = false;
            this.memory.AllowUserToResizeRows = false;
            this.memory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memory.EnableHeadersVisualStyles = false;
            this.memory.Location = new System.Drawing.Point(141, 27);
            this.memory.Name = "memory";
            this.memory.RowHeadersWidth = 48;
            this.memory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memory.Size = new System.Drawing.Size(466, 436);
            this.memory.TabIndex = 1;
            // 
            // R0Text
            // 
            this.R0Text.Location = new System.Drawing.Point(39, 27);
            this.R0Text.Name = "R0Text";
            this.R0Text.Size = new System.Drawing.Size(96, 20);
            this.R0Text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "R0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R1Test
            // 
            this.R1Test.Location = new System.Drawing.Point(39, 53);
            this.R1Test.Name = "R1Test";
            this.R1Test.Size = new System.Drawing.Size(96, 20);
            this.R1Test.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "R2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R2Test
            // 
            this.R2Test.Location = new System.Drawing.Point(39, 79);
            this.R2Test.Name = "R2Test";
            this.R2Test.Size = new System.Drawing.Size(96, 20);
            this.R2Test.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "R3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // R3Test
            // 
            this.R3Test.Location = new System.Drawing.Point(39, 105);
            this.R3Test.Name = "R3Test";
            this.R3Test.Size = new System.Drawing.Size(96, 20);
            this.R3Test.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCText
            // 
            this.PCText.Location = new System.Drawing.Point(39, 131);
            this.PCText.Name = "PCText";
            this.PCText.ReadOnly = true;
            this.PCText.Size = new System.Drawing.Size(96, 20);
            this.PCText.TabIndex = 10;
            // 
            // ZFlagCheck
            // 
            this.ZFlagCheck.AutoSize = true;
            this.ZFlagCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ZFlagCheck.Location = new System.Drawing.Point(39, 157);
            this.ZFlagCheck.Name = "ZFlagCheck";
            this.ZFlagCheck.Size = new System.Drawing.Size(18, 31);
            this.ZFlagCheck.TabIndex = 12;
            this.ZFlagCheck.Text = "Z";
            this.ZFlagCheck.UseVisualStyleBackColor = true;
            // 
            // CFlagCheck
            // 
            this.CFlagCheck.AutoSize = true;
            this.CFlagCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CFlagCheck.Location = new System.Drawing.Point(63, 157);
            this.CFlagCheck.Name = "CFlagCheck";
            this.CFlagCheck.Size = new System.Drawing.Size(18, 31);
            this.CFlagCheck.TabIndex = 13;
            this.CFlagCheck.Text = "C";
            this.CFlagCheck.UseVisualStyleBackColor = true;
            // 
            // MFlagCheck
            // 
            this.MFlagCheck.AutoSize = true;
            this.MFlagCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MFlagCheck.Location = new System.Drawing.Point(87, 157);
            this.MFlagCheck.Name = "MFlagCheck";
            this.MFlagCheck.Size = new System.Drawing.Size(20, 31);
            this.MFlagCheck.TabIndex = 14;
            this.MFlagCheck.Text = "M";
            this.MFlagCheck.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.toolStripMenuItem1.Text = "Run";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.loadFileToolStripMenuItem.Text = "Load File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 471);
            this.Controls.Add(this.MFlagCheck);
            this.Controls.Add(this.CFlagCheck);
            this.Controls.Add(this.ZFlagCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PCText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R3Test);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.R2Test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.R1Test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.R0Text);
            this.Controls.Add(this.memory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView memory;
        private System.Windows.Forms.TextBox R0Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox R1Test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox R2Test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox R3Test;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PCText;
        private System.Windows.Forms.CheckBox ZFlagCheck;
        private System.Windows.Forms.CheckBox CFlagCheck;
        private System.Windows.Forms.CheckBox MFlagCheck;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
    }
}


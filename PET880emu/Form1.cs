using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PET880emu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            memory.ColumnCount = memory.RowCount = 16;
            for (int i = 0; i < 16; i++)
			{
                memory.Columns[i].Width = 26;
                memory.Rows[i].Height = 26;
                memory.Rows[i].HeaderCell.Value = "0" + Convert.ToString(i, 16).ToUpper();
                memory.Columns[i].HeaderCell.Value = "0" + Convert.ToString(i, 16).ToUpper();
                for (int j = 0; j < 16; j++)
                {
                    memory[i, j].Value = "00";
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}

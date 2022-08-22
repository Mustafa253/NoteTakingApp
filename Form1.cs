using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingApp
{
    public partial class Form1 : Form
    {
        public string tName;
        public string noteMes;
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            titleName.Clear();
            noteMessage.Clear();

            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            tName = titleName.Text;
            noteMes = noteMessage.Text;

            datatreeV(tName,noteMes);
            

        }


        public void datatreeV(string tName, string noteMes)
        {

            dataGridView1.Rows.Add(tName, noteMes);

            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;




            titleName.Text = dataGridView1.Rows[rowIndex].Cells["Title"].Value.ToString();
            noteMessage.Text = dataGridView1.Rows[rowIndex].Cells["Note"].Value.ToString();
            

            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            int colIndex = dataGridView1.CurrentCell.ColumnIndex;

            ;

            dataGridView1.Rows[rowIndex].Cells["Title"].Value = titleName.Text;
            dataGridView1.Rows[rowIndex].Cells["Note"].Value = noteMessage.Text;

        }
    }
}

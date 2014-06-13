using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace makeTempTable
{
    public partial class Form1 : Form
    {
        int headerColumnCount;

        public Form1()
        {
            InitializeComponent();

            headerColumnCount = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createScript();
        }

        private void createScript()
        {
            this.output.Enabled = false;
            this.output.Clear();
            this.label1.Text = "";

            string dataSource = this.richTextBox1.Text;

            if (dataSource.Length == 0) return;
            try
            {

                string outputString = getQuery(dataSource);

                if (outputString == null) return;

                this.output.Text = outputString;

                Clipboard.SetData(DataFormats.UnicodeText, outputString);
                output.Enabled = true;

                this.label1.Text = "Copy to Clipboard";
            }
            catch (Exception e)
            {
                MessageBox.Show(">< Sorry Exception;;;;");
            }
        }

        private string getQuery(string dataSource)
        {
           

            string[] rows = dataSource.Split('\n');

            if (rows.Count() == 0) return null;

            headerColumnCount = rows[0].Trim().Split('\t').Count();

            //make good data
            string[] fixedRow = makeGoodData(rows);

            if (fixedRow == null) return null;


            StringBuilder sb = new StringBuilder();


            //row loop
            for (int idx = 0; idx < fixedRow.Count(); idx++)
            {
                string[] column = fixedRow[idx].Trim().Split('\t');
                int columnCount = column.Count();

                sb.Append(@"select ");

                //column loop
                for (int idx2 = 0; idx2 < columnCount; idx2++)
                {
                    //sb.Append(StringWrap.StringAddQuoto(column[idx2]));
                    sb.Append(StringWrap.StringAddQuoto(column[idx2],uiAutoToNumber.Checked));
                    sb.Append(string.Format(" AS C{0}", idx2));

                    if (idx2 != columnCount - 1)
                    {
                        sb.Append(",");
                    }
                }
                if (idx != fixedRow.Count() - 1)
                {
                    sb.AppendLine(" from dual union all");
                }
                else
                {
                    sb.Append(" from dual ");
                }
            }

            //string query;
            if (uiaddwith.Checked)
            {
                return withTemplete(sb.ToString());
                
                
            }
            if (uiaddtemporytable.Checked)
            {
                return tempTableTemplete(sb.ToString());
            }
            
            return sb.ToString();
;
        }
        private string[] makeGoodData(string[] dataSet)
        {
            if (dataSet.Last() == "") dataSet = dataSet.Where(w => w != dataSet.Last()).ToArray();


            for (int idx = 0; idx < dataSet.Count(); idx++)
            {
                if (dataSet[idx] == "") continue;
                if (dataSet[idx].StartsWith("\t")) dataSet[idx] = "null" + dataSet[idx];
                //if (dataSet[idx].Contains("\t\t")) dataSet[idx] = dataSet[idx].Replace("\t\t", "\tnull\t");
                while (true)
                {
                    if (dataSet[idx].Contains("\t\t"))
                    {
                        dataSet[idx] = dataSet[idx].Replace("\t\t", "\tnull\t");
                    }
                    else
                    {
                        break;
                    }
                }
                string[] column = dataSet[idx].Trim().Split('\t');
                int columnCount = column.Count();
                if (headerColumnCount != columnCount)
                {
                    DialogResult result = MessageBox.Show(string.Format("Check Source, diff header column count with row{0} column count, (Yes =Delete Data , No = igore)", idx), "Cancle?",MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                       
                        richTextBox1.Clear();
                        output.Enabled = false;
                        return null;
                    }
                }

            }

            return dataSet;
        }


        private string tempTableTemplete(string source)
        {
            string templete = string.Format(
            @" CREATE  GLOBAL TEMPORARY TABLE tempTalbe_{0:HHmmss}
                   ON  COMMIT  PRESERVE ROWS
                 AS (
                     select * from 
                      (
                      {1}
                      )
                  )
        ", DateTime.Now, source);

            return templete;
        }

        private string withTemplete(string source)
        {
            string templete = string.Format(
            @" WITH  T
                    AS (
                        select * from 
                        (
                        {0}
                        )
                    )
                Select * From T
                    ",source);

            return templete;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            createScript();
        }

        private void reset()
        {
            this.output.Clear();
            createScript();
        }

        private void uiaddwith_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void uiaddtemporytable_CheckedChanged(object sender, EventArgs e)
        {
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}

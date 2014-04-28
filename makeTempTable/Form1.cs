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
            this.output.Text = "";
            this.label1.Text = "";

            string dataSource = this.richTextBox1.Text;

            try
            {

                string outputString = getQuery(dataSource);
                this.output.Text = outputString;

                Clipboard.SetData(DataFormats.UnicodeText, outputString);

                this.label1.Text = "클립보드 복사했음";
            }
            catch (Exception e)
            {
                MessageBox.Show(">< 무슨에러인지 모르겠는데 발생함;;;;");
            }
        }

        private string getQuery(string dataSource)
        {
           

            string[] rows = dataSource.Split('\n');

            if (rows.Count() == 0) return null;

            headerColumnCount = rows[0].Trim().Split('\t').Count();

            //make good data
            string[] fixedRow = makeGoodData(rows);




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
                    sb.Append(StringWrap.StringAddQuoto(column[idx2]));
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

            string query;
            if (checkBox1.Checked)
            {
                query = tempTableTemplete(sb.ToString());
            }
            else
            {
                query = sb.ToString();
            }

            return query;
        }
        private string[] makeGoodData(string[] dataSet)
        {
            if (dataSet.Last() == "") dataSet = dataSet.Where(w => w != dataSet.Last()).ToArray();


            for (int idx = 0; idx < dataSet.Count(); idx++)
            {
                if (dataSet[idx] == "") continue;
                if (dataSet[idx].StartsWith("\t")) dataSet[idx] = "null" + dataSet[idx];
                if (dataSet[idx].Contains("\t\t")) dataSet[idx] = dataSet[idx].Replace("\t\t", "\tnull\t");

                string[] column = dataSet[idx].Trim().Split('\t');
                int columnCount = column.Count();
                if (headerColumnCount != columnCount)
                {
                    MessageBox.Show("헤더 컬럼 숫자와 로우 컬럼 숫자 일치하지 않음");
                }

            }

            return dataSet;
        }


        private string tempTableTemplete(string source)
        {
            string templete = string.Format( @" CREATE  GLOBAL TEMPORARY TABLE tempTalbe_{0:HHmmss}
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            createScript();
        }
    }
}

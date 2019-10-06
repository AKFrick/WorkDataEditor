using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace WorkDataEditor
{
    public partial class mainView: UserControl
    {
        private string fileName;
        private string delimiter = ",";
        public mainView()
        {
            InitializeComponent();
            openFile.Click += OpenFile_Click;
            initGrid();
        }
        private void initGrid()
        {
            grid.AutoGenerateColumns = false;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;            
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.DefaultCellStyle = cellStyle;
            }
        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
                grid.DataSource = parseWorkdataFile(fileName);                
            }
        }
        private Workdata parseWorkdataFile(string fileName)
        {
            Workdata result = new Workdata();
            using (TextFieldParser tfp = new TextFieldParser(fileName))
            {
                tfp.SetDelimiters(delimiter);
                if (!tfp.EndOfData) tfp.ReadFields(); //Read header line
                while (!tfp.EndOfData) result.Rows.Add(tfp.ReadFields());              
            }
            return result;
        } 

    }
}

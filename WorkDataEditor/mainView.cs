using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkDataEditor
{
    public partial class mainView: UserControl
    {
        private string fileName;
        private DataTable workdata;
        public mainView()
        {
            InitializeComponent();
            openFile.Click += OpenFile_Click;
        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openDialog.FileName;
            }
        }        

    }
}

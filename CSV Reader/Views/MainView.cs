using System;
using System.Windows.Forms;

namespace Views
{
    public partial class frmMainView : Form
    {
        public frmMainView()
        {
            InitializeComponent();
        }

        public void ShowMainView()
        {
            this.Show();
        }

        public event EventHandler btnLoadFileClick
        {
            add { btnLoadFile.Click += value; }
            remove { btnLoadFile.Click -= value; }
        }

        public event EventHandler btnRemoveAllClick
        {
            add { btnRemoveAll.Click += value; }
            remove { btnRemoveAll.Click -= value; }
        }

        public event EventHandler btnApplyFilterClick
        {
            add { btnApplyFilter.Click += value; }
            remove { btnApplyFilter.Click -= value; }
        }

        public event EventHandler btnRemoveOneclick
        {
            add { btnRemoveOne.Click += value; }
            remove { btnRemoveOne.Click -= value; }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMainView_Load(object sender, EventArgs e)
        {

        }
    }
}

using Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SearchElementOnArray : Form
    {
        private string _method;
        private int[] _array;
        public SearchElementOnArray(string method, int[] array)
        {
            _array = array;
            _method = method;
            InitializeComponent();
            this.methodLabel.Text += " " + _method;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SearchElementOnArray_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? index = null;
                int element = Convert.ToInt32(elementToSearch.Text);
                if (_method.Contains("Secuential"))
                {
                    index = _array.SecuentialSearch(element);
                }

                if (_method.Contains("Binary"))
                {
                    index = _array.BinarySearch(element);
                }

                if(index == null)
                {
                    labelToResult.Text = "Element Was Not Found";
                    return;
                }

                labelToResult.Text = "Element was found on the index: " + index;
            }catch(Exception err)
            {
                MessageBox.Show("Error: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void elementToSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

using Infrastructure.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        private ArrayLogic logic;        
        public MainForm()
        {
            
            logic = new ArrayLogic();
            InitializeComponent();
            this.loadingTitle.Hide();
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

        private async void generateButton_Click(object sender, EventArgs e)
        {
                LoadArray();
        }

        private async void LoadArray()
        {
            try
            {
                int nElements = Int32.Parse(numbersToGenerate.Text);
                HideControls("Generando Array!!");
                await logic.GenerateArrayAndFillRandomNumbers(nElements);
                ShowControls();
                MessageBox.Show("Array generado con éxito!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideControls(string title)
        {
            this.loadingTitle.Text = title;            
            this.loadingGif.Show();
            this.loadingTitle.Show();
            this.dataGridView1.Hide();
            this.numbersToGenerate.Hide();
            this.generateButton.Hide();
            
        }

        private void ShowControls()
        {
            this.loadingGif.Hide();
            this.loadingTitle.Hide();
            this.dataGridView1.Show();
            this.numbersToGenerate.Show();
            this.generateButton.Show();
        }

        private void numbersToGenerate_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void burbleButton_Click(object sender, EventArgs e)
        {            
            SortArrayBasedOnMethod("Burbuja");            
        }

        private async void SortArrayBasedOnMethod(string method)
        {
            try
            {                
                switch (method)
                {
                    case "Burbuja":
                        HideControls("Ordenando el Arreglo!");
                        burbleButton.Enabled = false;
                        await logic.SortArrayBasedOnMethod(burbleButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!",  "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                        break;
               }                
            }
            catch (Exception ex)
            {
                HideControls("Error!");
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            burbleButton.Enabled = true;
            ShowControls();
            LoadData();
        }

        private async void graphicButton_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await logic.GetReportsAsync();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
        }

        private async void LoadData()
        {
            var data = await logic.GetReportsAsync();            
            if(data.Count == 0)
            {
                this.dataGridView1.DataSource = null;
            }
            this.dataGridView1.DataSource = data.ToList();
        }
    }
}

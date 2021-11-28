using GUI.Dtos;
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
        private bool isSorted = false;
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
            try
            {
                int nElements = Int32.Parse(numbersToGenerate.Text);
                logic.InitialieArray(nElements);
                await LoadArray();
            }
            catch(Exception err)
            {
                MessageBox.Show("Ingrese números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadArray()
        {
            try
            {                
                HideControls("Generando Array!!");
                await logic.GenerateArrayAndFillRandomNumbers();
                ShowControls();
                MessageBox.Show("Array generado con éxito!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isSorted = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            this.burbleButton.Enabled = false;
            this.mergeButton.Enabled = false;
            this.quickSortButton.Enabled = false;
            this.insertionButton.Enabled = false;
            this.selectionButton.Enabled = false;
            this.graphicButton.Enabled = false;

        }

        private void ShowControls()
        {
            this.loadingGif.Hide();
            this.loadingTitle.Hide();
            this.dataGridView1.Show();
            this.numbersToGenerate.Show();
            this.generateButton.Show();

            this.burbleButton.Enabled = true;
            this.mergeButton.Enabled = true;
            this.quickSortButton.Enabled = true;
            this.insertionButton.Enabled = true;
            this.selectionButton.Enabled = true;
            this.graphicButton.Enabled = true;
        }

        private void numbersToGenerate_TextChanged(object sender, EventArgs e)
        {            
            
        }

        private void burbleButton_Click(object sender, EventArgs e)
        {            
            SortArrayBasedOnMethod("Burble");            
        }

        private async void SortArrayBasedOnMethod(string method)
        {
            try
            {                
                switch (method)
                {
                    case "Burble":
                        HideControls("Ordenando el Arreglo!");                        
                        await logic.SortArrayBasedOnMethod(burbleButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!",  "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "QuickSort":
                        HideControls("Ordenando el Arreglo!");                        
                        await logic.SortArrayBasedOnMethod(quickSortButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!", "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Merge":
                        HideControls("Ordenando el Arreglo!");                        
                        await logic.SortArrayBasedOnMethod(mergeButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!", "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Insertion":
                        HideControls("Ordenando el Arreglo!");
                        await logic.SortArrayBasedOnMethod(insertionButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!", "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Selection":
                        HideControls("Ordenando el Arreglo!");
                        await logic.SortArrayBasedOnMethod(selectionButton.Text);
                        MessageBox.Show("Arreglo ordenado con éxito!!", "Sort Methods", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                isSorted = true;
                LoadData();
            }
            catch (Exception ex)
            {
                HideControls("Error!");
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            burbleButton.Enabled = true;
            ShowControls();
        }

        private async void graphicButton_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await logic.GetReportsAsync();
                if(data.Count == 0)
                {
                    MessageBox.Show("Error: There are no reports generated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Chart chart = new Chart(logic);
                chart.Show();
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

        private void quickSortButton_Click(object sender, EventArgs e)
        {
            SortArrayBasedOnMethod("QuickSort");
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            SortArrayBasedOnMethod("Merge");
        }

        private void selectionButton_Click(object sender, EventArgs e)
        {
            SortArrayBasedOnMethod("Selection");
        }

        private void insertionButton_Click(object sender, EventArgs e)
        {
            SortArrayBasedOnMethod("Insertion");
        }

        private void secuentialSearchButton_Click(object sender, EventArgs e)
        {
            if(this.logic.GetArray() == null)
            {
                MessageBox.Show("Initialize Array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SearchElementOnArray search = new SearchElementOnArray("Secuential", logic.GetArray());
            search.Show();
        }

        private void binaryButton_Click(object sender, EventArgs e)
        {
            if (this.logic.GetArray() == null)
            {
                MessageBox.Show("Initialize Array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isSorted)
            {
                MessageBox.Show("Sort Array", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SearchElementOnArray search = new SearchElementOnArray("Binary", logic.GetArray());
            search.Show();
        }
    }
}

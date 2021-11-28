
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numbersToGenerate = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            this.loadingTitle = new System.Windows.Forms.Label();
            this.burbleButton = new System.Windows.Forms.Button();
            this.graphicButton = new System.Windows.Forms.Button();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.selectionButton = new System.Windows.Forms.Button();
            this.insertionButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.secuentialSearchButton = new System.Windows.Forms.Button();
            this.binaryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(991, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 55);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort Methods";
            // 
            // numbersToGenerate
            // 
            this.numbersToGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(28)))));
            this.numbersToGenerate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbersToGenerate.ForeColor = System.Drawing.Color.White;
            this.numbersToGenerate.Location = new System.Drawing.Point(303, 92);
            this.numbersToGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numbersToGenerate.Multiline = true;
            this.numbersToGenerate.Name = "numbersToGenerate";
            this.numbersToGenerate.Size = new System.Drawing.Size(221, 41);
            this.numbersToGenerate.TabIndex = 3;
            this.numbersToGenerate.TextChanged += new System.EventHandler(this.numbersToGenerate_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(533, 92);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(177, 42);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(229, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(593, 274);
            this.dataGridView1.TabIndex = 5;
            // 
            // loadingGif
            // 
            this.loadingGif.Image = ((System.Drawing.Image)(resources.GetObject("loadingGif.Image")));
            this.loadingGif.Location = new System.Drawing.Point(229, 142);
            this.loadingGif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(593, 274);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGif.TabIndex = 6;
            this.loadingGif.TabStop = false;
            // 
            // loadingTitle
            // 
            this.loadingTitle.AutoSize = true;
            this.loadingTitle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingTitle.ForeColor = System.Drawing.Color.White;
            this.loadingTitle.Location = new System.Drawing.Point(391, 389);
            this.loadingTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loadingTitle.Name = "loadingTitle";
            this.loadingTitle.Size = new System.Drawing.Size(311, 28);
            this.loadingTitle.TabIndex = 7;
            this.loadingTitle.Text = "Métodos de Ordenamiento";
            // 
            // burbleButton
            // 
            this.burbleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.burbleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.burbleButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burbleButton.ForeColor = System.Drawing.Color.White;
            this.burbleButton.Location = new System.Drawing.Point(11, 424);
            this.burbleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.burbleButton.Name = "burbleButton";
            this.burbleButton.Size = new System.Drawing.Size(177, 42);
            this.burbleButton.TabIndex = 8;
            this.burbleButton.Text = "Burble";
            this.burbleButton.UseVisualStyleBackColor = false;
            this.burbleButton.Click += new System.EventHandler(this.burbleButton_Click);
            // 
            // graphicButton
            // 
            this.graphicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.graphicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphicButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicButton.ForeColor = System.Drawing.Color.White;
            this.graphicButton.Location = new System.Drawing.Point(874, 423);
            this.graphicButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graphicButton.Name = "graphicButton";
            this.graphicButton.Size = new System.Drawing.Size(177, 42);
            this.graphicButton.TabIndex = 9;
            this.graphicButton.Text = "Graphic";
            this.graphicButton.UseVisualStyleBackColor = false;
            this.graphicButton.Click += new System.EventHandler(this.graphicButton_Click);
            // 
            // quickSortButton
            // 
            this.quickSortButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.quickSortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quickSortButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickSortButton.ForeColor = System.Drawing.Color.White;
            this.quickSortButton.Location = new System.Drawing.Point(196, 424);
            this.quickSortButton.Margin = new System.Windows.Forms.Padding(4);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(177, 42);
            this.quickSortButton.TabIndex = 10;
            this.quickSortButton.Text = "QuickSort";
            this.quickSortButton.UseVisualStyleBackColor = false;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // selectionButton
            // 
            this.selectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.selectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionButton.ForeColor = System.Drawing.Color.White;
            this.selectionButton.Location = new System.Drawing.Point(11, 474);
            this.selectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(177, 42);
            this.selectionButton.TabIndex = 11;
            this.selectionButton.Text = "Selection";
            this.selectionButton.UseVisualStyleBackColor = false;
            this.selectionButton.Click += new System.EventHandler(this.selectionButton_Click);
            // 
            // insertionButton
            // 
            this.insertionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.insertionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertionButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertionButton.ForeColor = System.Drawing.Color.White;
            this.insertionButton.Location = new System.Drawing.Point(196, 474);
            this.insertionButton.Margin = new System.Windows.Forms.Padding(4);
            this.insertionButton.Name = "insertionButton";
            this.insertionButton.Size = new System.Drawing.Size(177, 42);
            this.insertionButton.TabIndex = 12;
            this.insertionButton.Text = "Insertion";
            this.insertionButton.UseVisualStyleBackColor = false;
            this.insertionButton.Click += new System.EventHandler(this.insertionButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.mergeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeButton.ForeColor = System.Drawing.Color.White;
            this.mergeButton.Location = new System.Drawing.Point(381, 425);
            this.mergeButton.Margin = new System.Windows.Forms.Padding(4);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(177, 42);
            this.mergeButton.TabIndex = 13;
            this.mergeButton.Text = "Merge";
            this.mergeButton.UseVisualStyleBackColor = false;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // secuentialSearchButton
            // 
            this.secuentialSearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.secuentialSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secuentialSearchButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secuentialSearchButton.ForeColor = System.Drawing.Color.White;
            this.secuentialSearchButton.Location = new System.Drawing.Point(689, 423);
            this.secuentialSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.secuentialSearchButton.Name = "secuentialSearchButton";
            this.secuentialSearchButton.Size = new System.Drawing.Size(177, 42);
            this.secuentialSearchButton.TabIndex = 14;
            this.secuentialSearchButton.Text = "Secuential";
            this.secuentialSearchButton.UseVisualStyleBackColor = false;
            this.secuentialSearchButton.Click += new System.EventHandler(this.secuentialSearchButton_Click);
            // 
            // binaryButton
            // 
            this.binaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(199)))), ((int)(((byte)(154)))));
            this.binaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binaryButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryButton.ForeColor = System.Drawing.Color.White;
            this.binaryButton.Location = new System.Drawing.Point(689, 473);
            this.binaryButton.Margin = new System.Windows.Forms.Padding(4);
            this.binaryButton.Name = "binaryButton";
            this.binaryButton.Size = new System.Drawing.Size(177, 42);
            this.binaryButton.TabIndex = 15;
            this.binaryButton.Text = "Binary";
            this.binaryButton.UseVisualStyleBackColor = false;
            this.binaryButton.Click += new System.EventHandler(this.binaryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.binaryButton);
            this.Controls.Add(this.secuentialSearchButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.insertionButton);
            this.Controls.Add(this.selectionButton);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.graphicButton);
            this.Controls.Add(this.burbleButton);
            this.Controls.Add(this.loadingTitle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numbersToGenerate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loadingGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numbersToGenerate;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox loadingGif;
        private System.Windows.Forms.Label loadingTitle;
        private System.Windows.Forms.Button burbleButton;
        private System.Windows.Forms.Button graphicButton;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.Button insertionButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button secuentialSearchButton;
        private System.Windows.Forms.Button binaryButton;
    }
}


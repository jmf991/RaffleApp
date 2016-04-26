namespace SorteoBenefico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Generar = new System.Windows.Forms.Button();
            this.textBox_Premios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.papeletasGanadoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioGanado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papeletasVendidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_exportExcel = new System.Windows.Forms.Button();
            this.button_exportPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Generar
            // 
            this.button_Generar.BackgroundImage = global::SorteoBenefico.Properties.Resources._1231;
            this.button_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generar.Location = new System.Drawing.Point(292, 89);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(238, 231);
            this.button_Generar.TabIndex = 3;
            this.button_Generar.Text = "Generar Rifa";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // textBox_Premios
            // 
            this.textBox_Premios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Premios.Location = new System.Drawing.Point(430, 12);
            this.textBox_Premios.Name = "textBox_Premios";
            this.textBox_Premios.Size = new System.Drawing.Size(100, 20);
            this.textBox_Premios.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número de Premios";
            // 
            // textBox_max
            // 
            this.textBox_max.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_max.Location = new System.Drawing.Point(430, 41);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 20);
            this.textBox_max.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Papeletas vendidas";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papeletasGanadoras,
            this.premioGanado});
            this.dataGridView2.Location = new System.Drawing.Point(584, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 425);
            this.dataGridView2.TabIndex = 8;
            // 
            // papeletasGanadoras
            // 
            this.papeletasGanadoras.HeaderText = "Papeletas Ganadoras";
            this.papeletasGanadoras.Name = "papeletasGanadoras";
            // 
            // premioGanado
            // 
            this.premioGanado.HeaderText = "Premio Ganado";
            this.premioGanado.Name = "premioGanado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papeletasVendidas});
            this.dataGridView1.Location = new System.Drawing.Point(35, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(159, 413);
            this.dataGridView1.TabIndex = 9;
            // 
            // papeletasVendidas
            // 
            this.papeletasVendidas.HeaderText = "Papeletas Vendidas";
            this.papeletasVendidas.Name = "papeletasVendidas";
            this.papeletasVendidas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(63, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de Papeletas Vendidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(633, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista de Papeletas Ganadoras";
            // 
            // button_exportExcel
            // 
            this.button_exportExcel.BackgroundImage = global::SorteoBenefico.Properties.Resources.arosmpale;
            this.button_exportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportExcel.Location = new System.Drawing.Point(292, 347);
            this.button_exportExcel.Name = "button_exportExcel";
            this.button_exportExcel.Size = new System.Drawing.Size(238, 36);
            this.button_exportExcel.TabIndex = 12;
            this.button_exportExcel.Text = "Exportar  a Excel";
            this.button_exportExcel.UseVisualStyleBackColor = true;
            this.button_exportExcel.Click += new System.EventHandler(this.button_exportExcel_Click);
            // 
            // button_exportPDF
            // 
            this.button_exportPDF.BackgroundImage = global::SorteoBenefico.Properties.Resources.arosmpale;
            this.button_exportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportPDF.Location = new System.Drawing.Point(292, 389);
            this.button_exportPDF.Name = "button_exportPDF";
            this.button_exportPDF.Size = new System.Drawing.Size(238, 36);
            this.button_exportPDF.TabIndex = 13;
            this.button_exportPDF.Text = "Exportar a PDF";
            this.button_exportPDF.UseVisualStyleBackColor = true;
            this.button_exportPDF.Click += new System.EventHandler(this.button_exportPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SorteoBenefico.Properties.Resources._1231;
            this.ClientSize = new System.Drawing.Size(850, 462);
            this.Controls.Add(this.button_exportPDF);
            this.Controls.Add(this.button_exportExcel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Premios);
            this.Controls.Add(this.button_Generar);
            this.Name = "Form1";
            this.Text = "Sorteo Benéfico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generar;
        private System.Windows.Forms.TextBox textBox_Premios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn papeletasGanadoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn premioGanado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_exportExcel;
        private System.Windows.Forms.Button button_exportPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn papeletasVendidas;
    }
}


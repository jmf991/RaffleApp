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
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.textBox_sheet = new System.Windows.Forms.TextBox();
            this.button_chooseFile = new System.Windows.Forms.Button();
            this.button_loadExcel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Generar
            // 
            this.button_Generar.BackgroundImage = global::SorteoBenefico.Properties.Resources._1231;
            this.button_Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generar.Location = new System.Drawing.Point(220, 118);
            this.button_Generar.Name = "button_Generar";
            this.button_Generar.Size = new System.Drawing.Size(238, 175);
            this.button_Generar.TabIndex = 3;
            this.button_Generar.Text = "Generar Rifa";
            this.button_Generar.UseVisualStyleBackColor = true;
            this.button_Generar.Click += new System.EventHandler(this.button_Generar_Click);
            // 
            // textBox_Premios
            // 
            this.textBox_Premios.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Premios.Location = new System.Drawing.Point(358, 12);
            this.textBox_Premios.Name = "textBox_Premios";
            this.textBox_Premios.Size = new System.Drawing.Size(100, 20);
            this.textBox_Premios.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Número de Premios";
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
            this.dataGridView2.Location = new System.Drawing.Point(480, 3);
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(159, 425);
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
            this.label3.Location = new System.Drawing.Point(44, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lista de Papeletas Vendidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(531, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista de Papeletas Ganadoras";
            // 
            // button_exportExcel
            // 
            this.button_exportExcel.BackgroundImage = global::SorteoBenefico.Properties.Resources.arosmpale;
            this.button_exportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportExcel.Location = new System.Drawing.Point(220, 338);
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
            this.button_exportPDF.Location = new System.Drawing.Point(220, 392);
            this.button_exportPDF.Name = "button_exportPDF";
            this.button_exportPDF.Size = new System.Drawing.Size(238, 36);
            this.button_exportPDF.TabIndex = 13;
            this.button_exportPDF.Text = "Exportar a PDF";
            this.button_exportPDF.UseVisualStyleBackColor = true;
            this.button_exportPDF.Click += new System.EventHandler(this.button_exportPDF_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(181, 108);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(351, 20);
            this.textBox_path.TabIndex = 15;
            this.textBox_path.Text = "ExcelFile.xls";
            // 
            // textBox_sheet
            // 
            this.textBox_sheet.Location = new System.Drawing.Point(181, 147);
            this.textBox_sheet.Name = "textBox_sheet";
            this.textBox_sheet.Size = new System.Drawing.Size(351, 20);
            this.textBox_sheet.TabIndex = 16;
            // 
            // button_chooseFile
            // 
            this.button_chooseFile.Location = new System.Drawing.Point(59, 108);
            this.button_chooseFile.Name = "button_chooseFile";
            this.button_chooseFile.Size = new System.Drawing.Size(116, 20);
            this.button_chooseFile.TabIndex = 17;
            this.button_chooseFile.Text = "Choose File";
            this.button_chooseFile.UseVisualStyleBackColor = true;
            this.button_chooseFile.Click += new System.EventHandler(this.button_chooseFile_Click);
            // 
            // button_loadExcel
            // 
            this.button_loadExcel.BackgroundImage = global::SorteoBenefico.Properties.Resources.arosmbr;
            this.button_loadExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loadExcel.Location = new System.Drawing.Point(538, 108);
            this.button_loadExcel.Name = "button_loadExcel";
            this.button_loadExcel.Size = new System.Drawing.Size(171, 59);
            this.button_loadExcel.TabIndex = 18;
            this.button_loadExcel.Text = "Cargar Excel";
            this.button_loadExcel.UseVisualStyleBackColor = true;
            this.button_loadExcel.Click += new System.EventHandler(this.button_loadExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(278, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Antes de Generar  la Rifa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(448, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "1. Introduzca un archivo Excel.xls y el nombre de la hoja que quiere cargar.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "2. Confirme el Número de Premios y el de Papeletas Vendidas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_path);
            this.panel1.Controls.Add(this.textBox_sheet);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_chooseFile);
            this.panel1.Controls.Add(this.button_loadExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 222);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.button_Generar);
            this.panel2.Controls.Add(this.button_exportPDF);
            this.panel2.Controls.Add(this.textBox_Premios);
            this.panel2.Controls.Add(this.button_exportExcel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 443);
            this.panel2.TabIndex = 23;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 443);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(860, 3);
            this.splitter1.TabIndex = 24;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre de la hoja (Hoja1, Sheet1...)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(860, 674);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sorteo Benéfico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Generar;
        private System.Windows.Forms.TextBox textBox_Premios;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.TextBox textBox_sheet;
        private System.Windows.Forms.Button button_chooseFile;
        private System.Windows.Forms.Button button_loadExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
    }
}


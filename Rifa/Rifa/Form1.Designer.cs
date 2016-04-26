namespace Rifa
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
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.Generar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Premios = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.papeletas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_exportar = new System.Windows.Forms.Button();
            this.button_exportPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(41, 52);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(111, 20);
            this.textBox_max.TabIndex = 0;
            // 
            // Generar
            // 
            this.Generar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Generar.BackgroundImage = global::Rifa.Properties.Resources._1231;
            this.Generar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generar.Location = new System.Drawing.Point(41, 180);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(280, 311);
            this.Generar.TabIndex = 3;
            this.Generar.Text = "Generar Rifa";
            this.Generar.UseVisualStyleBackColor = false;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Papeletas Vendidas";
            // 
            // textBox_Premios
            // 
            this.textBox_Premios.Location = new System.Drawing.Point(41, 117);
            this.textBox_Premios.Name = "textBox_Premios";
            this.textBox_Premios.Size = new System.Drawing.Size(111, 20);
            this.textBox_Premios.TabIndex = 6;
            this.textBox_Premios.TextChanged += new System.EventHandler(this.textBox_Premios_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número de Premios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.papeletas,
            this.premios});
            this.dataGridView1.Location = new System.Drawing.Point(374, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(259, 601);
            this.dataGridView1.TabIndex = 11;
            // 
            // papeletas
            // 
            this.papeletas.HeaderText = "Papeletas";
            this.papeletas.Name = "papeletas";
            // 
            // premios
            // 
            this.premios.HeaderText = "Premios";
            this.premios.Name = "premios";
            // 
            // button_exportar
            // 
            this.button_exportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportar.Location = new System.Drawing.Point(41, 529);
            this.button_exportar.Name = "button_exportar";
            this.button_exportar.Size = new System.Drawing.Size(284, 40);
            this.button_exportar.TabIndex = 12;
            this.button_exportar.Text = "Exportar a Excel";
            this.button_exportar.UseVisualStyleBackColor = false;
            this.button_exportar.Click += new System.EventHandler(this.button_exportar_Click);
            // 
            // button_exportPDF
            // 
            this.button_exportPDF.BackColor = System.Drawing.Color.Silver;
            this.button_exportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportPDF.Location = new System.Drawing.Point(41, 575);
            this.button_exportPDF.Name = "button_exportPDF";
            this.button_exportPDF.Size = new System.Drawing.Size(286, 38);
            this.button_exportPDF.TabIndex = 13;
            this.button_exportPDF.Text = "Exportar a PDF";
            this.button_exportPDF.UseVisualStyleBackColor = false;
            this.button_exportPDF.Click += new System.EventHandler(this.button_exportPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Rifa.Properties.Resources.bg_blurry;
            this.ClientSize = new System.Drawing.Size(673, 637);
            this.Controls.Add(this.button_exportPDF);
            this.Controls.Add(this.button_exportar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Premios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.textBox_max);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Premios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn papeletas;
        private System.Windows.Forms.DataGridViewTextBoxColumn premios;
        private System.Windows.Forms.Button button_exportar;
        private System.Windows.Forms.Button button_exportPDF;
    }
}


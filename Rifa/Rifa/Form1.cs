using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.IO;
using System.Collections;
using System.Net;




namespace Rifa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LLenarGrid("E:\\source\\Files\\papeletasExcel.xlsx", "Sheet1");
        }
        private void Generar_Click(object sender, EventArgs e)
        {
            int papeletas = Int32.Parse(textBox_max.Text);                          //numero de papeletas vendidas
            int premios = Int32.Parse(textBox_Premios.Text);                        //numero de premios disponibles          

            Random rnd1 = new Random();                                            //numero random de papeletas           
            List<int> List1 = new List<int>();                                     //Lista para almacenamiento de numeros de papeletas ya generadas           
            List<int> List2 = new List<int>();

            if (papeletas > premios)
            {
                for (Int32 i = 1; i <= premios; i++)                                               //loop para agregar numeros al datagridView 
                {
                    int textBox_ganador = rnd1.Next(1, papeletas + 1);                             //generacion de numero random para papeletas 
                    int textBox_premioGanado = i;                                                  //numero de premio, con un incremento de +1 por
                    //cada papeleta añadida atextBox-ganador 

                    if (List1.Contains(textBox_ganador))                                           //si contiene el numero, no resta intento
                    {
                        i--;
                    }
                    while (!List1.Contains(textBox_ganador))                                        //si no contiene el numero                      
                    {
                        List1.Add(textBox_ganador);                                                 //lo añade   
                        List1.Contains(textBox_ganador);                                            //lo contiene  
                        this.dataGridView1.Rows.Add(textBox_ganador, textBox_premioGanado);         //lo muestra
                        //MessageBox.Show(textBox_ganador + "" + "otra variable" + i);            
                    }
                }
            }
            if (papeletas <= premios)
            {
                for (Int32 i = 1; i <= premios; )                                               //loop para agregar numeros al datagridView 
                {
                    int textBox_ganador = rnd1.Next(1, papeletas + 1);
                    MessageBox.Show("Hay que introducir un numero mayor de Papeletas que de Premios");
                    break;
                }
            }


        }

        private void textBox_Premios_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox_premioGanado_TextChanged(object sender, EventArgs e)
        {
        }

        //Exportación a Excel
        private void button_exportar_Click(object sender, EventArgs e)
        {         
            // Crea un objeto Excel. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop a traves de cada fila leyendo sus valores 
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        // El indice de Excel empieza por 1,1. Siendo los headers de columna, añadiendo un condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Localizacion y nombre de achivo se piden para que lo guarde el usuario. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Excel de la Rifa creado");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }           
        }

        //Exportación a PDF (el PDF se guarda en: Rifa/bin/debug)
        private void button_exportPDF_Click(object sender, EventArgs e)
        {

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("RifaPDF.pdf", FileMode.Create));

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            doc.Open(); //Open Document to Write
            //Add the headers
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }

            //Flag the first row as a header
            table.HeaderRows = 1; 

            //Add the actual rows from th DGV to the table
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView1.Columns.Count; k++)
                {
                    if (dataGridView1[k, i].Value !=null)
                    {
                        table.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                    }
                }
            }

            //Add out table
            doc.Add(table);

            //Close document
            doc.Close();
                MessageBox.Show("Exportado a PDF!");
        }
    }
}

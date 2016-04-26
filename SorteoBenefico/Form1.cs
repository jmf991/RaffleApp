using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.IO;
using System.Collections;
using System.Net;




namespace SorteoBenefico
{
    public partial class Form1 : Form
    {
        private List<double> papeletasVendidasList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            papeletasVendidasList = new List<double>();
        }


        public static DataTable GetDataTableExcel(string strFileName, string Table)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source = " + strFileName + "; Extended Properties = \"Excel 8.0;HDR=Yes;IMEX=1\";");
            conn.Open();
            string strQuery = "SELECT * FROM [" + Table + "]";
            System.Data.OleDb.OleDbDataAdapter adapter = new System.Data.OleDb.OleDbDataAdapter(strQuery, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public void LLenarGrid(string archivo, string hoja)
        {
            //OleDbConnection conexion = null;
            //DataSet dataSet = null;
            //OleDbDataAdapter dataAdapter = null;

            //string consultaHojaExcel = "Select * from [" + hoja + "$]";
            ////Para archivos excel 2007 y 2010
            //string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //if (string.IsNullOrEmpty(hoja)) //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            //{
            //    MessageBox.Show("No hay una hoja para leer o está vacía");
            //}
            //else
            //{
            //    try
            //    {
            //        conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
            //        conexion.Open(); //abrimos la conexion
            //        dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
            //        dataSet = new DataSet(); // creamos la instancia del objeto DataSet
            //        dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
            //        dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
            //        conexion.Close();//cerramos la conexion
            //        dataGridView1.AllowUserToAddRows = false;//eliminamos la ultima fila del datagridview que se autoagrega                   
            //    }
            //    catch (Exception ex)
            //    {
            //        //en caso de haber una excepcion que nos mande un mensaje de error
            //        MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
            //    }
            //}
            
        }

        public void button_Generar_Click(object sender, EventArgs e)
        {
            //El valor máximo de una papeleta ganadora correspondera al de la papeleta con mayor valor en papeletasVendidasList
            double papeletaMax = double.MinValue;
            foreach (object myPapeleta in papeletasVendidasList)
            {
                if (myPapeleta is double)
                {
                    if ((double)myPapeleta > papeletaMax)
                    {
                        papeletaMax = (double)myPapeleta;
                    }
                }
            }
            //MessageBox.Show("el numero maximo es:" + papeletaMax);

            int papeletasVendidas = Int32.Parse( dataGridView1.RowCount.ToString()); //numero de papeletas vendidas
            int parsedValue;
            if (!int.TryParse(textBox_Premios.Text, out parsedValue))
            {
                MessageBox.Show("Debes introducir el Número de Premios disponibles");
                return;
            }
            int premios = Int32.Parse(textBox_Premios.Text); //numero de premios disponibles  
            

            Random rnd1 = new Random(); //numero random de papeletas         
            List<double> papeletasGanadorasList = new List<double>(); //Lista para almacenamiento de numeros de papeletasGanadoras ya generadas   
            List<double> papeletasGanadoraRepeatList = new List<double>();

            if (papeletasVendidas > premios)
            {
                for (Int32 i = 1; i <= premios; i++) //loop para agregar numeros al datagridView 
                {
                    double papeletaGanadora = rnd1.Next(1, (int)papeletaMax + 1); //generacion de numero random para papeletas 
                    double premioGanado = i; //numero de premio, con un incremento de +1 por cada papeleta añadida atextBox-ganador

                    if (papeletasVendidasList == null)
                    {
                        MessageBox.Show("papeletasVendidasList vacía!");
                        break;
                    }
                    else
                    {
                        //MessageBox.Show("La papeleta ganadora es: " + papeletaGanadora);
                        if (papeletasVendidasList.Contains(papeletaGanadora)) //Si esta en la Lista de papeletas vendidas(papeletasVendidasList)
                        {
                            if (papeletasGanadorasList.Contains(papeletaGanadora)) //si esta en la Lista de papeletas ganadoras(papeletasGanadorasList)
                            {
                                i--;
                                continue;
                            }
                            if (!papeletasGanadorasList.Contains(papeletaGanadora)) //si NO esta en Lista papeletas ganadoras aun (papeletasGanadorasList)
                            {
                                papeletasGanadorasList.Add(papeletaGanadora); //lo añade lista Ganadoras 
                                papeletasGanadorasList.Contains(papeletaGanadora); //lo contiene lista Ganadoras    
                                this.dataGridView2.Rows.Add(papeletaGanadora, premioGanado); //lo muestra
                            }
                        }
                        if (!papeletasVendidasList.Contains(papeletaGanadora)) //si NO esta en Lista papeletas vendidas genera otro numero                   
                        {
                            i--;
                            continue;
                        }
                    }

                }
            }
            if (papeletasVendidas <= premios) //En caso de que se introduzcan mas premios que papeletas saltará el mensaje
            {
                for (Int32 i = 1; i <= premios; )
                {
                    MessageBox.Show("1. Hay que introducir un excel.xls con las Papeletas vendidas \n\n" + "2. Debe haber más Papeletas vendidas que Número de Premios");
                    break;
                }
            }
        }

       
        private void button_loadExcel_Click(object sender, EventArgs e) //Carga de la hoja especificada del archivo xls
        {
            
            string PathCpnn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textBox_path.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(PathCpnn);

            if (textBox_sheet.Text == "")
            {
                textBox_sheet.Text = "Hoja1";
                MessageBox.Show("Nombre de la hoja predeterminado: Hoja1");
            }
            
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter("Select * from [" + textBox_sheet.Text + "$]", conn);
            DataTable dt = new DataTable();            
            
            myDataAdapter.Fill(dt);
            dataGridView1.AllowUserToAddRows = false;//eliminamos la ultima fila del datagridview que se autoagrega   

            dataGridView1.DataSource = dt;

            //Se crea una lista (papeletasVendidasList(double)) con los valores del dataGridView1          
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells["Papeletas Vendidas"].Value == System.DBNull.Value) break; //La columna debe tener el mismo nombre que en el Excel   
                if (row.Cells != null) //Si el valor de la celda no es null
                {
                    double myPapeleta = new double();
                    myPapeleta = (double)row.Cells["Papeletas Vendidas"].Value;
                    papeletasVendidasList.Add(myPapeleta);
                    //MessageBox.Show(myPapeleta + "se ha agregado una papeleta a la papeletasVendidasList");
                }
                else
                {
                    break;
                }
                papeletasVendidasCounter();
            }
            MessageBox.Show("Papeletas vendidas: " + dataGridView1.RowCount.ToString()); 
        }


        private void papeletasVendidasCounter()
        {
            int papeletasVendidasTotal = 0; 
            int counter;

            // Iterate through all the rows and sum up the appropriate columns.
            for (counter = 0; counter < (dataGridView1.Rows.Count);
                counter++)
            {
                if (dataGridView1.Rows[counter].Cells["Papeletas Vendidas"].Value
                    != null)
                {
                    if (dataGridView1.Rows[counter].
                        Cells["Papeletas Vendidas"].Value.ToString().Length != 0)
                    {
                        papeletasVendidasTotal += int.Parse(dataGridView1.Rows[counter].
                            Cells["Papeletas Vendidas"].Value.ToString());
                    }
                }                
            }
            // Set the labels to reflect the current state of the DataGridView.
            //MessageBox.Show("Papeletas vendidas: " + dataGridView1.RowCount.ToString());                      
        }





        private void button_exportExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application(); // Crea un objeto Excel.
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                for (int i = -1; i < dataGridView1.Rows.Count - 1; i++) //Loop a traves de cada fila leyendo sus valores 
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1) // El indice de Excel empieza por 1,1. Siendo los headers de columna, añadiendo un condition check. 
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView2.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveDialog = new SaveFileDialog(); //Localizacion y nombre de achivo se piden para que lo guarde el usuario. 
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

        private void button_exportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 0;

            string fileName = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK) //Localizacion y nombre de achivo se piden para que lo guarde el usuario. 
            {
                fileName = dlg.FileName;

                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                PdfPTable table = new PdfPTable(dataGridView2.Columns.Count);

                doc.Open(); //Open Document to Write             

                for (int j = 0; j < dataGridView2.Columns.Count; j++) //Add the headers
                {
                    table.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));
                }

                table.HeaderRows = 1; //Flag the first row as a header

                for (int i = 0; i < dataGridView2.Rows.Count; i++) //Add the actual rows from th DGV to the table
                {
                    for (int k = 0; k < dataGridView2.Columns.Count; k++)
                    {
                        if (dataGridView2[k, i].Value != null)
                        {
                            table.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
                        }
                    }
                }
                doc.Add(table); //Add out table
                doc.Close(); //Close document
                MessageBox.Show("Exportado a PDF!");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Quiere salir de la Rifa?",
                                    "Confirmar",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }

        private void button_chooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openFileDialog1.FileName;
            }
            if (textBox_path.Text == "ExcelFile.xls")
            {
                MessageBox.Show("Tienes que introducir el archivo excel.xls");
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

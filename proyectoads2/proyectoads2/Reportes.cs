using proyectoads2.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using Application = System.Windows.Forms.Application;

namespace proyectoads2
{
    public partial class Reportes : Form
    {
        private String dir = Application.StartupPath.ToString() + "";
        public Reportes()
        {
            InitializeComponent();            
            Consultas consulta = new Consultas();
            consulta.VerInventario(DGVInventario);
            consulta.Restantes(DGVRestantes);
            //this.panel4.BackgroundImage = Properties.Resources.escudo_de_el_salvador;
            int cont = 0, val = 0;
            String dd = "", dado ="";
            for (int i = dir.Length - 1; i >= 0; i--)
            {
                dado = Convert.ToString(dir[i]);                
                if (dado == "\\")
                {
                    cont++;
                    if (cont == 2)
                    {
                        val = i;
                        break;
                    }
                }                 
            }
            for (int i = 0; i < dir.Length; i++)
            {
                if (i <= val)
                {
                    dd = dd + dir[i].ToString();
                }
            }            
            dir = dd + "\\Resources\\logo inrit.jpg";            
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Excel {*.xlsx}|*.xlsx";
                save.Title = "Guardar Reporte";                
                save.FileName = "Exportacion Reporte-" + DateTime.Now.ToString().Replace(":", "-").Replace("/", "-");
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook libro = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel.Worksheet hoja = null;
                    hoja = libro.Sheets["Hoja1"];
                    hoja = libro.ActiveSheet;
                    hoja.Name = "Hoja1";
                    int columna = 0;
                    foreach (DataGridViewColumn col in DGVRestantes.Columns)
                    {
                        columna++;
                        app.Cells[1, columna] = col.Name;
                    }
                    int fila = 0;
                    foreach (DataGridViewRow row in DGVRestantes.Rows)
                    {
                        fila++;
                        columna = 0;
                        foreach (DataGridViewColumn col in DGVRestantes.Columns)
                        {
                            columna++;
                            app.Cells[fila + 1, columna] = row.Cells[col.Name].Value;
                        }
                    }                    
                    fila = fila + 3;
                    columna = 0;
                    foreach (DataGridViewColumn col in DGVInventario.Columns)
                    {
                        columna++;
                        app.Cells[fila, columna] = col.Name;
                    }
                    fila = fila - 1;
                    foreach (DataGridViewRow row in DGVInventario.Rows)
                    {
                        fila++;
                        columna = 0;
                        foreach (DataGridViewColumn col in DGVInventario.Columns)
                        {
                            columna++;
                            app.Cells[fila + 1, columna] = row.Cells[col.Name].Value;
                        }
                    }

                    libro.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    //libro.Close();
                    app.Quit();
                    MessageBox.Show("Archivo Excel generado !!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        private void BtnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf";
                save.Title = "Guardar Reporte";
                //save.FileName = "Exportar con pregunta-" + DateTime.Now.Date.ToShortDateString().Replace("/", "-");
                save.FileName = "Exportacion Reporte-" + DateTime.Now.ToString().Replace(":", "-").Replace("/", "-");
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (save.FileName.Length > 0)
                    {
                        FileStream file = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                        Document doc = new Document(PageSize.LETTER, 10, 10, 10, 10);
                        PdfWriter.GetInstance(doc, file);
                        doc.Open();
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph(" "));
                        //
                        iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(dir);
                        jpg.ScaleToFit(140f, 120f);
                        //Give space before image
                        jpg.SpacingBefore = 10f;
                        //Give some space after the image
                        jpg.SpacingAfter = 1f;
                        jpg.Alignment = Element.ALIGN_LEFT;
                        doc.Add(jpg);
                        //doc.Add--->Imagen
                        Chunk chunk = new Chunk("Reporte de Inventario", FontFactory.GetFont("ARIAL", 18, iTextSharp.text.Font.BOLD));
                        doc.Add(new Paragraph(chunk));
                        doc.Add(new Paragraph(" "));
                        chunk = new Chunk("                                     Instituto Nacional República de Italia", FontFactory.GetFont("ARIAL", 16, iTextSharp.text.Font.BOLD));
                        doc.Add(new Paragraph(chunk));
                        doc.Add(new Paragraph(" "));
                        chunk = new Chunk("\t\tAlimentos Restantes", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
                        doc.Add(new Paragraph(chunk));
                        doc.Add(new Paragraph(" "));
                        AddDatos(doc, DGVRestantes);
                        doc.Add(new Paragraph(" "));
                        chunk = new Chunk("\t\tAlimentos Restantes a Detalle", FontFactory.GetFont("ARIAL", 14, iTextSharp.text.Font.BOLD));
                        doc.Add(new Paragraph(chunk));
                        doc.Add(new Paragraph(" "));
                        AddDatos(doc, DGVInventario);
                        doc.Close();
                        MessageBox.Show("Archivo PDF generado !!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Process.Start(save.FileName);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        private void AddDatos(Document doc, DataGridView DGV)
        {
            PdfPTable datatable = new PdfPTable(DGV.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] header = Gettacolumnas(DGV);
            datatable.SetWidths(header);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
            for (int i = 0; i < DGV.Columns.Count; i++)
            {
                datatable.AddCell(DGV.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            for (int i = 0; i < DGV.Rows.Count; i++)
            {
                for (int j = 0; j < DGV.Columns.Count; j++)
                {
                    if (DGV[j, i].Value != null)
                    {
                        datatable.AddCell(new Phrase(DGV[j, i].Value.ToString()));
                    }
                    else
                    {
                        datatable.AddCell(new Phrase(""));
                    }

                }
                datatable.CompleteRow();
            }
            doc.Add(datatable);
        }
        private float[] Gettacolumnas(DataGridView dgv)
        {
            float[] values = new float[dgv.ColumnCount];
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                values[i] = (float)dgv.Columns[i].Width;
            }
            return values;
        }
    }
}

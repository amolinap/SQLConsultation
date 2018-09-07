using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DataBaseNet;

namespace SQLConsultation
{
    public partial class MainWindow : Form
    {
        DBSQLServer sqlServer;

        public MainWindow()
        {
            InitializeComponent();

            Text = "SQLConsultation v2.0 - Framework " + typeof(string).Assembly.ImageRuntimeVersion;
        }

        private void btEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                gvSQLResult.DataSource = sqlServer.EjecutarConsulta(tbSQLCommand.Text).Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                try
                {
                    gvSQLResult.DataSource = sqlServer.EjecutarConsulta(tbSQLCommand.Text).Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            gvSQLResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        public static void exportToExcel(DataSet source, string fileName)
        {
            System.IO.StreamWriter excelDoc;

            excelDoc = new System.IO.StreamWriter(fileName);
            const string startExcelXML = "<?xml version='1.0'?>\r\n<Workbook " +
                  "xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\"\r\n" +
                  " xmlns:o=\"urn:schemas-microsoft-com:office:office\"\r\n " +
                  "xmlns:x=\"urn:schemas-    microsoft-com:office:" +
                  "excel\"\r\n xmlns:ss=\"urn:schemas-microsoft-com:" +
                  "office:spreadsheet\">\r\n <Styles>\r\n " +
                  "<Style ss:ID=\"Default\" ss:Name=\"Normal\">\r\n " +
                  "<Alignment ss:Vertical=\"Bottom\"/>\r\n <Borders/>" +
                  "\r\n <Font/>\r\n <Interior/>\r\n <NumberFormat/>" +
                  "\r\n <Protection/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"BoldColumn\">\r\n <Font " +
                  "x:Family=\"Swiss\" ss:Bold=\"1\"/>\r\n </Style>\r\n " +
                  "<Style     ss:ID=\"StringLiteral\">\r\n <NumberFormat" +
                  " ss:Format=\"@\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"Decimal\">\r\n <NumberFormat " +
                  "ss:Format=\"0.0000\"/>\r\n </Style>\r\n " +
                  "<Style ss:ID=\"Integer\">\r\n <NumberFormat " +
                  "ss:Format=\"0\"/>\r\n </Style>\r\n <Style " +
                  "ss:ID=\"DateLiteral\">\r\n <NumberFormat " +
                  "ss:Format=\"mm/dd/yyyy;@\"/>\r\n </Style>\r\n " +
                  "</Styles>\r\n ";
            const string endExcelXML = "</Workbook>";

            int rowCount = 0;
            int sheetCount = 1;

            excelDoc.Write(startExcelXML);
            excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
            excelDoc.Write("<Table>");
            excelDoc.Write("<Row>");
            for (int x = 0; x < source.Tables[0].Columns.Count; x++)
            {
                excelDoc.Write("<Cell ss:StyleID=\"BoldColumn\"><Data ss:Type=\"String\">");
                excelDoc.Write(source.Tables[0].Columns[x].ColumnName);
                excelDoc.Write("</Data></Cell>");
            }
            excelDoc.Write("</Row>");
            foreach (DataRow x in source.Tables[0].Rows)
            {
                rowCount++;
                //if the number of rows is > 64000 create a new page to continue output
                if (rowCount == 64000)
                {
                    rowCount = 0;
                    sheetCount++;
                    excelDoc.Write("</Table>");
                    excelDoc.Write(" </Worksheet>");
                    excelDoc.Write("<Worksheet ss:Name=\"Sheet" + sheetCount + "\">");
                    excelDoc.Write("<Table>");
                }
                excelDoc.Write("<Row>"); //ID=" + rowCount + "
                for (int y = 0; y < source.Tables[0].Columns.Count; y++)
                {
                    System.Type rowType;
                    rowType = x[y].GetType();
                    switch (rowType.ToString())
                    {
                        case "System.String":
                            string XMLstring = x[y].ToString();
                            XMLstring = XMLstring.Trim();
                            XMLstring = XMLstring.Replace("&", "&");
                            XMLstring = XMLstring.Replace(">", ">");
                            XMLstring = XMLstring.Replace("<", "<");
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                           "<Data ss:Type=\"String\">");
                            excelDoc.Write(XMLstring);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DateTime":
                            //Excel has a specific Date Format of YYYY-MM-DD followed by  
                            //the letter 'T' then hh:mm:sss.lll Example 2005-01-31T24:01:21.000
                            //The Following Code puts the date stored in XMLDate 
                            //to the format above
                            DateTime XMLDate = (DateTime)x[y];
                            string XMLDatetoString = ""; //Excel Converted Date
                            XMLDatetoString = XMLDate.Year.ToString() +
                                 "-" +
                                 (XMLDate.Month < 10 ? "0" +
                                 XMLDate.Month.ToString() : XMLDate.Month.ToString()) +
                                 "-" +
                                 (XMLDate.Day < 10 ? "0" +
                                 XMLDate.Day.ToString() : XMLDate.Day.ToString()) +
                                 "T" +
                                 (XMLDate.Hour < 10 ? "0" +
                                 XMLDate.Hour.ToString() : XMLDate.Hour.ToString()) +
                                 ":" +
                                 (XMLDate.Minute < 10 ? "0" +
                                 XMLDate.Minute.ToString() : XMLDate.Minute.ToString()) +
                                 ":" +
                                 (XMLDate.Second < 10 ? "0" +
                                 XMLDate.Second.ToString() : XMLDate.Second.ToString()) +
                                 ".000";
                            excelDoc.Write("<Cell ss:StyleID=\"DateLiteral\">" +
                                         "<Data ss:Type=\"DateTime\">");
                            excelDoc.Write(XMLDatetoString);
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Boolean":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                        "<Data ss:Type=\"String\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Int16":
                        case "System.Int32":
                        case "System.Int64":
                        case "System.Byte":
                            excelDoc.Write("<Cell ss:StyleID=\"Integer\">" +
                                    "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.Decimal":
                        case "System.Double":
                            excelDoc.Write("<Cell ss:StyleID=\"Decimal\">" +
                                  "<Data ss:Type=\"Number\">");
                            excelDoc.Write(x[y].ToString());
                            excelDoc.Write("</Data></Cell>");
                            break;
                        case "System.DBNull":
                            excelDoc.Write("<Cell ss:StyleID=\"StringLiteral\">" +
                                  "<Data ss:Type=\"String\">");
                            excelDoc.Write("");
                            excelDoc.Write("</Data></Cell>");
                            break;
                        default:
                            throw (new Exception(rowType.ToString() + " not handled."));
                    }
                }
                excelDoc.Write("</Row>");
            }
            excelDoc.Write("</Table>");
            excelDoc.Write(" </Worksheet>");
            excelDoc.Write(endExcelXML);
            excelDoc.Close();
        }

        private void btConnectDB_Click(object sender, EventArgs e)
        {
            AccessDB accessDB = new AccessDB();
            accessDB.ShowDialog();

            if (AccessDB.isReady)
            {
                lbConnection.Text = AccessDB.lbConnection;
                sqlServer = new DBSQLServer(lbConnection.Text);

                gvTables.DataSource = sqlServer.EjecutarConsulta("Select name as Tables From sysobjects Where type = 'U'").Tables[0].DefaultView;
            }
        }

        private void btTables_Click(object sender, EventArgs e)
        {
            gvTables.DataSource = sqlServer.EjecutarConsulta("Select name as Tables From sysobjects Where type = 'U'").Tables[0].DefaultView;
        }

        private void btSaveXML_Click(object sender, EventArgs e)
        {
            if (tbSQLCommand.Text != "")
            {
                exportToExcel(sqlServer.EjecutarConsulta(tbSQLCommand.Text), "C:\\Reportes\\Reporte.xml");
            }
        }
    }
}
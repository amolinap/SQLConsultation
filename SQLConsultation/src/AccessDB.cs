using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConsultation
{
    public partial class AccessDB : Form
    {
        public static string lbConnection;

        public AccessDB()
        {
            InitializeComponent();

            /*DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();

            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dr.Table.Columns.Count; i++)
                {
                    Console.WriteLine(dr[i]);
                }

                cbInstance.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            }*/
        }

        private string[] instanciasInstaladas()
        {
            Microsoft.Win32.RegistryKey RKey;
            RKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
            string[] instancias;
            instancias = ((string[])RKey.GetValue("InstalledInstances"));
            return instancias;
        }

        private void AccessDB_Load(object sender, EventArgs e)
        {
            gbUser.Enabled = false;
        }

        private void cxUser_CheckedChanged(object sender, EventArgs e)
        {
            if (cxUser.Checked)
            {
                gbUser.Enabled = true;
            }
            else
            {
                gbUser.Enabled = false;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string sCnn;
        private String[] basesDeDatos(string instancia)
        {
            // Las bases de datos propias de SQL Server
            string[] basesSys = { "master", "model", "msdb", "tempdb" };
            string[] bases;
            DataTable dt = new DataTable();

            // Usamos la seguridad integrada de Windows

            if (cxUser.Checked)
            {
                sCnn = "Server=" + instancia + "; database=master; integrated security=false; User Id=" + tbUser.Text + "; Password=" + tbPassword.Text;
            }
            else
            {
                sCnn = "Server=" + instancia + "; database=master; integrated security=yes";
            }

            // La orden T-SQL para recuperar las bases de master
            string sel = "SELECT name FROM sysdatabases";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sel, sCnn);
                da.Fill(dt);
                bases = new string[dt.Rows.Count - 1];
                int k = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["name"].ToString();
                    // Solo asignar las bases que no son del sistema
                    if (Array.IndexOf(basesSys, s) == -1)
                    {
                        k += 1;
                        bases[k] = s;
                    }
                }
                if (k == -1) return null;
                // ReDim Preserve
                {
                    int i1_RPbases = bases.Length;
                    string[] copiaDe_bases = new string[i1_RPbases];
                    Array.Copy(bases, copiaDe_bases, i1_RPbases);
                    bases = new string[(k + 1)];
                    Array.Copy(copiaDe_bases, bases, (k + 1));
                };
                return bases;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al recuperar las bases de la instancia indicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void cbInstance_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] database;
            instance = cbInstance.SelectedItem.ToString();
            database = basesDeDatos(tbServer.Text + "\\" + instance);

            foreach (string db in database)
            {
                cbDataBase.Items.Add(db);
            }
        }

        private void cbDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cxUser.Checked)
            {
                lbConnection = "Data Source=" + tbServer.Text + "\\" + instance + "; Initial Catalog=" + cbDataBase.SelectedItem.ToString() + "; integrated security=false; User Id=" + tbUser.Text + "; Password=" + tbPassword.Text;
            }
            else
            {
                lbConnection = "Data Source=" + tbServer.Text + "\\" + instance + "; Initial Catalog=" + cbDataBase.SelectedItem.ToString() + "; integrated security=yes";
            }
        }

        private void tbServer_Leave(object sender, EventArgs e)
        {
            if (tbServer.Text == "localhost" || tbServer.Text == "127.0.0.1")
            {
                cbInstance.DropDownStyle = ComboBoxStyle.DropDownList;

                string[] instancias;
                instancias = instanciasInstaladas();

                foreach (string s in instancias)
                {
                    if (s == "MSSQLSERVER")
                    {
                        cbInstance.Items.Add("192.168.66.153");
                    }
                    else
                    {
                        cbInstance.Items.Add(s);
                        //comboBox1.Items.Add(@"127.0.0.1\" + s);
                    }
                }
                cbInstance.Text = "(local)";
            }
            else
            {
                cbInstance.DropDownStyle = ComboBoxStyle.Simple;
            }
        }

        string instance;
        private void cbInstance_Leave(object sender, EventArgs e)
        {
            if (cbInstance.DropDownStyle == ComboBoxStyle.Simple)
            {
                string[] database;
                instance = cbInstance.Text;
                database = basesDeDatos(tbServer.Text + "\\" + instance);

                foreach (string db in database)
                {
                    cbDataBase.Items.Add(db);
                }
            }
        }
    }
}

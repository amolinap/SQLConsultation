using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public class DataBase
{
    private SqlConnection conex;
    SqlCommand cmm = new SqlCommand();

    public double recibo;
    public double cambio;

    public DataBase()
    {
    }

    public SqlConnection cadenaConexion()
    {
        conex = new SqlConnection("Data Source=(local)\\DBEXPRESS; Initial Catalog=dbnoticias; integrated security=false; User Id=sa; Password=development;");
        return conex;
    }

    public void openConexion()
    {
        conex.Open();
    }

    public void closeConexion()
    {
        conex.Close();
    }

    public DataSet ejecutarConsulta(string sql)
    {
        cmm.Connection = cadenaConexion();
        cmm.CommandText = sql;

        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmm;

        DataSet ds = new DataSet();
        da.Fill(ds);

        openConexion();
        cmm.ExecuteNonQuery();
        closeConexion();

        return ds;
    }
}

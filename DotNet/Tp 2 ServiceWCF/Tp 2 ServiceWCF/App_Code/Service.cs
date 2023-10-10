using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IService
{
	public string Meteo_GetTemperature() 
	{
		String connectionstring = "Server=srv-sql;Database=StationMeteo;User Id=UserMeteo;Password=MeteoUser";
		String command = "SELECT * FROM [T_Data] WHERE [DateReleve] = (SELECT MAX([DateReleve]) FROM [T_Data])";
        SqlConnection connection = new SqlConnection(connectionstring);
		String s = null;

        try
		{
            connection.Open();
        }
		catch (Exception)
		{
			return null;
		}
		SqlCommand cmd = connection.CreateCommand();
		cmd.CommandText = command;
		try
		{
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            s = reader.GetDouble(reader.GetOrdinal("Temp")).ToString();
        }
		catch (Exception)
		{
            
        }
		connection.Close();
		return s;
	}

	public string Meteo_GetTemperatureByDate(string date, out string dateExact)
	{
        String connetionstring = "Server=srv-sql;Database=StationMeteo;User Id=UserMeteo;Password=MeteoUser";
        String command = "SELECT * FROM [T_Data] WHERE [DateReleve] = (SELECT MAX([DateReleve]) FROM [T_Data] WHERE DateReleve < '" + date + "')";
        SqlConnection connection = new SqlConnection(connetionstring);
        String reponse = null;
		dateExact = null;

        try
        {
            connection.Open();
        }
        catch (Exception)
        {
			return reponse;
        }

        SqlCommand cmd = connection.CreateCommand();
        cmd.CommandText = command;
        try
        {
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            reponse = reader.GetDouble(reader.GetOrdinal("Temp")).ToString();
			dateExact = reader.GetValue(reader.GetOrdinal("DateReleveVC")).ToString() ;
        }
        catch (Exception)
        {

        }
		connection.Close();
        return reponse;
    }

    public DataSet Meteo_GetTemperatureDay(string date)
    {
        String connetionstring = "Server=srv-sql;Database=StationMeteo;User Id=UserMeteo;Password=MeteoUser";
        String command = " SELECT * FROM [T_Data] WHERE [DateReleve] > '" + date + "' AND [DateReleve] < DateAdd(d, 1, '" + date + "')";
        SqlConnection connection = new SqlConnection(connetionstring);

        SqlDataAdapter da = new SqlDataAdapter();
        
        DataSet reponse = new DataSet();

        try
        {
            connection.Open();
        }
        catch (Exception)
        {
            return reponse;
        }

        SqlCommand cmd = new SqlCommand(command, connection);
        da.SelectCommand = cmd;
        
        try
        {
            da.Fill(reponse);
        }
        catch (Exception)
        {

        }
        
        connection.Close();
        return reponse;
    }
	
}

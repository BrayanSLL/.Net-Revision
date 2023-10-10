using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWeb_Click(object sender, EventArgs e)
        {
            WSMeteo.meteo3ilSoapClient service = new WSMeteo.meteo3ilSoapClient("meteo3ilSoap");
            String date, desc;
            string Temp = service.Get_Value(1, out date, out desc);
            textBoxWeb.Text = "Temperature actuelle : " + Temp + " °C" + System.Environment.NewLine + "Mesuré à " + date;

        }

        private void buttonWCF_Click(object sender, EventArgs e)
        {
            WCFMeteo.Service1Client service = new WCFMeteo.Service1Client();
            WCFMeteo.MeteoData data = service.Get_MeteoData();
            textBoxWCF.Text = "Pression = " + data.d_Pres + " Pa" + System.Environment.NewLine
                              + "Temp = " + data.d_Temp + " °C" + System.Environment.NewLine 
                              + "Hum = " + data.i_Hum + " %" + System.Environment.NewLine
                              + "Precipitation Jour = " + data.d_PrecJour + " mm"+ System.Environment.NewLine
                              + "Relevé à : " + data.dt_Releve;
        }

        private void buttonRest_Click(object sender, EventArgs e)
        {
            string url = "http://www.meteorestservice.lab3il.fr/ServiceRest.svc/meteo/1";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            WebResponse reponse = (WebResponse)request.GetResponse();
            
            StreamReader reader = new StreamReader(reponse.GetResponseStream());
            string data = reader.ReadToEnd();
            data = data.Substring(data.IndexOf(">") + 1, data.Length - data.IndexOf(">") - 1);
            data = data.Substring(0, data.IndexOf("<"));

            textBoxRest.Text = "Température actuelle : " + data + " °C";

        }

        private void buttonWCFM_Click(object sender, EventArgs e)
        {
            WCFMMeteo.ServiceClient service = new WCFMMeteo.ServiceClient();
            String temp = null;
            try
            {
                temp = service.Meteo_GetTemperature();
            }
            catch (Exception)
            {}

            textBoxWCFM.Text = "Température actuelle : " + temp + " °C";

        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            WCFMMeteo.ServiceClient service = new WCFMMeteo.ServiceClient();
            String temp = null;
            String date = null;
            try
            {
                temp = service.Meteo_GetTemperatureByDate(dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm") , out date) ;
            }
            catch (Exception)
            { }

            textBoxWCFMDate.Text = "Température relevé le " + date + " : " + temp + " °C";

        }

        private void buttonWCFD_Click(object sender, EventArgs e)
        {
            WCFMMeteo.ServiceClient service = new WCFMMeteo.ServiceClient();

            DataSet data = new DataSet();

            try
            {
                data = service.Meteo_GetTemperatureDay(dateTimePicker2.Value.ToString("dd/MM/yyyy hh:mm"));
            }
            catch (Exception)
            { }

            chart1.DataSource = data.Tables[0];

            chart1.Series.Clear();

            chart1.Series.Add("Temp");
            chart1.Series["Temp"].XValueMember = "DateReleveVC";
            chart1.Series["Temp"].YValueMembers = "Temp";
            chart1.Series["Temp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["Temp"].LegendText = "Temperature";

            chart1.Series.Add("TempR");
            chart1.Series["TempR"].XValueMember = "DateReleveVC";
            chart1.Series["TempR"].YValueMembers = "TempR";
            chart1.Series["TempR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["TempR"].LegendText = "Temperature ressentie";

            chart1.Series.Add("TempPR");
            chart1.Series["TempPR"].XValueMember = "DateReleveVC";
            chart1.Series["TempPR"].YValueMembers = "TempPR";
            chart1.Series["TempPR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["TempPR"].LegendText = "Temperature Point de rosée";

            chart1.DataBind();
            chart1.Visible = true;




        }
    }
}

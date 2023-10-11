using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; //Ajout de la référence System.Net
using System.IO; //Ajout de la référence System.IO


namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WSMeteo.meteo3ilSoapClient service = new WSMeteo.meteo3ilSoapClient("meteo3ilSoap"); //Instanciation du service
            String sDate =""; //Déclaration des variables
            String sDesc =""; //Déclaration des variables
            String sTemp =  service.Get_Value(1, out sDate, out sDesc); //Appel de la méthode Get_Value
            textBox1.Text = "Temperature : " + sTemp+"°C "; //Affichage de la température
            textBox1.Text += "\r\nDate : " + sDate; //Affichage de la date 
            textBox1.Text += "\r\nDescription : " + sDesc; //Affichage de la description

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WCFMeteo.Service1Client sr = new WCFMeteo.Service1Client(); //Instanciation du service
            WCFMeteo.MeteoData md = sr.Get_MeteoData(); //Appel de la méthode GetMeteoData
            textBox2.Text = "Temperature : " + md.d_Temp.ToString() + "°C "; //Affichage de la température
            textBox2.Text += "\r\nDate : " + md.d_Pres.ToString(); //Affichage de la date
            textBox2.Text += "\r\nDescription : " + md.i_Hum.ToString(); //Affichage de la description
            textBox2.Text +="\r\nMesurée le : " + md.dt_Releve.ToString("dd/MM/yyyy à hh:mm"); //Affichage de la date de relevé
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String sUrl = "http://www.meteorestservice.lab3il.fr/ServiceRest.svc/meteo/2"; //Déclaration de l'URL
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sUrl); //Création de la requête
            request.Method = WebRequestMethods.Http.Get; //Méthode GET
            WebResponse wr = request.GetResponse(); //Envoi de la requête
            StreamReader sr = new StreamReader(wr.GetResponseStream()); //Lecture de la réponse
            String str = sr.ReadToEnd(); //Stockage de la réponse dans une variable
            str = str.Substring(str.IndexOf(">") + 1, str.Length - str.IndexOf(">") - 1); //Récupération de la température
            str = str.Substring(0, str.IndexOf("<")); //Récupération de la température
            textBox3.Text = "Temperature : " + str + "°C "; //Affichage de la température

        }
    }
}

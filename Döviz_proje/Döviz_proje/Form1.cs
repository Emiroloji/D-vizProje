using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace Döviz_proje
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        
        public Form1()
        {
            conn = new SqlConnection("Data Source=EMIRPC;Initial Catalog=DovizProje;Integrated Security=True");
            InitializeComponent();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            

            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlFıle = new XmlDocument();
            xmlFıle.Load(today);

            //burada dolar satışı ve euroyu xml den çekiyorum  ve labele yazdırıyorum.
            string usdSelling = xmlFıle.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/ForexSelling").InnerXml;
            tlUsd.Text = usdSelling;
            decimal usd = Convert.ToDecimal(usdSelling);

            string euSelling = xmlFıle.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/ForexSelling").InnerXml;
            tlEuro.Text = euSelling;

            //burada 1 tlyi dolara çeviriyom
            decimal usd_tl = decimal.Parse(usdSelling);
            usd_tl = (1 / usd_tl) * 10000;
            usdTl.Text = usd_tl.ToString();

            //burada 1 tlyi euroya çeviriyom
            decimal euro_tl = decimal.Parse(euSelling);
            euro_tl = (1 / euro_tl) * 10000;
            euroTl.Text = euro_tl.ToString();

            //burada 1euro kac usd onu hesaplayacaz
            decimal usd_euro = decimal.Parse(usdSelling);
            decimal euro_usd = decimal.Parse(euSelling);
            usd_euro = euro_usd / usd_euro;
            usdEuro.Text = usd_euro.ToString();

            //burada 1usd kaç eur hesaplıyorum
            decimal eur = decimal.Parse(euSelling);
            euro_usd = usd / eur;
            euroUsd.Text = euro_usd.ToString();


            string[] kurCiftleri = { "EUR-TL", "TL-EUR", "USD-TL", "TL-USD", "USD-EUR", "EUR-USD" };
            decimal[] degerler = { eur, euro_tl, usd, usd_tl, usd_euro, euro_usd }; // kur değer
            // Bugünün tarihi
            DateTime tarih = DateTime.Now.Date;

            string checkQuery = "SELECT COUNT(*) FROM DövizKurlari WHERE tarih = @tarih";
            SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
            checkCmd.Parameters.AddWithValue("@tarih", tarih);

            conn.Open();
            int rowCount = (int)checkCmd.ExecuteScalar();
            conn.Close();



            if (rowCount == 0)
            {
                var xmlFile = new XmlDocument();
                xmlFile.Load(today);

                // Kayıt işlemi burada yapılıyo
                conn.Open();
                string query = "INSERT INTO DövizKurlari (kur1, kur2, değer, tarih) VALUES (@kur1, @kur2, @deger, @tarih)";
                SqlCommand cmd = new SqlCommand(query, conn);

                // Değerleri dongu ile kaydediyorum

                for (int i = 0; i < kurCiftleri.Length; i++)
                {

                    string[] kurlar = kurCiftleri[i].Split('-');
                    cmd.Parameters.AddWithValue("@kur1", kurlar[0]);
                    cmd.Parameters.AddWithValue("@kur2", kurlar[1]);
                    cmd.Parameters.AddWithValue("@deger", degerler[i]);
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                }
                conn.Close();

            }
            CreateMonthlyChart();           
        }

        private void CreateMonthlyChart()
        {

            // Verileri almak için SQL sorgularınızı kullanın
            string queryUSD = "SELECT tarih, değer FROM DövizKurlari WHERE kur1 = 'USD' AND kur2 = 'TL' ORDER BY tarih";
            string queryEUR = "SELECT tarih, değer FROM DövizKurlari WHERE kur1 = 'EUR' AND kur2 = 'TL' ORDER BY tarih";

            // Verileri veritabanından alın
            DataTable dtUSD = new DataTable();
            DataTable dtEUR = new DataTable();

        
                conn.Open();

                SqlDataAdapter adapterUSD = new SqlDataAdapter(queryUSD, conn);
                adapterUSD.Fill(dtUSD);

                SqlDataAdapter adapterEUR = new SqlDataAdapter(queryEUR, conn);
                adapterEUR.Fill(dtEUR);

                conn.Close();
            

            

            // Serileri oluşturun
            chart.Series.Add("TL-USD");
            chart.Series.Add("TL-EUR");

            // TL-USD verilerini grafiğe ekleyin
            foreach (DataRow row in dtUSD.Rows)
            {
                DateTime tarih = (DateTime)row["tarih"];
                double deger = Convert.ToDouble(row["değer"]);
                chart.Series["TL-USD"].Points.AddXY(tarih.ToString("MMMM yyyy"), deger);
            }

            // TL-EUR verilerini grafiğe ekleyin
            foreach (DataRow row in dtEUR.Rows)
            {
                DateTime tarih = (DateTime)row["tarih"];
                double deger = Convert.ToDouble(row["değer"]);
                chart.Series["TL-EUR"].Points.AddXY(tarih.ToString("MMMM yyyy"), deger);
            }

            // Grafik özelliklerini ayarlayın
            chart.Titles.Add("Aylık Grafiği");
            chart.ChartAreas[0].AxisX.Title = "Aylar";
            chart.ChartAreas[0].AxisY.Title = "Değerler";

            // Grafiği görüntüleyin
            chart.Invalidate();
        }
    }
}



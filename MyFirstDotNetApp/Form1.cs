using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace MyFirstDotNetApp
{
    public partial class Form1 : Form
    {
        private string constring = @"Server=(localdb)\MSSQLLocalDB;Database=DenemeDb;TrustServerCertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private async void Ekle_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO Products (Id, Ad, OlusturmaZamani, SilinmeZamani, SilindiMi) VALUES (@Id, @Ad, @OlusturmaZamani, @SilinmeZamani, @SilindiMi)";

            //dbcon db = new dbcon(constring);

            //var parameters = new Dictionary<string, object>
            //{
            //    {"@Id", textBoxId.Text},
            //    {"@Ad", textBoxAd.Text},
            //    {"@OlusturmaZamani", textBoxOlusturmaZamani.Text},
            //    {"@SilinmeZamani", textBoxSilinmeZamani.Text},
            //    {"@SilindiMi", textBoxSilindiMi.Text}
            //};

            //if (db.UDI(query, parameters))
            //{
            //    textStatus.Text = "Ekleme başarılı.";
            //}
            //else
            //{
            //    textStatus.Text = "HATA!";
            //}

            Product product = new Product { Id = Convert.ToInt32(textBoxId.Text.ToString()), Ad = textBoxAd.Text, OlusturulmaZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilinmeZamani = DateTime.Parse(textBoxOlusturmaZamani.Text),SilindiMi= textBoxSilindiMi.Text == "true" ? true : false };
            string jsonData = JsonConvert.SerializeObject(product);
            string url = "https://localhost:44387/api/Products/add";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                textStatus.Text = response.ToString();   
            }
        }

        //private async Task Guncelle_Click(object sender, EventArgs e)
        //{
        //    //string query = "INSERT INTO Products (Id, Ad, OlusturmaZamani, SilinmeZamani, SilindiMi) VALUES (@Id, @Ad, @OlusturmaZamani, @SilinmeZamani, @SilindiMi)";

        //    //dbcon db = new dbcon(constring);

        //    //var parameters = new Dictionary<string, object>
        //    //{
        //    //    {"@Id", textBoxId.Text},
        //    //    {"@Ad", textBoxAd.Text},
        //    //    {"@OlusturmaZamani", textBoxOlusturmaZamani.Text},
        //    //    {"@SilinmeZamani", textBoxSilinmeZamani.Text},
        //    //    {"@SilindiMi", textBoxSilindiMi.Text}
        //    //};

        //    //if (db.UDI(query, parameters))
        //    //{
        //    //    textStatus.Text = "Güncelleme başarılı.";
        //    //}
        //    //else
        //    //{
        //    //    textStatus.Text = "HATA!";
        //    //}

        //    Product product = new Product { Id = Convert.ToInt32(textBoxId.Text.ToString()), Ad = textBoxAd.Text, OlusturulmaZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilinmeZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilindiMi = textBoxSilindiMi.Text == "true" ? true : false };
        //    string jsonData = JsonConvert.SerializeObject(product);
        //    string url = "https://localhost:44387/api/Products/update";
        //    using (HttpClient client = new HttpClient())
        //    {
        //        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //        HttpResponseMessage response = await client.PostAsync(url, content);
        //        textStatus.Text = response.ToString();
        //    }
        //}
        //private async Task Sil_Click(object sender, EventArgs e)
        //{
        //    //string query = "INSERT INTO Products (Id, Ad, OlusturmaZamani, SilinmeZamani, SilindiMi) VALUES (@Id, @Ad, @OlusturmaZamani, @SilinmeZamani, @SilindiMi)";

        //    //dbcon db = new dbcon(constring);

        //    //var parameters = new Dictionary<string, object>
        //    //{
        //    //    {"@Id", textBoxId.Text},
        //    //    {"@Ad", textBoxAd.Text},
        //    //    {"@OlusturmaZamani", textBoxOlusturmaZamani.Text},
        //    //    {"@SilinmeZamani", textBoxSilinmeZamani.Text},
        //    //    {"@SilindiMi", textBoxSilindiMi.Text}
        //    //};

        //    //if (db.UDI(query, parameters))
        //    //{
        //    //    textStatus.Text = "Silme başarılı.";
        //    //}
        //    //else
        //    //{
        //    //    textStatus.Text = "HATA!";
        //    //}

        //    Product product = new Product { Id = Convert.ToInt32(textBoxId.Text.ToString()), Ad = textBoxAd.Text, OlusturulmaZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilinmeZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilindiMi = textBoxSilindiMi.Text == "true" ? true : false };
        //    string jsonData = JsonConvert.SerializeObject(product);
        //    string url = "https://localhost:44387/api/Products/delete";
        //    using (HttpClient client = new HttpClient())
        //    {
        //        StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        //        HttpResponseMessage response = await client.PostAsync(url, content);
        //        textStatus.Text = response.ToString();
        //    }
        //}
        private void Listele_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Products (Id, Ad, OlusturmaZamani, SilinmeZamani, SilindiMi) VALUES (@Id, @Ad, @OlusturmaZamani, @SilinmeZamani, @SilindiMi)";

            dbcon db = new dbcon(constring);

            var parameters = new Dictionary<string, object>
            {
                {"@Id", textBoxId.Text},
                {"@Ad", textBoxAd.Text},
                {"@OlusturmaZamani", textBoxOlusturmaZamani.Text},
                {"@SilinmeZamani", textBoxSilinmeZamani.Text},
                {"@SilindiMi", textBoxSilindiMi.Text}
            };

            if (db.UDI(query, parameters))
            {
                textStatus.Text = "Listeleme başarılı.";
            }
            else
            {
                textStatus.Text = "HATA!";
            }
        }

        private async void Guncelle_Click(object sender, EventArgs e)
        {
            Product product = new Product { Id = Convert.ToInt32(textBoxId.Text.ToString()), Ad = textBoxAd.Text, OlusturulmaZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilinmeZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilindiMi = textBoxSilindiMi.Text == "true" ? true : false };
            string jsonData = JsonConvert.SerializeObject(product);
            string url = "https://localhost:44387/api/Products/update";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PutAsync(url, content);
                textStatus.Text = response.ToString();
            }
        }

        private async void Sil_Click(object sender, EventArgs e)
        {
            //Product product = new Product { Id = Convert.ToInt32(textBoxId.Text.ToString()), Ad = textBoxAd.Text, OlusturulmaZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilinmeZamani = DateTime.Parse(textBoxOlusturmaZamani.Text), SilindiMi = textBoxSilindiMi.Text == "true" ? true : false };
            //string jsonData = JsonConvert.SerializeObject(product);
            int productId = Convert.ToInt32(textBoxId.Text.ToString());


            string url = "https://localhost:44387/api/Products/delete/{productId}";
            using (HttpClient client = new HttpClient())
            {
                //StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.DeleteAsync(url);
                textStatus.Text = response.ToString();
            }
        }
    }
}

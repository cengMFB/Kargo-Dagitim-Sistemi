using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Net.Http;
using System.Collections;
using System.Net;
using System.IO;
using System.Threading;
using GMap.NET.MapProviders;
using GMap.NET;

namespace YazLab
{
 
    public partial class Form1 : Form
    {
        Form2 mapScene = new Form2();
        double lat;
        double lng;
        FirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "R28Rim9UK5cosD1GIDznhtbX0Y88zviOtWenuSQK",
            BasePath = "https://kargo-api-9bcd1-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        FirebaseResponse response;
        public Form1()
        {
            mapScene.Show();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

      
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB0PDFGI7SWZF6LfKEKUc0gjCj13ePAhr8";
            map2.DragButton = MouseButtons.Left;
            map2.MapProvider = GMapProviders.GoogleMap;
            map2.MinZoom = 1;
            map2.MaxZoom = 100;
            map2.Zoom = 13;
            map2.SetPositionByKeywords("İzmit,Turkey");
            map2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            dataGridView1.Visible = false;
        }
        private List<Users> users = new List<Users>();
        private async void giris_Click(object sender, EventArgs e)
        {
            // login();

            users = await ekleUsersAsync();
            if (users != null)
            {
                foreach (var u in users)
                {
                    if (u.Username.Equals(kullanıcı.Text))
                    {
                        if (u.Password.Equals(sifre.Text))
                        {
                            map2.Visible = true;
                            groupBox3.Visible = true;
                            groupBox4.Visible = true;
                            dataGridView1.Visible = true;
                            groupBox1.Visible = false;
                            groupBox2.Visible = false;
                            //MessageBox.Show("Giriş Başarılı..");
                        }

                        else
                        {
                            MessageBox.Show("Şifrenizi Kontrol Ediniz..");
                        }
                    }
                    else if (!u.Username.Equals(kullanıcı.Text))
                    {
                        if (u.Password.Equals(sifre.Text))
                        {
                            MessageBox.Show("Kullanıcı Adınızı Kontrol Ediniz..");
                        }
                    }
                    else if (!u.Username.Equals(kullanıcı.Text))
                    {
                        if (!u.Password.Equals(sifre.Text))
                        {
                            MessageBox.Show("Bilgileriniz Kontrol Ediniz..");
                        }

                    }
                    else if (u.Username.Equals("") && u.Password.Equals(""))
                    {
                        MessageBox.Show("Bilgilerinizi Doldurunuz..");

                    }
                    else
                    {
                        MessageBox.Show("Bilgileriniz Hatalı..");
                    }
                }
            }
        }

        private static async Task<List<Users>> ekleUsersAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            HttpResponseMessage response = await client.GetAsync("api/users");
            string result = await response.Content.ReadAsStringAsync();
            List<Users> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Users>>(result);
            return users;
        }
      

        private void button1_Click(object sender, EventArgs e) //üye ekleme
        {
            Users user2 = new Users()
            {

                Username = uyekullanici.Text,
                Password = uyesifre.Text

            };
            client = new FireSharp.FirebaseClient(config);

            response = client.Set("Users/" + uyekullanici.Text, user2);
            MessageBox.Show("Kaydedildi");

        }


        private void button2_Click(object sender, EventArgs e) //şifre güncelleme
        {
            Users user3 = new Users()
            {
                Username = upadatekullanici.Text,
                Password = updatesifre.Text

            };
            client = new FireSharp.FirebaseClient(config);
            response = client.Update("Users/" + upadatekullanici.Text, user3);
            MessageBox.Show("Şifre Güncellendi..");
            upadatekullanici.Text = string.Empty;
            updatesifre.Text = string.Empty;

        }
        List<Teslimat> teslimat2 = new List<Teslimat>();

        private async void kargoEkle_Click(object sender, EventArgs e)
        {



            Teslimat teslimat = new Teslimat()
            {
                MüsteriAd = müsteriAd.Text,
                MüsteriID = müsteriID.Text,
                Enlem = müsteriEnlem.Text,
                Boylam = müsteriBoylam.Text,
                KargoID = kargoID.Text


            };

            client = new FireSharp.FirebaseClient(config);
            response = client.Set("Teslimat Listesi/" + müsteriID.Text, teslimat);
            MessageBox.Show("Eklendi..");

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            teslimat2 = await ekleTeslimatAsync();

            foreach (var t in teslimat2)
            {

                dataGridView1.Rows.Add(
                   t.MüsteriID,
                   t.MüsteriAd,
                   t.Enlem,
                   t.Boylam,
                   t.KargoID
                    );

              
            }
            mapScene._points.Add(new PointLatLng(Convert.ToDouble(müsteriEnlem.Text), Convert.ToDouble(müsteriBoylam.Text)));

            lat = Convert.ToDouble(müsteriEnlem.Text);
            lng = Convert.ToDouble(müsteriBoylam.Text);

            var point = map2.FromLocalToLatLng((int)lat, (int)lng);

            point.Lat = lat;
            point.Lng = lng;




            Thread th5 = new Thread(yoluOlustur);
            th5.Start();
          
            
            mapScene.AddMarker(point);
           


        }
        public void yoluOlustur()
        {
            if (mapScene._points.Count > 0)
            {

                for (int i = 0; i < mapScene._points.Count - 1; i++)
                {
                    mapScene.yolCiz(i, i + 1);
                }
            }

        }

        private void kargoSil_Click(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);
            response = client.Delete("Teslimat Listesi/" + müsteriID.Text);
            MessageBox.Show("Silindi..");
            müsteriID.Text = string.Empty;
            müsteriAd.Text = string.Empty;
            müsteriEnlem.Text = string.Empty;
            kargoID.Text = string.Empty;
        }

        private static async Task<List<Teslimat>> ekleTeslimatAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44331/");
            HttpResponseMessage response = await client.GetAsync("api/kargoteslimat");
            string result = await response.Content.ReadAsStringAsync();
            List<Teslimat> teslimat = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Teslimat>>(result);
            return teslimat;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    
        private void map2_Load(object sender, EventArgs e)
        {

        }

        private void map2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = map2.FromLocalToLatLng(e.X, e.Y);
                lat = point.Lat;
                lng = point.Lng;

                müsteriEnlem.Text = lat + "";
                müsteriBoylam.Text = lng + "";

               
                mapScene.LoadMap(point);
                
                mapScene.AddMarker(point);
              

            }
        }
   
    }
}


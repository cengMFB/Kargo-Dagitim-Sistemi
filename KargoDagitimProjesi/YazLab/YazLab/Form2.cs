using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{        
   public partial class Form2 : Form
    {
      
        int control = 0;
        Teslimat teslimatSil = new Teslimat();
        public string enlem;
        public string boylam;

        public List<PointLatLng> _points;

        public Form2()
        {
             InitializeComponent();
            _points = new List<PointLatLng>();
        }


    
        public void yolCiz(int nokta1, int nokta2)
        {

            var route = GoogleMapProvider.Instance.GetRoute(_points[nokta1], _points[nokta2], false, false, 14);

            var r = new GMapRoute(route.Points, "My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };

            var routes = new GMapOverlay("routes");

            routes.Routes.Add(r);
            map.Overlays.Add(routes);

        
        

        }
       

        private void Form2_Load(object sender, EventArgs e)
        {

            GMapProviders.GoogleMap.ApiKey = @"AIzaSyB0PDFGI7SWZF6LfKEKUc0gjCj13ePAhr8";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 1;
            map.MaxZoom = 100;
            map.Zoom = 13;
            map.SetPositionByKeywords("İzmit,Turkey");

      }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && control == 0)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                textEnlem.Text = lat + "";
                textBoylam.Text = lng + "";

              
                LoadMap(point);
                
                control = 1;
               

                kuryeciAddMarker(point);
            }



        }

        public void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }


        GMapOverlay markers = new GMapOverlay("markers");
        public void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_dot)
        {

            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);

        }


        public void kuryeciAddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.blue_dot)
        {
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(pointToAdd, markerType);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }


        private void map_Load(object sender, EventArgs e)
        {

        }
 
      



        private void btnRemoveOverlay_Click_1(object sender, EventArgs e)
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt(map.Overlays.Count - 1);

                map.Refresh();


            }

        }

        private void btnAddPoint_Click_1(object sender, EventArgs e)
        {
            _points.Add(new PointLatLng(Convert.ToDouble(textEnlem.Text), Convert.ToDouble(textBoylam.Text)));
           
        }
        public void rotaOlustur()
        {
        
            if (_points.Count > 0)
            {

                for (int i = 0; i < _points.Count - 1; i++)
                {

                    yolCiz(i, i + 1);

                }
            }
        }
     

        private void btnClearList_Click_1(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnTeslimat_Click(object sender, EventArgs e)
        {   
            Thread th = new Thread(teslimatYap);
            th.Start();
        }
        public void teslimatYap()
        {
    
            while(map.Overlays.Count>0)
            {

                map.Refresh();
                map.Overlays.RemoveAt(0);    
                System.Threading.Thread.Sleep(1000);
                   

            }
          
        }

        private void textBoylam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

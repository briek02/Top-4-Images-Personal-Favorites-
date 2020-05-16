using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        List<string> strList = new List<string>();
        List<string> imageList = new List<string>();
        int number;
        bool onetime = true;
        public MainPage()
        {
            InitializeComponent();

            imageList.Add("corri.jpg");
            imageList.Add("ambpar.jpg");
            imageList.Add("colnei.jpg");
            imageList.Add("beautflow.jpg");

            strList.Add("Spooky Corridor");
            strList.Add("Ambassador Parlor Suite");
            strList.Add("Colorful Neighborhood");
            strList.Add("Beautiful Flowers");
            number = 0;
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            // theLabel.Text = e.Direction.ToString();
            if (e.Direction == SwipeDirection.Right)
            {

                if (number != 3)
                {
                    number = number + 1;
                    onetime = false;
                }

                if (onetime == true)
                {
                    if (number == 3)
                    {
                        number = 0;
                    }
                }
                onetime = true;

                theImage.Source = imageList[number];
                theLabel.Text = strList[number];
            }

            if (e.Direction == SwipeDirection.Left)
            {
                if (number != 0)
                {
                    number = number - 1;
                    onetime = false;
                }
                if (onetime == true)
                {
                    if (number == 0)
                    {
                        number = 3;
                    }
                }
                onetime = true;

                theImage.Source = imageList[number];
                theLabel.Text = strList[number];
            }
        }
    }
}

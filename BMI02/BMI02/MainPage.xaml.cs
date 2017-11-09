using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double h = double.Parse(Hight.Text) / 100;
            double w = double.Parse(Weight.Text);
            double bmi = 0.0;

            bmi = w / (h * h);

            if (bmi < 18.5)
            {
                DisplayAlert("BMI", "やせすぎ", "OK");
            }
            else if (bmi < 25.0)
            {
                DisplayAlert("BMI", "普通", "OK");
            }
            else
            {
                DisplayAlert("BMI", "太りすぎ", "OK");
            }
        }
    }
}

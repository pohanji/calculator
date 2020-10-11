using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calc2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            int number;
            var text = button.Text;

            var isNumber = Int32.TryParse(text, out number);
            if (isNumber)
            {
                if (area.Text == "0")
                    area.Text = text;
                else
                {
                    area.Text += text;
                }
            }
            else
            {
                if (text == "=")
                    area.Text = new DataTable().Compute(area.Text, null).ToString();
                else
                    area.Text += text;
            }
        }
    }
}

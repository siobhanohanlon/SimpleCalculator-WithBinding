using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SimpleCalculator
{
    public partial class MainPage : ContentPage
    {
        Calculate calc;

        public MainPage()
        {
            //Initialize
            InitializeComponent();

            //If calc is nothing
            if(calc == null)
            {
                calc = new Calculate();
            }

            //Binding
            this.BindingContext = calc;
        }

        private void EntArg1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Setting property when value changes
            calc.Arg1 = Convert.ToInt32(EntArg1.Text);
        }

        private void EntArg2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Setting property when value changes
            calc.Arg2 = Convert.ToInt32(EntArg2.Text);
        }

        private void BtnDoMaths_Clicked(object sender, EventArgs e)
        {
            LblAnswer.Text = (calc.Answer).ToString();
        }
    }
}

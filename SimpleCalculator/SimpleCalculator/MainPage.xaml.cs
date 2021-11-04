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

        private void BtnDoMaths_Clicked(object sender, EventArgs e)
        {
            calc.Arg1 = 27;
            calc.Arg2 = 15;
        }
    }
}

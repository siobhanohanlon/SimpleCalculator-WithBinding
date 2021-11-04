using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleCalculator
{
    //Need to implement the INotifyPropertyChanged Interface
    //Allows me to register interest in events that change
    //Attribute/Properties of elements on the UI
    class Calculate : INotifyPropertyChanged
    {
        //Create Property Changed
        public event PropertyChangedEventHandler PropertyChanged;

        //Variables
        private int arg1;
        private int arg2;

        //Entry 1
        public int Arg1
        {
            get { return arg1; }
            set 
            { 
                arg1 = value;
                if(PropertyChanged != null)
                {
                    //Generate a property changed event in the system
                    PropertyChanged(this, new PropertyChangedEventArgs("Answer"));

                    //If Args Set in Background
                    PropertyChanged(this, new PropertyChangedEventArgs("Arg1"));
                }
            }
        }

        //Entry 2
        public int Arg2
        {
            get { return arg2; }
            set 
            { 
                arg2 = value;
                if (PropertyChanged != null)
                {
                    //Generate a property changed event in the system
                    PropertyChanged(this, new PropertyChangedEventArgs("Answer"));

                    //If Args Set in Background
                    PropertyChanged(this, new PropertyChangedEventArgs("Arg2"));
                }
            }
        }

        //Read Only
        public int Answer
        {
            get { return arg1 + arg2; }
        }
    }
}

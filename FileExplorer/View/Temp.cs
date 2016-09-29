using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FileExplorer.View
{
    public class Temp : DependencyObject
    {
        public Temp()
        {

        }

        public static readonly DependencyProperty propertyBindPath = DependencyProperty.Register("BindPath", typeof(string), typeof(Temp));
        public string BindPath
        {
            get { return (string)GetValue(propertyBindPath); }
            set { SetValue(propertyBindPath, value); }
        }
        
    }
}

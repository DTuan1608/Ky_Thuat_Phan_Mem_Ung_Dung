using KTPMUD.Controllers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KTPMUD
{
    /// <summary>
}
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {   
        static public void Request(string url, params object[] args) => System.Mvc.Engine.Execute(url, args);
    }

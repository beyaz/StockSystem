using System;
using System.Reflection;
using System.Windows;
using StockSystem.Views.UserDefinition;
using WhiteStone.UI.Shell;

namespace StockSystem
{
    public class Startup : IApplicationStartup
    {
        public void Start()
        {
            Application.Current.MainWindow.Content = new Views.UserDefinition.View {Model = new Model()};
        }
    }
}
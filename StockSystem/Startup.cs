using System;
using System.Reflection;
using System.Windows;
using WhiteStone.UI.Shell;

namespace StockSystem
{
    public class Startup : IApplicationStartup
    {
        public void Start()
        {
            MessageBox.Show("Aloha");
        }
    }
}
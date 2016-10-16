using System.Windows;
using System.Windows.Controls;

namespace StockSystem.UIControls
{
    public class WTextBox : TextBox
    {
        public static readonly DependencyProperty wTextProperty = DependencyProperty.Register(
            "wText", typeof(string), typeof(WTextBox), new PropertyMetadata(default(string)));

        public string wText
        {
            get { return (string)GetValue(wTextProperty); }
            set { SetValue(wTextProperty, value); }
        }

        public static readonly DependencyProperty wLabelProperty = DependencyProperty.Register(
            "wLabel", typeof(string), typeof(WTextBox), new PropertyMetadata(default(string)));

        public string wLabel
        {
            get { return (string)GetValue(wLabelProperty); }
            set { SetValue(wLabelProperty, value); }
        }
    }
}
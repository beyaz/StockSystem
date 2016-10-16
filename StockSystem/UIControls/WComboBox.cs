using System.Windows;
using System.Windows.Controls;

namespace StockSystem.UIControls
{
    public class WComboBox : ComboBox
    {
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(
            "wItemSource", typeof(object), typeof(WComboBox), new PropertyMetadata(default(object)));

        public object wItemSource
        {
            get { return GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty wDisplayMemberPathProperty = DependencyProperty.Register(
            "wDisplayMemberPath", typeof(string), typeof(WComboBox), new PropertyMetadata(default(string)));

        public string wDisplayMemberPath
        {
            get { return (string)GetValue(wDisplayMemberPathProperty); }
            set { SetValue(wDisplayMemberPathProperty, value); }
        }

        public static readonly DependencyProperty wSelectedValuePathProperty = DependencyProperty.Register(
            "wSelectedValuePath", typeof(string), typeof(WComboBox), new PropertyMetadata(default(string)));

        public string wSelectedValuePath
        {
            get { return (string)GetValue(wSelectedValuePathProperty); }
            set { SetValue(wSelectedValuePathProperty, value); }
        }
    }
}
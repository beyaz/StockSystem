using System.Windows;

namespace StockSystem.Views.UserDefinition
{
    /// <summary>
    ///     Interaction logic for View.xaml
    /// </summary>
    public partial class View
    {
        public static readonly DependencyProperty ModelProperty = DependencyProperty.Register(
            "Model", typeof(Model), typeof(View), new PropertyMetadata(default(Model)));

        public Model Model
        {
            get { return (Model) GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }


        public View()
        {
            InitializeComponent();
        }

         void Button_Click(object sender, RoutedEventArgs e)
         {
             var controller = new Controller {Model = Model};
            controller.Validate();
             var result = controller.Result;
             if (!string.IsNullOrWhiteSpace(result.WarningMessage))
             {
                 MessageBox.Show(result.WarningMessage);
             }
         }
    }
}
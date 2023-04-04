
using Noesis;
using NoesisApp;


namespace NoesisWpfBasicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            GUI.LoadComponent(this, "NoesisWpfBasicApp.MainWindow.xaml");
        }
    }
}

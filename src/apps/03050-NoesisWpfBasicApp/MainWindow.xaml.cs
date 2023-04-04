
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
            this.Initialized += OnInitialized;
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            //GUI.LoadComponent(this, "NoesisWpfBasicApp.MainWindow.xaml");
            GUI.LoadComponent(this, "MainWindow.xaml");
        }

        private void OnInitialized(object sender, EventArgs args)
        {
            // this.DataContext = new ViewModel();
        }
    }
}

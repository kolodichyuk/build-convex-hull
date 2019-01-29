using System.Windows;
using System.Windows.Input;
using ConvexHull.Graham_sA;
using ConvexHull.Jarvis_sA;

namespace ConvexHull {
    public partial class MainWindow : Window {
        private Graham_sAlgorithm graham_sAlgorithm = new Graham_sAlgorithm();
        private Jarvis_sAlgorithm jarvis_sAlgorithm = new Jarvis_sAlgorithm();
        public MainWindow() {
            InitializeComponent();
        }

        #region System action
        private void ExitOfProgram(object sender, RoutedEventArgs e) {
            this.Close();
        }
        private void OpenMenu(object sender, RoutedEventArgs e) {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }
        private void CloseMenu(object sender, RoutedEventArgs e) {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        #endregion

        #region Panel navigation
        private void JAlgorithm(object sender, MouseButtonEventArgs e) {
            Main.Content = jarvis_sAlgorithm;
        }
        private void GAlgorithm(object sender, MouseButtonEventArgs e) {
            Main.Content = graham_sAlgorithm;
        }
        #endregion
    }
}

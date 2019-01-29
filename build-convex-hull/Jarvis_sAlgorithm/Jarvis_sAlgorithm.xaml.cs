using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;

namespace ConvexHull.Jarvis_sA {
    public partial class Jarvis_sAlgorithm : Page {
        private ViewModel viewModel = new ViewModel();
        public Jarvis_sAlgorithm() {
            InitializeComponent();
            DataContext = viewModel;
            CommandBindings.Add(new CommandBinding(ViewModel.CreateConvexHull, viewModel.ExecuteCreateConvexHull, viewModel.CanExecuteCreateConvexHull));
            CommandBindings.Add(new CommandBinding(ViewModel.ClearPoints, viewModel.ExecuteClearPoints, viewModel.CanExecuteClearPoints));
        }

        #region Paint actions
        private void CreatePoint(object sender, MouseButtonEventArgs e) {
            Point coords = e.GetPosition(ItemsControl);
            coords.X -= 10;
            coords.Y -= 10;
            viewModel.AddPoint(coords);
        }
        private void GridMouseDown(object sender, MouseButtonEventArgs e) {
            if (workSpace.Visibility != Visibility.Visible) {
                workSpace.Visibility = Visibility.Visible;
                initialMessage.Visibility = Visibility.Hidden;
            }
        }
        private void Clear(object sender, MouseButtonEventArgs e) {
            workSpace.Visibility = Visibility.Hidden;
            initialMessage.Visibility = Visibility.Visible;
        }
        #endregion
    }
}


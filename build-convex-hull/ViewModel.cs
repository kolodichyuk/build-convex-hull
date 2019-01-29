using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ConvexHull.Graham_sA;
using ConvexHull.Jarvis_sA;

namespace ConvexHull {
    public class ViewModel : INotifyPropertyChanged {
        #region Constants
        private const int MinConvexHullPointsCount = 3;
        private const int MinClearPointsCount = 1;
        #endregion

        #region Fields
        private ObservableCollection<Point> points;
        private PointCollection hullPoints;
        #endregion

        #region Properties
        public ObservableCollection<Point> Points {
            private set {
                points = value;
                NotifyChanged("Points");
            }
            get { return points; }
        }
        public PointCollection HullPoints {
            private set {
                hullPoints = value;
                NotifyChanged("HullPoints");
            }
            get { return hullPoints; }
        }
        #endregion

        #region Command definitions
        public static RoutedCommand CreateConvexHull = new RoutedCommand();
        public static RoutedCommand ClearPoints = new RoutedCommand();
        #endregion

        #region Constructor
        public ViewModel() {
            Points = new ObservableCollection<Point>();
            HullPoints = new PointCollection();
        }
        #endregion

        #region Methods
        public void AddPoint(Point point) {
            Points.Add(point);
        }
        public void ExecuteCreateConvexHull(object sender, ExecutedRoutedEventArgs e) {
            List<Point> source = points.ToList();
            if (sender.GetType().Name == "Jarvis_sAlgorithm")
                source = Jarvis_sAConvexHull.ConvexHull(source);
            else if (sender.GetType().Name == "Graham_sAlgorithm")
                source = Graham_sAConvexHull.ConvexHull(source);
            for (int i = 0; i < source.Count; i++)
                source[i] = new Point(source[i].X + 10, source[i].Y + 10);
            HullPoints = new PointCollection(source);
        }
        public void CanExecuteCreateConvexHull(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = Points.Count >= MinConvexHullPointsCount;
        }
        public void ExecuteClearPoints(object sender, ExecutedRoutedEventArgs e) {
            Points.Clear();
            HullPoints.Clear();
            HullPoints = new PointCollection();
        }
        public void CanExecuteClearPoints(object sender, CanExecuteRoutedEventArgs e) {
            e.CanExecute = Points.Count >= MinClearPointsCount;
        }
        #endregion

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyChanged(string propertie) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertie));
        }
        #endregion
    }
}
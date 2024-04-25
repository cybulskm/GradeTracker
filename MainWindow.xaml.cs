using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GradeTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadList();
            
        }

        public List<ListViewItem>? listViewItems { get; set; }
        public class Course
        {
            public int Num { get; set; }
            public string? Start { get; set; }
            public string? Finich { get; set; }
        }
        public void LoadList()
        {
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Num";
            c1.Binding = new Binding("Num");
            c1.Width = 110;
            CourseGrid.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Start";
            c2.Width = 110;
            c2.Binding = new Binding("Start");
            CourseGrid.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Finich";
            c3.Width = 110;
            c3.Binding = new Binding("Finich");
            CourseGrid.Columns.Add(c3);

            if (listViewItems != null)
            {
                foreach (ListViewItem item in listViewItems)
                {
                    GradeList.Items.Add(item);
                }
            }
            else
            {

                CourseGrid.Items.Add(new Item() { Num = 1, Start = "2012, 8, 15", Finich = "2012, 9, 15" });
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
using System.Windows;
namespace WpfApp2
{
    public partial class MainWindow : Window    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Person();
        }

    }

    public class Person
    {
        string _firstName = "길동";
        string _lastName = "홍";

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FullName
        {
            get { return string.Format("{0} {1}", LastName, FirstName ); }
        }
    }
}

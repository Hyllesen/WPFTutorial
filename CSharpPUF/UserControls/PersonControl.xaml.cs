using CSharpPUF.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSharpPUF.UserControls
{
    /// <summary>
    /// Interaction logic for PersonControl.xaml
    /// </summary>
    public partial class PersonControl : UserControl
    {
        public Person Person
        {
            get { return (Person)GetValue(PersonProperty); }
            set {
                SetValue(PersonProperty, value);

                Storyboard storyBoard = this.FindResource("MainAnimation") as Storyboard;
                storyBoard.Begin();
            }
        }

        // Using a DependencyProperty as the backing store for Person.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PersonProperty =
            DependencyProperty.Register("Person", typeof(Person), typeof(PersonControl), new PropertyMetadata(new Person(), GetValue));

        private static void GetValue(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            PersonControl personControl = sender as PersonControl;

            if(personControl != null)
            {
                personControl.MainContainer.DataContext = args.NewValue;
            }
        }

        public PersonControl()
        {
            InitializeComponent();
        }
    }
}

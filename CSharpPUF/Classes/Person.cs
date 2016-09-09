using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPUF.Classes
{
    public class Person : INotifyPropertyChanged
    {
        private string firstName;

        public string FirstName
        {
            get {
                return firstName;
            }
            set {
                firstName = value;
                OnPropertyChanged("FirstName");
                OnPropertyChanged("FullName");
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set {
                lastName = value;
                OnPropertyChanged("LastName");
                OnPropertyChanged("FullName");
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set {
                age = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string fullName;

        public string FullName
        {
            get { return FirstName + " " + LastName ; }
            set {
                fullName = value;
                OnPropertyChanged("FullName");
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set {
                email = value;
                OnPropertyChanged("Email");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        // Create the OnPropertyChanged method to raise the event
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public Person()
        {
            this.FirstName = "Stefan";
            this.LastName = "Hyltoft";
            this.Email = "stefanhyltoft@gmail.com";
            this.Age = 27;
        }

        public override string ToString()
        {
            return FullName;
        }

    }
}

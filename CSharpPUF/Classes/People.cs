using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPUF.Classes
{
    class People : ObservableCollection<Person>
    {
        public People()
        {
            for (int i = 0; i < 10; i++)
            {
                Add(new Person()
                {
                    FirstName = "Name " + i,
                    LastName = "Last aName " + 1,
                    Email = "Blalba@bla.dk",
                    Age = i
                });
            }
        }
    }
}

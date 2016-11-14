using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewHomework.View
{
    public class ShowList_View : View
    {
        public ShowList_View(PersonList personList) : base(personList)
        {
            options.AddRange(new string[] { "Back" });
        }

        public override View Control(int KeyNumber)
        {
            switch (KeyNumber)
            {
                case 1:
                    return null;
                default:
                    return this;
            }
        }

        public override void ShowContent()
        {
            _personList.SortByName();
            int i = 1;
            foreach (var person in _personList.List)
            {
                Console.WriteLine(i.ToString() + ". " + person.ToString());
                i++;
            }
            Console.WriteLine("");
        }
    }
}

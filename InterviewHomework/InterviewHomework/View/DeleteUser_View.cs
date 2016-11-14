using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterviewHomework.Model.Utilities;

namespace InterviewHomework.View
{
    public class DeleteUser_View : View
    {
        private int? _index;
        public DeleteUser_View(PersonList personList) : base(personList)
        {

        }

        public override View Control(int KeyNumber)
        {
            switch (KeyNumber)
            {
                case 1:
                    if( _index != null )
                        try
                        {
                            _personList.Delete(_personList.List[_index.Value]);
                        }
                        catch
                        {

                        }
                    return null;
                default:
                    return null;
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
            Console.Write("\nInsert number to delete: ");
            ConsoleKeyInfo cKeyInfo = ReadIntKey(false);
            try
            {
                _index = int.Parse(cKeyInfo.KeyChar.ToString()) - 1;
                Console.WriteLine("\nAre you sure to remove: " + _personList.List[_index.Value].ToString() + " ?");
                Console.WriteLine("1. Yes\n2. No");
            }catch
            {
                Console.WriteLine("\nSomething went wrong\n1. Back");
            }
        }
    }
}

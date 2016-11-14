using System;
using System.Threading;
using static InterviewHomework.Model.Utilities;

namespace InterviewHomework.View
{
    public class AddUser_View : View
    {
        Person _person;
        public AddUser_View(PersonList personList) : base(personList)
        {

        }

        public override View Control(int KeyNumber)
        {
            switch (KeyNumber)
            {
                case 1:
                    if(_person!=null)
                        try
                        {
                            _personList.Add(_person);
                        }
                        catch(Exception e)
                        {
                            ViewAndWait(e.Message, 1000);
                        }
                       
                    return null;
                case 2:
                    return null;
                case 3:
                    return this;
                default:
                    return null;
            }
        }

        public override void ShowContent()
        {
            Console.Write("Insert name: ");
            string name = Console.ReadLine();
            Console.Write("Insert email: ");
            string mail = Console.ReadLine();
            try
            {
                _person = new Person(name.Trim(), mail);
                Console.WriteLine("\n1. Save\n2. Cancel\n3. Modify data");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\n1. Back");
            }
           
           
        }
    }
}

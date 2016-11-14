using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewHomework.View
{
    public class Main_View : View
    {
        public Main_View(PersonList personList) : base(personList)
        {
            options.AddRange(new string[] { "Show list", "Add user", "Delete user", "Xml manager" });
        }

        public override void ShowContent()
        {
            return;
        }

        public override View Control(int KeyNumber)
        {
            switch (KeyNumber)
            {
                case 1:
                    return new ShowList_View(_personList);
                case 2:
                    return new AddUser_View(_personList);
                case 3:
                    return new DeleteUser_View(_personList);
                case 4:
                    return new Xml_View(_personList);
                default:
                    return this;
            }
        }

    }
}

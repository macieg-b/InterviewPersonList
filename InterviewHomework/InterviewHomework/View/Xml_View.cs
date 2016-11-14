using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterviewHomework.Model.Utilities;

namespace InterviewHomework.View
{
    public class Xml_View : View
    {
        public Xml_View(PersonList personList) : base(personList)
        {
            options.AddRange(new string[] { "Load from file", "Serialize and save" });
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
                    PersonList tmpList = new PersonList(XML.LoadPersonListFromXml().ToArray());
                    if (tmpList.List.Count > 0)
                    {
                        _personList.List.RemoveAll(person => person !=null);
                        foreach (Person person in tmpList.List)
                        {
                            _personList.Add(person);
                        }
                    }
                    ViewAndWait("List has been loaded...", 1000);
                    return null;
                case 2:
                    XML.SerializeAndSaveList(_personList.List);
                    ViewAndWait("List is being saved...", 1000);
                    return null;
                case 3:
                default:
                    return null;
            }
        }
    }
}

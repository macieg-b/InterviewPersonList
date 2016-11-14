using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewHomework.Model
{
    public class Utilities
    {
        public static void ViewAndWait(string text, int miliseconds)
        {
            Console.WriteLine("\n" + text);
            System.Threading.Thread.Sleep(miliseconds);
        }

        public static ConsoleKeyInfo ReadIntKey(bool showTitle)
        {
            if(showTitle)
                Console.Write("\nSelect option: ");
            while (true)
            {
                try
                {
                    ConsoleKeyInfo cKeyInfo = Console.ReadKey(true);
                    if(cKeyInfo.Key == ConsoleKey.Escape)
                    {
                        return cKeyInfo;
                    }
                    int.Parse(cKeyInfo.KeyChar.ToString());
                    return cKeyInfo;
                }
                catch
                {
                    
                }
            }
                     
        }
        public class XML
        {
            public static List<Person> LoadPersonListFromXml()
            {
                List<Person> returnList = new List<Person>();
                if (File.Exists(@"..\person.xml"))
                {
                    var input = XDocument.Load(@"..\person.xml");
                    foreach (var data in input.Descendants("Person"))
                    {
                        returnList.Add(new Person(data.Element("Name").Value,
                            data.Element("Email").Value));
                    }
                }
                return returnList;
            }

            public static void SerializeAndSaveList(List<Person> PersonList)
            {
                try
                {
                    String path = @"..\person.xml";

                    XDocument doc = new XDocument(new XElement("PersonContainer",
                    from data in PersonList
                    select new XElement("Person",
                    new XElement("Name", data.Name),
                    new XElement("Email", data.Email)
                    )));
                    doc.Save(path);
                }
                catch (Exception e)
                {
                    String error = e.ToString();
                }
            }
        }
    }
}

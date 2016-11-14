using System;
using System.Collections.Generic;

namespace InterviewHomework.View
{
    public abstract class View
    {
        protected String _header = "********************\n Person list \n********************";
        protected List<String> options;
        protected PersonList _personList;
        
        public View(PersonList personList)
        {
            options = new List<String>();
            _personList = personList;
        }
        public void Launch()
        {
            Console.Clear();
            Console.WriteLine(_header);
            ShowContent();
            ShowOptions();
        }
        public void ShowOptions()
        {
            int i = 1;
            foreach (var option in options)
            {
                Console.WriteLine(i.ToString() + ". " + option);
                i++;
            }
        }
        public abstract void ShowContent();
        public abstract View Control(int KeyNumber);

        public PersonList List
        {
            get
            {
                return _personList;
            }
            set
            {
                _personList = value;
            }
        }
    }
}

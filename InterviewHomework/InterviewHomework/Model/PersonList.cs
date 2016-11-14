using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewHomework
{
    public class PersonList
    {
        #region Fields
        private List<Person> _list;
        #endregion


        #region Constructors
        public PersonList()
        {
            if (_list == null)
                _list = new List<Person>();
        }
        public PersonList(Person person) : this()
        {
            Add(person);
        }
        public PersonList(Person []personArray) : this()
        {
            foreach (var person in personArray)
            {
                Add(person);
            }
        }
        #endregion


        #region Properties
        public List<Person> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
        #endregion


        #region Methods
        public void Add(Person person)
        {
            if (_list != null && person != null)
            {
                if (_list.Count < 5)
                {
                    Person withTheSameEmail = _list.Find(x => x.Email.Equals(person.Email));
                    if (withTheSameEmail == null)
                    {
                        _list.Add(person);
                    }
                    else
                    {
                        throw new Exception("Email is binded with antoher person");
                    }
                }
                else
                {
                    throw new Exception("Maximum list's length was reached");
                }
                
            }
            else
                throw new Exception("List or person is unintialized");
        }
        public bool Delete(Person person)
        {
            if (_list != null && person != null)
            {
                _list.Remove(person);
                return true;
            }
            else
                return false;
        }
        public void SortByName()
        {
            if(_list!= null && _list.Count>0)
                _list = _list.OrderBy(Person => Person.Name).ToList();
        }
        #endregion

    }
}

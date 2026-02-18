using System;
using System.Collections.Generic;

namespace digitalis_nyomozo
{
    internal class DataStore
    {
        private List<User> users;
        private List<Case> cases;
        private List<Person> persons;
        private List<Evidence> evidences;

        public DataStore()
        {
            users =  new List<User>();
            cases =new List<Case>();
            persons =new List<Person>();
            evidences =new List<Evidence>();
        }

        public List<User> Users => users;
        public List<Case> Cases => cases;
        public List<Person> Persons => persons;
        public List<Evidence> Evidences => evidences;
    }
}
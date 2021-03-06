﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class SchoolEntry : ISaveable
    {
        public static List<SchoolEntry> allSchools;
        public List<ContactEntry> schoolContacts;
        public string schoolName;
        public string schoolScope;
        public string schoolNotes;

        void ISaveable.Save(){
            
            }
        void ISaveable.Load()
        {

        }
    }

    public class ContactEntry: ISaveable
    {
        public string contactName;
        public string contactLoginName;
        public List<string> contactPhoneList;
        public string contactEmail;
        public string contactNotes;


        void ISaveable.Save()
        {

        }
        void ISaveable.Load()
        {

        }
    }

    public interface ISaveable
    {
        void Save();
        void Load();
    }

    public class AppController
    {
        public List<ISaveable> allEntries;

        public static ISaveable currentRecord;

        public void saveAll()
        {
            foreach(var entry in allEntries)
            {
                entry.Save();
                entry.Load();
            }
        }

        public void Register(ISaveable entry)
        {
            if (!allEntries.Contains(entry))
            {
                allEntries.Add(entry);
            }
        }
    }
}

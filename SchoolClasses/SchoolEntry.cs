using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolClasses
{
    public class SchoolEntry : ISaveable
    {
        public static List<SchoolEntry> allSchools = new List<SchoolEntry>();
        public static SchoolEntry currentEntry;
        public List<ContactEntry> schoolContacts = new List<ContactEntry>();
        public string schoolScope = "";
        public string schoolNotes = "";

        

        public void Save() {
            
        }
        public void Load()
        {

        }

    }
    
    public class ContactEntry: ISaveable
    {
        public static List<ContactEntry> allEntries = new List<ContactEntry>();
        public static ContactEntry currentContact;
        public string contactName;
        public string contactLoginName = "";
        public string contactPhone1 = "";
        public string contactPhone2 = "";
        public string contactEmail = "";
        public string contactNotes = "";
        public SchoolEntry contactSchool;


        public void Save()
        {

        }
        public void Load()
        {

        }
    }

    public interface ISaveable
    {
        void Save();
        void Load();
    }

    public class EntryBuilder
    {
        public enum modeEnum {Group, Contact};
        public static modeEnum mode;
    }

    public class AppController
    {
        public static List<ISaveable> allEntries;

        public static ISaveable currentRecord; //deprecate
        public static SchoolEntry currentSchool;
        public static ContactEntry currentContact;

        public static void saveAll()
        {
            foreach(SchoolEntry entry in SchoolEntry.allSchools)
            {
                entry.Save();
                entry.Load();
            }
            foreach(ContactEntry entry in ContactEntry.allEntries)
            {
                entry.Save();
                entry.Load();
            }
        }

        
        public static SchoolEntry GetSchool(string schoolname)
        {
            SchoolEntry entryCheck = null;
            foreach(SchoolEntry entry in SchoolEntry.allSchools)
            {
                if(entry.schoolScope == schoolname)
                {
                    entryCheck = entry;
                }
            }
            return entryCheck;
        }
        public static ContactEntry GetContact(string contact_name)
        {
            ContactEntry contactCheck = null;
            foreach(ContactEntry entry in currentSchool.schoolContacts)
            {
                if(entry.contactName == contact_name)
                {
                    contactCheck = entry;
                }
            }
            return contactCheck;
        }
        public static void breakpoint()
        {

        }
    }
}

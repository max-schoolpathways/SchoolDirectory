using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SchoolClasses
{
    [Serializable()]
    public class SchoolEntry
    {
        public SchoolEntry details = new SchoolEntry("details");
        public static List<SchoolEntry> allSchools = new List<SchoolEntry>();
        public static SchoolEntry currentEntry;
        public List<ContactEntry> schoolContacts = new List<ContactEntry>();
        public string schoolScope { get; set; }
        public string schoolNotes = "";
        public string schoolName = "";
        public List<string> schoolPeriods = new List<string>();
        public ContactEntry director;
        public ContactEntry primaryContact;
        public List<ProductEntry> integrations = new List<ProductEntry>();
        
        public SchoolEntry(string scope, string notes, List<ContactEntry> contacts)
        {
            schoolScope = scope;
            schoolNotes = notes;
            schoolContacts = contacts;
        }
        public SchoolEntry(string scope)
        {
            schoolScope = scope;
        }

       

    }
    [Serializable()]
    public class ContactEntry
    {
        public static List<ContactEntry> allEntries = new List<ContactEntry>();
        public static ContactEntry currentContact;
        public string contactName;
        public string contactLogin = "";
        public string contactPhone1 = "";
        public string contactPhone2 = "";
        public string contactEmail = "";
        public string contactNotes = "";
        public string contactPosition = "";
        public SchoolEntry contactSchool;

        public ContactEntry(string name, string login, string position, string phone1, string phone2, string email, string notes, SchoolEntry school)
        {
            contactName = name;
        }
        public ContactEntry(string login)
        {
            contactLogin = login;
        }
        public void Delete()
        {
            ContactEntry.currentContact.contactSchool.schoolContacts.Remove(this);
            ContactEntry.currentContact.contactSchool = null;
        }
        
    }
    [Serializable()]
    public class ProductEntry
    {
        public string name;
        public string websiteURL;
        public string description;
        public string notes;
        public ProductEntry(string _name)
        {
            name = _name;
        }
        public ProductEntry(string _name, string URL, string _description, string _notes)
        {
            name = _name;
            websiteURL = URL;
            description = _description;
            notes = _notes;
        }
    }

    public class EntryBuilder
    {
        public enum modeEnum {Group, Contact};
        public static modeEnum mode;
    }

    public class AppController
    {
        
        public static SchoolEntry currentSchool;
        public static ContactEntry currentContact;

        
        public static string directory = "C://Users//Public//SchoolDirectory";
        public static string Path = directory + "//data.bin";


        public static void saveRecords()
        {
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
            Stream writeStream = File.Create(Path);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(writeStream, SchoolEntry.allSchools);
            writeStream.Close();
        }

        public static void loadRecords()
        {
            //SchoolEntry.allSchools = new List<SchoolEntry>();
            if (File.Exists(Path))
            {
                Stream readStream = File.OpenRead(Path);
                BinaryFormatter deserializer = new BinaryFormatter();
                SchoolEntry.allSchools = (List<SchoolEntry>)deserializer.Deserialize(readStream);
                readStream.Close();
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
            foreach(ContactEntry entry in SchoolEntry.currentEntry.schoolContacts)
            {
                if(entry.contactLogin == contact_name)
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

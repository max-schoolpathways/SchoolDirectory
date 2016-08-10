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
        public static List<SchoolEntry> allSchools = new List<SchoolEntry>();
        public static SchoolEntry currentEntry;
        public List<ContactEntry> schoolContacts;
        private string _schoolScope;
        public string schoolScope
        {
            get
            {
                return _schoolScope;
            }
            set
            {
                _schoolScope = value;
            }
        }
        public string schoolNotes = "";
        public string schoolName = "";
        public List<string> schoolPeriods = new List<string>();
        public ContactEntry director;
        public ContactEntry primaryContact;
        public List<ExperienceEntry> products = new List<ExperienceEntry>();
        
        public SchoolEntry(string scope, string notes, List<ContactEntry> contacts)
        {
            schoolScope = scope;
            schoolNotes = notes;
            schoolContacts = new List<ContactEntry>();
            schoolContacts = contacts;
        }
        public SchoolEntry(string scope, string name)
        {
            schoolScope = scope;
            schoolName = name;
            schoolContacts = new List<ContactEntry>();
        }
        public void Delete()
        {
            List<ContactEntry> contacts = new List<ContactEntry>();
            if (schoolContacts != null)
            {
                foreach (var contact in schoolContacts)
                {
                    contacts.Add(contact);
                }
                foreach (var contact in contacts)
                {
                    contact.Delete(contact);
                }
            }
            allSchools.Remove(this);
            director = null;
            primaryContact = null;
            AppController.saveRecords();
        }

        /// <summary>
        /// Returns a list of the users of the specified product.
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static List<SchoolEntry> GetUsers(ProductEntry product)
        {
            List<SchoolEntry> schoolList = new List<SchoolEntry>();
            foreach (SchoolEntry school in allSchools)
            {
                foreach(ExperienceEntry eproduct in school.products)
                {
                    if(eproduct.productName == product.name)
                    {
                        schoolList.Add(school);
                    }
                }
            }
            return schoolList;
        }

    }
    [Serializable()]
    public class ContactEntry
    {
        public static List<ContactEntry> allEntries = new List<ContactEntry>();
        public static ContactEntry currentContact;
        private string _contactName;
        public string contactName
        {
            get
            {
                return _contactName;
            }
            set
            {
                _contactName = value;
            }
        }
        private string _contactLogin;
        public string contactLogin
        {
            get
            {
                return _contactLogin;
            }
            set
            {
                _contactLogin = value;
            }
        }
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
            ContactEntry.currentContact = null;
            AppController.saveRecords();
        }
        public void Delete(ContactEntry contact)
        {
            contact.contactSchool.schoolContacts.Remove(this);
            contact.contactSchool = null;
            AppController.saveRecords();
        }
        
    }
    [Serializable()]
    public class ProductEntry
    {
        public static ProductEntry currentProduct;
        public static List<ProductEntry> allProducts = new List<ProductEntry>();
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string company;
        public string websiteURL;
        public string description;
        public string notes;
        public string cost;
        public ProductEntry(string productName)
        {
            name = productName;
        }
        public ProductEntry(string productName, string URL, string _description, string _notes)
        {
            name = productName;
            websiteURL = URL;
            description = _description;
            notes = _notes;
        }
    }
    /// <summary>
    /// An "Experience" is the relationship between a Group and a Product.
    /// </summary>
    [Serializable()]
    public class ExperienceEntry
    {
        public static ExperienceEntry currentExperienceEntry;
        private SchoolEntry _school;
        public SchoolEntry school
        {
            get
            {
                return _school;
            }
            set
            {
                _school = value;
            }
        }
        private ProductEntry _product;
        public ProductEntry product
        {
            get
            {
                return _product;
            }
            set
            {
                _product = value;
            }
        }
        //private string _productName;
        public string productName
        {
            get
            {
                return product.name;
            }
            set
            {

            }
        }
        public bool isActive;
        public string purchaseDate;
        public string cancelDate;
        public string cost;
        public string notes;
        public ExperienceEntry(ProductEntry product_, SchoolEntry school_)
        {
            product = product_;
            school = school_;
        }
        public void Delete()
        {
            school.products.Remove(this);
            school = null;
            product = null;
        }
    }


    public class EntryBuilder
    {
        public enum modeEnum {New, Existing};
        public static modeEnum mode;
    }

    public class AppController
    {
        
        //public static SchoolEntry currentSchool;
        //public static ContactEntry currentContact;

        
        public static string directory = "C://Users//Public//SchoolDirectory//dev";
        public static string groupPath = directory + "//groupData.bin";
        public static string productPath = directory + "//productData.bin";


        public static void saveRecords()
        {
            if (!Directory.Exists(directory)) {
                Directory.CreateDirectory(directory);
            }
            Stream schoolWriteStream = File.Create(groupPath);
            BinaryFormatter schoolSerializer = new BinaryFormatter();
            schoolSerializer.Serialize(schoolWriteStream, SchoolEntry.allSchools);
            schoolWriteStream.Close();

            Stream productWriteStream = File.Create(productPath);
            BinaryFormatter productSerializer = new BinaryFormatter();
            productSerializer.Serialize(productWriteStream, ProductEntry.allProducts);
            productWriteStream.Close();
        }

        public static void loadRecords()
        {
            //SchoolEntry.allSchools = new List<SchoolEntry>();
            if (File.Exists(groupPath))
            {
                Stream readStream = File.OpenRead(groupPath);
                BinaryFormatter deserializer = new BinaryFormatter();
                SchoolEntry.allSchools = (List<SchoolEntry>)deserializer.Deserialize(readStream);
                readStream.Close();
            }
            if (File.Exists(productPath))
            {
                Stream productReadStream = File.OpenRead(productPath);
                BinaryFormatter productDeserializer = new BinaryFormatter();
                ProductEntry.allProducts = (List<ProductEntry>)productDeserializer.Deserialize(productReadStream);
                productReadStream.Close();
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

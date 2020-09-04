using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Project_Files_Trial
{
    public class admin
    {
        public string username, password, id;
        public static int id_counter = 0;
        public admin()
        {
        }
        public admin(string _username, string _password)
        {
            username = _username;
            password = _password;
            id_counter++;
            id = Convert.ToString(id_counter);
        }
        public void add_admin(string username, string password)
        {

            try
            {
                if (!File.Exists("Admins.xml"))
                {
                    // string image_Text = openFileDialog1.FileName;
                    XmlWriter writer = XmlWriter.Create("Admins.xml");

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Admins");

                    writer.WriteStartElement("Admin");

                    writer.WriteStartElement("Username");
                    writer.WriteString(username);
                    writer.WriteEndElement();

                    writer.WriteStartElement("Password");
                    writer.WriteString(password);
                    writer.WriteEndElement();

                    //  writer.WriteEndElement();

                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                    writer.Close();
                }
                else
                {
                    XmlDocument elmRoot = new XmlDocument();
                    elmRoot.Load("Admins.xml");
                    XmlNodeList elements = elmRoot.GetElementsByTagName("Admin");
                    Boolean found = false;
                    for (int i = 0; i < elements.Count; i++)
                    {
                        XmlNodeList children = elements[i].ChildNodes;
                        string id = children[0].Name;
                        string idvalue = children[0].InnerText;
                        if (idvalue == username)
                        {
                            found = true;
                            break;
                        }
                    }
                    if (found == false)
                    {
                        // string image_Text = openFileDialog1.FileName;
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Admins.xml");

                        XmlElement person = doc.CreateElement("Admin");
                        XmlElement node = doc.CreateElement("Username");
                        node.InnerText = username;
                        person.AppendChild(node);

                        node = doc.CreateElement("Password");
                        node.InnerText = password;
                        person.AppendChild(node);

                        XmlElement root = doc.DocumentElement;

                        root.AppendChild(person);

                        doc.Save("Admins.xml");
                        MessageBox.Show("Successfully Saved!!");
                    }
                    else
                    {
                        MessageBox.Show("already exists!!");
                    }
                }
            }
            catch (Exception)
            {

            }

        }
        public void update_admin(string check, string _username, string _password)
        {
            try
            {

                XmlDocument XMLEdit = new XmlDocument();
                XMLEdit.Load("Admins.xml");

                XmlElement XMLEditNode = XMLEdit.DocumentElement;

                foreach (XmlNode node in XMLEditNode) // Loop through XML file
                {
                    if (node["Username"].InnerText == check) // Check for the ID field information
                    {
                        node["Username"].InnerText = _username;
                        node["Password"].InnerText = _password;


                        break;
                    }
                }
                //MessageBox.Show("YARAAAB");
                XMLEdit.Save("Admins.xml");


            }
            catch (Exception)
            {

            }

        }
        public void delete_admin(string check)
        {
            try
            {
                XmlDocument XMLDelete = new XmlDocument();
                XMLDelete.Load("Admins.xml");

                XmlElement XMLDeleteNode = XMLDelete.DocumentElement;

                foreach (XmlNode node in XMLDeleteNode)
                {
                    if (node["Username"].InnerText == check) // Find the match for the ID field
                    {
                        node.ParentNode.RemoveChild(node); // Delete the parent for the children (fields)
                        break;
                    }
                }
                MessageBox.Show("Deleted");
                XMLDelete.Save("Admins.xml");
            }
            catch (Exception)
            {

            }
        }
    }

}

public class Officer
{
    public string officer_username;
    public string officer_password;
    public string officer_ID;
    public string officer_Name;

    public string no_of_assigned_crimes;
    public List<string> assigned_crimes = new List<string>();
    public List<string> ids = new List<string>();
    public static int officer_ID_counter = 0;

    public Officer(string name, string username, string password, string no_of_assigned_crimes)
    {
        officer_Name = name;
        officer_username = username;
        officer_password = password;
        no_of_assigned_crimes = "0";
        officer_ID_counter++;
        officer_ID = Convert.ToString(officer_ID_counter);
    }
    public Officer()
    {

    }
    public void Officers_IDs(string id)
    {
        XmlWriter writer = XmlWriter.Create("Officers_ID.xml");

        writer.WriteStartDocument();

        writer.WriteStartElement("Officers_IDs");

        writer.WriteStartElement("IDs");

        writer.WriteStartElement("ID");
        writer.WriteString(id);
        writer.WriteEndElement();
      
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
    }
    public bool add_officer(string id, string name, string crimesno, string username, string password)
    {
        if (!File.Exists("Officers.xml"))
        {
            XmlWriter writer = XmlWriter.Create("Officers.xml");

            writer.WriteStartDocument();

            writer.WriteStartElement("Person");

            writer.WriteStartElement("Officer");


            writer.WriteStartElement("ID");
            writer.WriteString(id);
            writer.WriteEndElement();
            ids.Add(id);

            writer.WriteStartElement("Name");
            writer.WriteString(name);
            writer.WriteEndElement();

            writer.WriteStartElement("Number_of_assigned_crimes");
            writer.WriteString(crimesno);
            writer.WriteEndElement();

            writer.WriteStartElement("Username");
            writer.WriteString(username);
            writer.WriteEndElement();

            writer.WriteStartElement("Password");
            writer.WriteString(password);
            writer.WriteEndElement();



            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("Successfully Added");
            return true;

        }
        else
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Officers.xml");
            XmlNodeList elements = doc.GetElementsByTagName("Officer");
            Boolean found = false;
            for (int i = 0; i < elements.Count; i++)
            {
                XmlNodeList children = elements[i].ChildNodes;
                string usernamee = children[3].Name;
                string usernamevalue = children[3].InnerText;
                if (usernamevalue == username)
                {
                    found = true;
                   // return false;
                }
            }

            if (found == false)
            {

                XmlElement officer = doc.CreateElement("Officer");

                XmlElement node = doc.CreateElement("ID");
                node.InnerText = id;
                officer.AppendChild(node);
                ids.Add(id);

                node = doc.CreateElement("Name");
                node.InnerText = name;
                officer.AppendChild(node);

                node = doc.CreateElement("Number_of_assigned_crimes");
                node.InnerText = crimesno;
                officer.AppendChild(node);

                node = doc.CreateElement("Username");
                node.InnerText = username;
                officer.AppendChild(node);

                node = doc.CreateElement("Password");
                node.InnerText = password;
                officer.AppendChild(node);


                XmlElement root = doc.DocumentElement;
                root.AppendChild(officer);

                doc.Save("Officers.xml");
                MessageBox.Show("Successfully Added");
                return true;
            }
            else
            {
                MessageBox.Show("Already exists");
                return false;
            }

        }


    }

    public void update_officer(string check, string name, string username, string password)
    {
        try
        {

            XmlDocument XMLEdit = new XmlDocument();
            XMLEdit.Load("Officers.xml");

            XmlElement XMLEditNode = XMLEdit.DocumentElement;

            foreach (XmlNode node in XMLEditNode) // Loop through XML file
            {
                if (node["ID"].InnerText == check) // Check for the ID field information
                {
                    node["Name"].InnerText = name;
                    // node["Number_of_assigned_crimes"].InnerText = nocrimes;
                    node["Username"].InnerText = username;
                    node["Password"].InnerText = password;

                    break;
                }
            }
           // MessageBox.Show("YARAAAB");
            XMLEdit.Save("Officers.xml");

        }
        catch (Exception)
        {

        }
    }

    public void delete_officer(string check)
    {
        try
        {
            XmlDocument XMLDelete = new XmlDocument();
            XMLDelete.Load("Officers.xml");

            XmlElement XMLDeleteNode = XMLDelete.DocumentElement;

            foreach (XmlNode node in XMLDeleteNode)
            {
                if (node["ID"].InnerText == check) // Find the match for the ID field
                {
                    node.ParentNode.RemoveChild(node); // Delete the parent for the children (fields)
                    break;
                }
            }
            MessageBox.Show("Deleted");
            XMLDelete.Save("Officers.xml");
        }
        catch (Exception)
        {

        }
    }
}

public class involved_people
{
    public string id, age, name, location;
    public static int id_counter = 0;
    public Dictionary<string, int> crimes = new Dictionary<string, int>();
    //da dictionary le kol crime type(string) w 3amlha kam mara (int)
    public List<string> crime_id = new List<string>();
    // dy list lel crimes(ids) el bane2dam da 3amlha
    public string image;
    string points;
    public involved_people(string _age, string _name, string _location, string _image, string _points)
    {
        age = _age;
        name = _name;
        location = _location;
        image = _image;
        id_counter++;
        id = Convert.ToString(id_counter);
        points = _points;
    }

    public void add_case(string _case_id)
    {
        crime_id.Add(_case_id);
        //el fn dy hayt3amlha call f el class beta3 el 
        //f class crime (assign_officer)
    }
    public void Suspects_IDs(string id)
    {
        XmlWriter writer = XmlWriter.Create("Suspects_ID.xml");

        writer.WriteStartDocument();

        writer.WriteStartElement("Suspects_IDs");

        writer.WriteStartElement("IDs");

        writer.WriteStartElement("ID");
        writer.WriteString(id);
        writer.WriteEndElement();

        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
    }
    public void add_suspect_in_list(string ID, string _age, string _name, string _location, string _image, string _points)//involved_people _suspect
    {
        //ha5od suspect bnafs tare2a beta3et el officer w ne3mel add hena-
        //fel dictionary 
        if (!File.Exists("Suspects.xml"))
        {
            // string image_Text = openFileDialog1.FileName;
            XmlWriter writer = XmlWriter.Create("Suspects.xml");

            writer.WriteStartDocument();

            writer.WriteStartElement("InvolvedPeople");

            writer.WriteStartElement("Person");

            writer.WriteStartElement("ID");
            writer.WriteString(ID);
            writer.WriteEndElement();

            writer.WriteStartElement("Name");
            writer.WriteString(_name);
            writer.WriteEndElement();

            writer.WriteStartElement("Age");
            writer.WriteString(_age);
            writer.WriteEndElement();

            writer.WriteStartElement("Location");
            writer.WriteString(_location);
            writer.WriteEndElement();

            writer.WriteStartElement("Image");
            writer.WriteString(_image);
            writer.WriteEndElement();

            writer.WriteStartElement("Points");
            writer.WriteString(_points);
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }
        else
        {
            // string image_Text = openFileDialog1.FileName;
            XmlDocument doc = new XmlDocument();
            doc.Load("Suspects.xml");

            XmlElement person = doc.CreateElement("Person");
            XmlElement node = doc.CreateElement("ID");
            node.InnerText = ID;
            person.AppendChild(node);

            node = doc.CreateElement("Name");
            node.InnerText = _name;
            person.AppendChild(node);

            node = doc.CreateElement("Age");
            node.InnerText = _age;
            person.AppendChild(node);

            node = doc.CreateElement("Location");
            node.InnerText = _location;
            person.AppendChild(node);

            node = doc.CreateElement("Image");
            node.InnerText = _image;
            person.AppendChild(node);

            node = doc.CreateElement("Points");
            node.InnerText = _points;
            person.AppendChild(node);



            XmlElement root = doc.DocumentElement;

            root.AppendChild(person);

            doc.Save("Suspects.xml");
        }

        MessageBox.Show("Successfully Saved!!");
    }
    public void update_suspect(string check, string name, string age, string location, string points)
    {
        try
        {

            XmlDocument XMLEdit = new XmlDocument();
            XMLEdit.Load("Suspects.xml");

            XmlElement XMLEditNode = XMLEdit.DocumentElement;

            foreach (XmlNode node in XMLEditNode) // Loop through XML file
            {
                if (node["ID"].InnerText == check) // Check for the ID field information
                {
                    node["Name"].InnerText = name;
                    node["Age"].InnerText = age;
                    node["Location"].InnerText = location;
                    node["Points"].InnerText = points;
                    //node["Image"].InnerText = image_Text;
                    break;
                }
            }
            MessageBox.Show("Successfully Edited!");
            XMLEdit.Save("Suspects.xml");

        }
        catch (Exception)
        {

        }
    }
    public void delete_suspect(string check)
    {
        try
        {
            XmlDocument XMLDelete = new XmlDocument();
            XMLDelete.Load("Suspects.xml");

            XmlElement XMLDeleteNode = XMLDelete.DocumentElement;

            foreach (XmlNode node in XMLDeleteNode)
            {
                if (node["ID"].InnerText == check) // Find the match for the ID field
                {
                    node.ParentNode.RemoveChild(node); // Delete the parent for the children (fields)
                    break;
                }
            }
            MessageBox.Show("Deleted");
            XMLDelete.Save("Suspects.xml");
        }
        catch (Exception)
        {

        }
    }

}

class Crime
{
    public string description, officer_id, type_id, location, criminal, id;
    public bool status;
    public List<string> items_found = new List<string>();
    public List<string> suspects_id = new List<string>();
    public List<Officer> assigned_officers = new List<Officer>();
    public Dictionary<string, involved_people> criminals = new Dictionary<string, involved_people>();
    public static int id_counter = 0;
    string image;
    string open = "0";
    private object no_of_assigned_crimes;

    public Crime()
    { }
    public Crime(string _description, string _of_id, string _ty_id, string _location, string open, string _image, List<string> _suspects, List<string> _items)
    {
        description = _description;
        officer_id = _of_id;
        type_id = _ty_id;
        location = _location;
        id_counter++;
        id = Convert.ToString(id_counter);
        status = false;
        image = _image;
        for (int i = 0; i < items_found.Count; i++)
        {
            items_found[i] = _items[i];
        }
        for (int i = 0; i < suspects_id.Count; i++)
        {
            suspects_id[i] = _suspects[i];
        }
        //delwa2ty el officer id da malosh ay lazma 3ashan hwa mesh officer 
        //wahed f el case , homa kaza wa7ed w 3amlnahom list,fa odamna 7alen
        //ya2ema neshelo aslan ,ya2ema ne3teber en da el officer el masek
        //el case 
    }
    public void Assign_officers(Officer of)
    {
        //tab3an el officer da hana5do mn el dictionary
        //ha5od el username el hwa el key w ab3at el value beta3to
        //el heya el officer aslan 
        try
        {
            XmlDocument dc = new XmlDocument();
            dc.Load("Officers.xml");
            XmlElement xmledit = dc.DocumentElement;
            foreach (XmlNode node in xmledit)
            {
                if (node["ID"].InnerText == of.officer_ID)
                {
                    int nvalue = int.Parse(node["Number_of_assigned_crimes"].InnerText);
                    nvalue++;
                    node["Number_of_assigned_crimes"].InnerText = nvalue.ToString();
                }
            }
            //MessageBox.Show("Yaraaaab");
            dc.Save("Officers.xml");
        }
        catch (Exception)
        {

        }

    }

    public void Cases_IDs(string id)
    {
        XmlWriter writer = XmlWriter.Create("Cases_ID.xml");

        writer.WriteStartDocument();

        writer.WriteStartElement("Cases_IDs");

        writer.WriteStartElement("IDs");

        writer.WriteStartElement("ID");
        writer.WriteString(id);
        writer.WriteEndElement();

        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
        writer.Close();
    }

    void add_item(string _item)
    {
        items_found.Add(_item);
        //te7ebo ne3mel for loop 3ashan lw el item aslan mawgoda
        //ye return false zay el fn el ablaha wala nekbar demaghna
        //w mafrod en el by7ot item yeb2a zaky enough eno mayd5lhash marten?
        //ana ka lina shayfa malhash lazma :)<3.
    }
    bool add_suspect(involved_people iv)
    {
        if (!criminals.ContainsKey(iv.id))
        {
            criminals.Add(iv.id, iv);
            iv.add_case(id);
            // el fn dy beta5od el string el hwa id beta3 el case te7oto
            //lel suspect fe el crime list beto3o 
            return true;
        }
        else
            return false;
    }

    public void add_criminal(string _criminal, Officer of)
    {
        criminal = _criminal;
        status = true;
        //int number_of_assigned_Crimes = int.Parse(of.no_of_assigned_crimes);
        //number_of_assigned_Crimes--;
        try
        {
            XmlDocument dc = new XmlDocument();
            dc.Load("Officers.xml");
            XmlElement xmledit = dc.DocumentElement;
            foreach (XmlNode node in xmledit)
            {
                if (node["Username"].InnerText == of.officer_username)
                {
                    int nvalue = int.Parse(node["Number_of_assigned_crimes"].InnerText);
                    nvalue--;
                    node["Number_of_assigned_crimes"].InnerText = nvalue.ToString();

                }
            }
           // MessageBox.Show("Yaraaaab");
            dc.Save("Officers.xml");
        }
        catch (Exception)
        {

        }
    }
    // na2es el image of crime (data member)
    public void add_crime(string Crime_ID, string _description, string _of_id, string _ty_id, string _location, string open, string _image, List<string> _suspects, List<string> _items)
    {
        // 3'aiary el textBoxes bl parameters
        //DI EL SAVEEEEE!!!!!


        try
        {
            if (!File.Exists("CRIMEDATA.xml"))
            {
                XmlWriter writer = XmlWriter.Create("CRIMEDATA.xml");

                writer.WriteStartDocument();

                writer.WriteStartElement("case");
                writer.WriteStartElement("crime");

                writer.WriteStartElement("CrimeID");
                writer.WriteString(Crime_ID);
                writer.WriteEndElement();

                writer.WriteStartElement("TypeID");
                writer.WriteString(type_id);
                writer.WriteEndElement();

                writer.WriteStartElement("Status");
                writer.WriteString(open);
                writer.WriteEndElement();

                writer.WriteStartElement("Area");
                writer.WriteString(_location);
                writer.WriteEndElement();

                writer.WriteStartElement("Description");
                writer.WriteString(_description);
                writer.WriteEndElement();

                writer.WriteStartElement("OfficerID");
                writer.WriteString(_of_id);
                writer.WriteEndElement();

                writer.WriteStartElement("ItemsFound");
                foreach (var item in _items)
                {
                    if (_items.Count == 1)
                    {
                        writer.WriteString(item);
                    }
                    else
                    {
                        
                        writer.WriteString(item + ",");
                    }
                }
                writer.WriteEndElement();

                //writer.WriteStartElement("ItemsFound");
                //string ItemsFoundString = _itemsfound[0];
                //for (int q = 1; q < _itemsfound.Count; q++)
                //{
                //    //ItemsFoundString += " , ";
                //writer.WriteString(ItemsFoundString);
                //writer.WriteEndElement();
                //    ItemsFoundString += _itemsfound[q];

                //}

                writer.WriteStartElement("Suspect");
                foreach (var item in _suspects)
                {
                    if (_suspects.Count == 1)
                    {
                        writer.WriteString(item);
                    }
                    else
                    {
                        writer.WriteString(item + ",");
                    }
                }
                writer.WriteEndElement();

                //string imageText = openFileDialog1.FileName;
                writer.WriteStartElement("Imagee");
                writer.WriteString(image);
                writer.WriteEndElement();

                writer.WriteStartElement("Criminal");
                writer.WriteString("None");
                writer.WriteEndElement();


                writer.WriteEndElement();
                writer.WriteEndElement();

                writer.WriteEndDocument();
                writer.Close();
            }
            else
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("CRIMEDATA.xml");

                XmlElement crime = doc.CreateElement("crime");

                XmlElement node = doc.CreateElement("CrimeID");
                node.InnerText = Crime_ID;
                crime.AppendChild(node);

                node = doc.CreateElement("TypeID");
                node.InnerText = type_id;
                crime.AppendChild(node);

                node = doc.CreateElement("Status");
                node.InnerText = open;
                crime.AppendChild(node);

                node = doc.CreateElement("Area");
                node.InnerText = _location;
                crime.AppendChild(node);

                node = doc.CreateElement("Description");
                node.InnerText = _description;
                crime.AppendChild(node);

                node = doc.CreateElement("OfficerID");
                node.InnerText = _of_id;
                crime.AppendChild(node);

                node = doc.CreateElement("ItemsFound");
                foreach (string item in _items)
                {
                    if (_items.Count == 1)
                    {
                        node.InnerText += item;
                    }
                    else
                    {
                        node.InnerText += item + ",";
                    }
                }
                crime.AppendChild(node);

                node = doc.CreateElement("Suspect");
                foreach (var item in _suspects)
                {
                    if (_suspects.Count == 1)
                    {
                        node.InnerText += item;
                    }
                    else
                    {
                        node.InnerText += item + ",";
                    }

                }
                crime.AppendChild(node);

                //image
                //string imageText = openFileDialog1.FileName;
                node = doc.CreateElement("Imagee");
                node.InnerText = image;
                crime.AppendChild(node);

                node = doc.CreateElement("Criminal");
                node.InnerText = "None";
                crime.AppendChild(node);

                XmlElement root = doc.DocumentElement;

                root.AppendChild(crime);

                doc.Save("CRIMEDATA.xml");
            }

        }
        catch (Exception)
        {

        }
    }


    public void Update(string Crime_ID, string _location, string open, string _description, string _of_id, List<string> _items, List<string> _suspects)
    {
        try
        {
            // check el buttons htla2y comment
            XmlDocument doc = new XmlDocument();
            doc.Load("CRIMEDATA.xml");
            XmlElement editnode = doc.DocumentElement;

            foreach (XmlNode noe in editnode)
            {
                //3'aiaryy el textBox da b parameter lel function///////////////EL COMMENT
                if (noe["CrimeID"].InnerText == Crime_ID)
                {
                    noe["Status"].InnerText = open;
                    noe["Area"].InnerText = _location;
                    noe["Description"].InnerText = _description;
                    noe["OfficerID"].InnerText = _of_id;
                    for (int i = 0; i < _items.Count; i++)
                    {
                        noe["ItemsFound"].InnerText += "," + _items[i];
                    }

                    for (int j = 0; j < _suspects.Count; j++)
                    {
                        noe["Suspect"].InnerText += "," + _suspects[j];
                    }

                }
                break;

            }
            doc.Save("CRIMEDATA.xml");
        }
        catch (Exception)
        {

        }
    }


    public void Delete(string Crime_ID)
    {
        try
        {
            // check el buttons htla2y comment
            XmlDocument doc = new XmlDocument();
            doc.Load("CRIMEDATA.xml");
            XmlElement editnode = doc.DocumentElement;

            foreach (XmlNode noe in editnode)
            {
                if (noe["CrimeID"].InnerText == Crime_ID)
                {
                    noe.ParentNode.RemoveChild(noe);
                    break;
                }

            }
            // MessageBox.Show("Deleted");
            doc.Save("CRIMEDATA.xml");

        }
        catch (Exception)
        {

        }
    }

    class crime_type
    {
        public string id, name;
        public static int id_counter = 0;
        crime_type(string _id, string _name)
        {
            name = _name;
            id = _id;
        }

    }

}

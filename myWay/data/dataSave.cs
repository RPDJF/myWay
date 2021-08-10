using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using myWay.data;
using myWay.myClass;
using myWay.myComponents;

namespace myWay.data
{
    public class dataSave
    {
        // var
        private String savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\myWay\profiles\";
        private const String saveFilename = "default_profil.xml";
        // Save sections and their shortcuts
        public void saveSections()
        {
            initializeDirectories(); // create directory if don't exist
            using (XmlWriter writer = XmlWriter.Create(savePath + saveFilename))
            {
                writer.WriteStartElement("Sections");
                foreach(ucSections section in dataSections.GetSections())
                {
                    writer.WriteStartElement("section");
                    writer.WriteElementString("name", section.getName());
                    foreach(raccourcis raccourci in section.getRaccourcis())
                    {
                        writer.WriteStartElement("raccourci");
                        writer.WriteElementString("name", raccourci.getName());
                        writer.WriteElementString("description", raccourci.getDescription());
                        writer.WriteElementString("path", raccourci.getPath());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }
        // END - Save sections and their shortcuts
        public void exportData(String path)
        {
            initializeDirectories(); // create directory if don't exist
            using (XmlWriter writer = XmlWriter.Create(path))
            {
                writer.WriteStartElement("Sections");
                foreach (ucSections section in dataSections.GetSections())
                {
                    writer.WriteStartElement("section");
                    writer.WriteElementString("name", section.getName());
                    foreach (raccourcis raccourci in section.getRaccourcis())
                    {
                        writer.WriteStartElement("raccourci");
                        writer.WriteElementString("name", raccourci.getName());
                        writer.WriteElementString("description", raccourci.getDescription());
                        writer.WriteElementString("path", raccourci.getPath());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }
        // END - Save sections and their shortcuts
        // Import sections and their shortcuts
        public void importData()
        {
            initializeDirectories();
            try
            {
                foreach (XElement sections in XElement.Load(savePath + saveFilename).Elements("section"))
                {
                    ucSections mySection = new ucSections(sections.Element("name").Value);
                    dataSections.addSection(mySection);
                    foreach (XElement raccourcis in sections.Elements("raccourci"))
                    {
                        mySection.addShortcut(raccourcis.Element("name").Value, raccourcis.Element("path").Value, raccourcis.Element("description").Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bienvenue sur myWay !", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (XmlWriter writer = XmlWriter.Create(savePath + saveFilename))
                {
                    writer.WriteStartElement("Sections");
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
        }
        public void importData(String filePath)
        {
            initializeDirectories();
            try
            {
                foreach (XElement sections in XElement.Load(filePath).Elements("section"))
                {
                    ucSections mySection = new ucSections(sections.Element("name").Value);
                    if (dataSections.sectionExists(mySection))
                    {
                        var alert = MessageBox.Show("La section \""+ mySection.getName() +"\" existe déjà.\nLe programme n'est pas prévu pour avoir des noms de sections identiques.\n\nVoulez-vous tout de même continuer ?", "Exception", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(alert.ToString() == "No")
                        {
                            return;
                        }
                    }
                }
                foreach (XElement sections in XElement.Load(filePath).Elements("section"))
                {
                    ucSections mySection = new ucSections(sections.Element("name").Value);
                    dataSections.addSection(mySection);
                    foreach (XElement raccourcis in sections.Elements("raccourci"))
                    {
                        mySection.addShortcut(raccourcis.Element("name").Value, raccourcis.Element("path").Value, raccourcis.Element("description").Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Les données que vous essayez d'importer sont illisibles !", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            saveSections();
        }
        public void importOldData(String filePath, ucSections section)
        {
            FileStream myFileStream = new FileStream(filePath, FileMode.Open);
            StreamReader myStreamReader = new StreamReader(myFileStream, ASCIIEncoding.Default);
            int iteration = 1;
            String sLine = myStreamReader.ReadLine();
            String sName = null;
            String sPath = null;
            String sDesc = null;
            while (sLine != null)
            {
                switch (iteration)
                {
                    case 1:
                        sName = sLine;
                        break;
                    case 2:
                        sPath = sLine;
                        break;
                    case 3:
                        sDesc = sLine;
                        section.addShortcut(sName, sPath, sDesc);
                        iteration = 0;
                        break;
                    default:
                        break;
                }
                sLine = myStreamReader.ReadLine();
                iteration++;
            }
            myStreamReader.Close();
            myFileStream.Close();
            saveSections();
        }
        // END - Import sections and their shortcuts
        // Initialize directories
        public void initializeDirectories()
        {
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
        }
        // END - Initialize directories
       
    }
}

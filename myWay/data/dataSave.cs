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
        public String savePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\myWay\profiles\";
        private String settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\myWay\settings.xml";
        // Save sections and their shortcuts
        public void saveSections()
        {
            initializeDirectories(); // create directory if don't exist
            using (XmlWriter writer = XmlWriter.Create(savePath + dataTemp.profilName))
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
                try
                {
                    foreach (XElement setting in XElement.Load(settingsPath).Elements())
                    {
                        foreach (XElement categorie in setting.Elements("display"))
                        {
                            dataTemp.alwaysOnTop = Convert.ToBoolean(categorie.Element("alwaysontop").Value);
                            dataTemp.classicalWindowsForm = Convert.ToBoolean(categorie.Element("classicalwindowsform").Value);
                        }
                        foreach (XElement categorie in setting.Elements("profil"))
                        {
                            dataTemp.profilName = categorie.Element("selectedprofil").Value;
                        }
                    }
                }
                catch (Exception ex)
                {
                    saveSettings();
                    Console.WriteLine(ex);
                }
                foreach (XElement sections in XElement.Load(savePath + dataTemp.profilName).Elements("section"))
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
                using (XmlWriter writer = XmlWriter.Create(savePath + "default_profil.xml"))
                {
                    writer.WriteStartElement("Sections");
                    writer.WriteEndElement();
                    writer.Flush();
                }
                saveSettings();
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
        // Save Settings
        public void saveSettings()
        {
            using (XmlWriter writer = XmlWriter.Create(settingsPath))
            {
                writer.WriteStartElement("Settings");
                writer.WriteStartElement("general");
                writer.WriteStartElement("display");
                writer.WriteElementString("alwaysontop", dataTemp.alwaysOnTop.ToString());
                writer.WriteElementString("classicalwindowsform", dataTemp.classicalWindowsForm.ToString());
                writer.WriteEndElement();
                writer.WriteStartElement("profil");
                writer.WriteElementString("selectedprofil", dataTemp.profilName);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }
        }
        // END - Save Settings
        // Clear Data
        public void ClearData()
        {
            dataSections.ClearSection();
            dataTemp.selectedSection = null;
        }
        // END - Clear Data
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myWay.myComponents;

namespace myWay.data
{
    public class dataSections
    {
        // data
        private static List<ucSections> listSections = new List<ucSections>();

        // Getters
        public static List<ucSections> GetSections()
        {
            return listSections;
        }
        // End - Getters
        // Add section
        public static ucSections addSection(ucSections mySection)
        {
            mySection.Dock = System.Windows.Forms.DockStyle.Top;
            listSections.Add(mySection);
            return mySection;
        }
        public static ucSections addSection(String input)
        {
            ucSections mySection = new ucSections(input);
            return addSection(mySection);
        }
        // END - Add section
        // Remove specific section
        public static void removeSection(ucSections mySection)
        {
            listSections.Remove(mySection);
        }
        // END - Remove specific section
        // Check if section already exist
        public static Boolean sectionExists(ucSections inputSection)
        {
            foreach (ucSections mySection in GetSections())
            {
                if (mySection.getName() == inputSection.getName()) return true; // return true if find similar section on reference list
            }
            return false;
        }
        // END - Check if section already exist
        // Get section by name
        public static ucSections GetSectionByName(String name)
        {
            foreach(ucSections section in listSections)
            {
                if (name == section.getName()) return section;
            }
            return null;
        }
    }
}

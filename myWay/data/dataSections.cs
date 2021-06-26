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
        private static List<ucSections> listSections = new List<ucSections>();
        
        public static List<ucSections> GetSections()
        {
            return listSections;
        }
        // Add section
        // Object Sections
        public static void addSection(ucSections mySection)
        {
            listSections.Add(mySection);
        }
        // Generate new one
        public static void addSection(String input, System.Windows.Forms.DockStyle dock)
        {
            ucSections mySection = new ucSections(input);
            mySection.Dock = dock;
            listSections.Add(mySection);
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
                if (mySection.getValue() == inputSection.getValue()) return true; // return true if find similar section on reference list
            }
            return false;
        }
        // END - Check if section already exist
    }
}

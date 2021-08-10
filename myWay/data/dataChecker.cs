using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace myWay.data
{
    public class dataChecker
    {
        public Boolean validateSectionName(String input)
        {
            Char[] testChar = input.ToCharArray();
            if (data.dataSections.sectionExists(new myComponents.ucSections(input)))
            {
                MessageBox.Show("Impossible !\nUne séction du même nom existe déjà", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (input == null || input == "")
            {
                MessageBox.Show("Impossible !\nLe champ est requis", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (testChar[0] == ' ' || testChar[testChar.Length - 1] == ' ')
            {
                MessageBox.Show("Impossible !\nLa fin et le début ne doivent pas contenir d'espaces", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return true;
            }
            return false;
        }
        public Boolean validateProfilName(String input)
        {
            dataSave saver = new dataSave();
            Console.WriteLine(saver.savePath + input + ".xml");
            Char[] testChar = input.ToCharArray();
            if (input == null || input == "")
            {
                MessageBox.Show("Impossible !\nLe champ est requis", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (File.Exists(saver.savePath + input + ".xml")){
                MessageBox.Show("Impossible !\nUn profil du même nom existe déjà", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (testChar[0] == ' ' || testChar[testChar.Length - 1] == ' ')
            {
                MessageBox.Show("Impossible !\nLa fin et le début ne doivent pas contenir d'espaces", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}

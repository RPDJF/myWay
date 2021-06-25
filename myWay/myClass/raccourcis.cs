using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace myWay.myClass
{
    class raccourcis
    {
        // Properties
        private String name;
        private String description;
        private Color color;
        // EMD - Properties
        // Constructors
        public raccourcis(String name)
            : this(name, "")
        {

        }
        public raccourcis(String name, String description)
            : this(name, description, Color.MediumSlateBlue)
        {

        }
        public raccourcis(String name, String description, Color color)
        {
            this.name = name;
            this.description = description;
            this.color = color;
        }
        // END - Constructors
    }
}

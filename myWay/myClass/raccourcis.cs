using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace myWay.myClass
{
    public class raccourcis
    {
        // Properties
        private String name;
        private String description;
        private String path;
        private Color color;
        // EMD - Properties
        // Constructors
        public raccourcis(String name, String path)
            : this(name, path, "")
        {

        }
        public raccourcis(String name, String path, String description)
            : this(name, path, description, Color.MediumSlateBlue)
        {

        }
        public raccourcis(String name, String path, String description, Color color)
        {
            this.name = name;
            this.description = description;
            this.path = path;
            this.color = color;
        }
        // END - Constructors
        // Getters
        public String getName()
        {
            return name;
        }
        public String getDescription()
        {
            return description;
        }
        public String getPath()
        {
            return path;
        }
        // END - Getters
        // Setters
        public void setName(String name)
        {
            this.name = name;
        }
        public void setDescription(String description)
        {
            this.description = description;
        }
        public void setPath(String path)
        {
            this.path = path;
        }
        public void setColor(Color color)
        {
            this.color = color;
        }
    }
}

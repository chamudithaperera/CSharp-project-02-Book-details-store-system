using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mara_Publication
{
    public class Author
    {
        private string name;
        private string age;
        private DateTime dob;
        private string sex;
        private Image image;
        public Author(string name, string age, DateTime dob, string sex, Image image)
        {
            this.name = name;
            this.age = age;
            this.dob = dob;
            this.sex = sex;
            this.image = image;
        }

        public string Name
        {
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }
    }
}

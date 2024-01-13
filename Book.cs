using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mara_Publication
{
    
    public class Book
    {
        private string title;
        private string author;
        private string edition;
        private string price;
        private string noOfPages;
        private string noOfCopies;
        private Image image;

        public Book(string title, string author, string edition, string price, string noOfPages,string noOfCopies, Image image)
        {
            this.title = title;
            this.author = author;
            this.edition = edition;
            this.price = price;
            this.noOfPages = noOfPages;
            this.noOfCopies = noOfCopies;
            this.image = image;
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string Edition
        {
            get
            {
                return edition;
            }
            set
            {
                edition = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string NoOfPages
        {
            get
            {
                return noOfPages;
            }
            set
            {
                noOfPages = value;
            }
        }

        public string NoOfCopies
        {
            get
            {
                return noOfCopies;
            }
            set
            {
                noOfCopies = value;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Week3_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book(1, "Cool book"));
            books.Add(new Book(2, "Another Book"));
            books.Add(new Book(3, "Awesome Book"));
            books.Add(new Book(4, "Last Book"));

            using (XmlWriter writer = XmlWriter.Create("books.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Catalog");

                foreach (Book b in books)
                {
                    writer.WriteStartElement("Book");

                    writer.WriteElementString("ID", b.Id.ToString());
                    writer.WriteElementString("Title", b.Title);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}

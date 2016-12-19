using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace RemotelibServer
{
    /// <summary>
    /// Summary description for RemotelibService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class RemotelibService : System.Web.Services.WebService
    {
        private static readonly String FILE_NAME = @"C:\Users\ipd\Documents\2016-ipd8-webservices\RemotelibServer\RemotelibServer\data.txt";

        [WebMethod]
        public void AddBook(string title, string author, int yop)
        {
            //Console.WriteLine("called addBook()");

            String book = string.Format("{0};{1};{2}", title, author, yop);
            try
            {
                File.AppendAllText(FILE_NAME, book + Environment.NewLine);
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
                throw e;
            }
        }

        [WebMethod]
        public List<string> GetFilteredBooks(string keyword)
        {
            {
                //Console.WriteLine("called GetFilteredBooks()");

                try
                {
                    String[] lines = File.ReadAllLines(FILE_NAME);
                    List<string> bookList = new List<string>();
                    foreach (var book in lines)
                    {
                        if (book.ToLower().Contains(keyword.ToLower()))
                        {
                            bookList.Add(book);
                        }
                    }
                    return bookList;
                }
                catch (IOException e)
                {
                    Console.WriteLine(e);
                    Console.ReadKey();
                    throw e;
                }
            }
        }
    }
}

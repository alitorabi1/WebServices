using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LibService
{
    /// <summary>
    /// Summary description for LibWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class LibWebService : System.Web.Services.WebService
    {

        static String FILE_Name = @"C:\\Users\\ipd\\Documents\\WebServices\\LibService\\data.txt";

        [WebMethod]
        public int AddBook(String title, String author, int yop)
        {

            try
            {

                string book = String.Format("{0};{1};{2}", title, author, yop);
                // File.WriteAllText(FILE_Name, book);
                File.AppendAllText(FILE_Name, book + Environment.NewLine);
            }
            catch (IOException e)
            {
                throw e;
                // return -1;

            }
            return 0;
        }


        [WebMethod]
        public List<String> GetFilterListOfStrings(string keyword)
    {
        
        List<String> list = new List<String>();
        string[] fileLines;
        fileLines = File.ReadAllLines(FILE_Name);
        foreach (string line in fileLines)
        {
        if (line.ToLower().Contains(keyword.ToLower()))
            {
                list.Add(line);
            }
        }
        return list;
    }
    }
}

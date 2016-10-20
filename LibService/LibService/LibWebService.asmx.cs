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

        [WebMethod]
        public int addBook(String title, String author, int yop)
        {
            try (PrintWriter pw = new PrintWriter(new BufferedWriter(new FileWriter(FILE_NAME, true)))) {
                String book = String.format("%s;%s;%s", title, author, yop);
                pw.println(book);
                pw.close();
            } catch (IOException e) {
                e.printStackTrace();
                throw e;
            }
            return 0;
        }


        [WebMethod]
        public List<String> GetFilterListOfStrings(string keyword)
    {
        
        List<String> list = new List<String>();
        string[] fileLines;
        fileLines = File.ReadAllLines("C:\\Users\\ipd\\Documents\\WebServices\\LibService\\data.txt");
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

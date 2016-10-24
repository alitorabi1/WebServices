using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Quiz2People_Service
{
    /// <summary>
    /// Summary description for Quiz2WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Quiz2WebService : System.Web.Services.WebService
    {
        static String FILE_NAME = @"C:\Users\ipd\Documents\WebServices\quiz1people-server\data.txt";

        [WebMethod]
        public void addPerson(String name, int age, int height)
        {
            try
            {
                string person = String.Format("{0};{1};{2}", name, age, height);
                File.AppendAllText(FILE_NAME, person + Environment.NewLine);
            }
            catch (IOException e)
            {
                throw e;
            }

        }

        [WebMethod]
        public List<String> getPersons(String nameSearch, int minAge, int maxAge, int minHeight, int maxHeight) {
            List<string> persons = new List<string>();
            string line;
            try {
                using (System.IO.StreamReader file = new System.IO.StreamReader(FILE_NAME)) { 
                while ((line = file.ReadLine()) != null)
                {
                    string[] lineItems = line.Split(';');
                    String name = lineItems[0];
                    int age = int.Parse(lineItems[1]);
                    int height = int.Parse(lineItems[2]);
                    if (name.ToLower().Contains(nameSearch.ToLower())
                            && age >= minAge && age <= maxAge
                            && height >= minHeight && height <= maxHeight)
                    {
                        persons.Add(line);
                    }
                }
            }

            } catch (IOException e) {
                throw e;
                //return "";
            }
                return persons;
        }

    }
}

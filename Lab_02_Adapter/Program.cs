using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Linq;

namespace WzorzecAdapter
{
    //KOD Z ZEWNĘTRZNEJ BIBLIOTEKI
    public class UsersApi
    {
        public async Task<string> GetUsersXmlAsync()
        {
            var apiResponse = "<?xml version= \"1.0\" encoding= \"UTF-8\"?><users><user name=\"John\" surname=\"Doe\"/><user name=\"John\" surname=\"Wayne\"/><user name=\"John\" surname=\"Rambo\"/></users>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(apiResponse);

            return await Task.FromResult(doc.InnerXml);
        }
    }

    public class CsvReader
    {
        public string ReadCsvFile(string path)
        {
            return File.ReadAllText(path);
        }
    }

    public interface IUserRepository
    {
        List<List<string>> GetUserNames();
    }

    public class UsersApiAdapter : IUserRepository
    {
        private UsersApi _adapter = null;

        public UsersApiAdapter(UsersApi adapter)
        {
            _adapter = adapter;
        }

        public List<List<string>> GetUserNames()
        {
            string incompatibleApiResponse = this._adapter
              .GetUsersXmlAsync()
              .GetAwaiter()
              .GetResult();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(incompatibleApiResponse);

            var rootEl = doc.LastChild;

            List<List<string>> users = new List<List<string>>();

            if (rootEl.HasChildNodes)
            {
                List<string> user = new List<string> { };
                foreach (XmlNode node in rootEl.ChildNodes)
                {
                    user = new List<string> { node.Attributes["name"].InnerText, node.Attributes["surname"].InnerText };
                    users.Add(user);
                }
            }
            return users;
        }

    }

    public class UsersCsvAdapter : IUserRepository
    {
        private CsvReader _adapter = null;

        public UsersCsvAdapter(CsvReader adapter)
        {
            _adapter = adapter;
        }

        public List<List<string>> GetUserNames()
        {
            string csvFile = this._adapter
              .ReadCsvFile("users.csv");

            return csvFile.Split('\n').Select(x => x.Split(',').ToList()).ToList();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            UsersApi usersRepository = new UsersApi();
            IUserRepository adapter = new UsersApiAdapter(usersRepository);

            Console.WriteLine("Użytkownicy z API:");
            List<List<string>> users = adapter.GetUserNames();
            int i = 1;
            users.ForEach(user =>
            {
                Console.WriteLine($"{(i < 10 ? " " : "")}{i}. {user[0]} {user[1]}");
                i++;
            });

            Console.WriteLine();

            CsvReader csvReader = new CsvReader();
            IUserRepository csvAdapter = new UsersCsvAdapter(csvReader);

            Console.WriteLine("Użytkownicy z CSV:");
            List<List<string>> csvUsers = csvAdapter.GetUserNames();
            int j = 1;
            csvUsers.ForEach(user =>
            {
                Console.WriteLine($"{(j < 10 ? " " : "")}{j}. {user[0]} {user[1]}");
                j++;
            });
        }
    }
}
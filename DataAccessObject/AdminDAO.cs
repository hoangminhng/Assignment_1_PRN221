using System;
using System.Text.Json;
using System.IO;
using Business.ViewModels;

namespace DataAccessObject
{
    public class AdminDAO
    {
        private string fileName = "AdminInfo.json";

        public Admin GetDataFromFile()
        {
            Admin admin = new Admin();
            try
            {
                if (File.Exists(fileName))
                {
                    string jsonData = File.ReadAllText(fileName);
                    // Deserialize object graph into AdminFileData using System.Text.Json
                    var adminFileData = JsonSerializer.Deserialize<AdminFileData>(jsonData);

                    // Extract the DefaultUser property from AdminFileData
                    admin = adminFileData?.DefaultUser ?? new Admin();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;      
            }

            return admin;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.ApplicationServices;


namespace ClientRegistrationProgram
{
    internal class SaveLoad
    {
        public static void SaveToTxt(User User)
        {
            string filePath = "UserData.txt";
            using (StreamWriter writer = new StreamWriter(filePath, append: true)) ;

        }
        public static void LoadFromTxt()
        {
            string filePath = "UserData.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No user data found.");
            }
        }
        public static void SaveToJson(User User)
        {
            string filePath = "UserData.json";
            string jsonString = JsonSerializer.Serialize(User);
            File.WriteAllText(filePath, jsonString);
        }
        public static void LoadFromJson()
        {
            string filePath = "UserData.json";
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                User? user = JsonSerializer.Deserialize<User>(jsonString);
                if (user != null)
                {
                    Console.WriteLine(value: "Username: {user.Username}");
                    Console.WriteLine(value: "Password: {user.Password}");
                    Console.WriteLine(value: "Email: {user.Email}");
                    Console.WriteLine(value: "Date of Birth: {user.DateOfBirth.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine("Failed to load user data from JSON.");
                }
            }
            else
            {
                Console.WriteLine("No user data found.");
            }
        }
    }
}



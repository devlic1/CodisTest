using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.DAL
{
    class FileDb : IDataLogic
    {
        static readonly string path = CreateFileIfNotExists();

        /// <summary>
        /// Create file to store data is not exists
        /// </summary>
        /// <returns></returns>
        private static string CreateFileIfNotExists()
        {
            string filePath = System.Windows.Forms.Application.StartupPath + "\\Users.json";

            if (!File.Exists(filePath))
            {
                using (FileStream fs = File.Create(filePath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("[]");
                    fs.Write(info, 0, info.Length);
                }
            }

            return filePath;
        }

        /// <summary>
        /// Get User information using Primary key value
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public User GetUserInfo(Guid primaryKey)
        {
            string data = File.ReadAllText(path);
            User user = JsonConvert.DeserializeObject<List<User>>(data).Where(x => x.PrimaryKey == primaryKey).FirstOrDefault();
            return user;
        }

        /// <summary>
        /// Get all users information
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            string data = File.ReadAllText(path);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(data);
            return users ?? new List<User>();
        }

        /// <summary>
        /// Save All users information to file
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public bool SaveUsers(List<User> users)
        {
            string serializedData = JsonConvert.SerializeObject(users);
            File.WriteAllText(path, serializedData);
            return true;
        }

        /// <summary>
        /// Remove user as per primary key
        /// </summary>
        /// <param name="primaryKey"></param>
        /// <returns></returns>
        public bool RemoveUser(Guid primaryKey)
        {
            var users = GetAllUsers();
            users.RemoveAll(x => x.PrimaryKey == primaryKey);
            string serializedData = JsonConvert.SerializeObject(users);
            File.WriteAllText(path, serializedData);
            return true;
        }
    }
}

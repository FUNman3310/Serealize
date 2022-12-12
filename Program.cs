using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;


namespace Serialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Id = 800;
            user.Name = "Dzan";
            user.Username = "MinnaKUR";
            user.Surname = "akihira";

            //SerializeUserToBinary(user);

            //User user1 = DerializeBinaryToUser();


            //Console.WriteLine(user1);


        }
        public static void SerializeUserToBinary(User user)
        {
            string path = "C:\\Users\\Fuad\\Desktop\\newBinary.dat";
            Stream stream = new FileStream(path,FileMode.Create);

            BinaryFormatter binaryFormatter= new BinaryFormatter();
            binaryFormatter.Serialize(stream,user);
        }

        public static User DerializeBinaryToUser()
        {
            string path = "C:\\Users\\Fuad\\Desktop\\newBinary.dat";
            Stream stream = new FileStream(path, FileMode.Open);

            BinaryFormatter binaryFormatter= new BinaryFormatter();
            var user =  (User)binaryFormatter.Deserialize(stream);
            return user;
        }

        public static void SerializeUserToXml(User user)
        {
            string path = "C:\\Users\\Fuad\\Desktop\\newBinary.dat";
            Stream stream = new FileStream(path, FileMode.Create);

            XmlSerializer xmlSerializer= new XmlSerializer(typeof(User));
            xmlSerializer.Serialize(stream, user);
        }

        public static User DerializeXmlToUser()
        {
            string path = "C:\\Users\\Fuad\\Desktop\\newBinary.dat";
            Stream stream = new FileStream(path, FileMode.Open);

            XmlSerializer xmlSerializer= new XmlSerializer(typeof(User));
            var user = (User)xmlSerializer.Deserialize(stream);
            return user;
        }

        public static void SerializeUserToJson(User user)
        {
            string path = "C:\\Users\\Fuad\\Desktop\\newBinary.json";
            Stream stream = new FileStream(path, FileMode.Create);

            string filename = "User.json";
            string jsonString = JsonSerializer.Serialize(user);
            File.WriteAllText(filename, jsonString);

        }


    }
}
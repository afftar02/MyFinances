using Kursach_3_Sem.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Model
{
    public static class Data
    {
        public const string USERS_PATH = "users.xml";
        public const string CARDS_PATH = "cards.xml";

        public static List<User> users { get; private set; } = new List<User>();
        public static List<Card> cards { get; private set; } = new List<Card>();
    
        public static void Serialize()
        {
            var userSerializer = new DataContractSerializer(typeof(List<User>));
    
            using (var stream = new FileStream(USERS_PATH, FileMode.Create, FileAccess.Write))
            {
                using (var writer = XmlDictionaryWriter.CreateTextWriter(stream))
                {
                    userSerializer.WriteObject(writer, users);
                }
            }

            var cardSerializer = new DataContractSerializer(typeof(List<Card>));

            using (var stream = new FileStream(CARDS_PATH, FileMode.Create, FileAccess.Write))
            {
                using (var writer = XmlDictionaryWriter.CreateTextWriter(stream))
                {
                    cardSerializer.WriteObject(writer, cards);
                }
            }
        }
    
        public static void Deserialize()
        {
            var userSerializer = new DataContractSerializer(typeof(List<User>));
    
            using (var stream = new FileStream(USERS_PATH, FileMode.Open, FileAccess.Read))
            {
                using (var reader =
                            XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                {
                    users = (List<User>)userSerializer.ReadObject(reader);
                }
            }

            var cardSerializer = new DataContractSerializer(typeof(List<Card>));

            using (var stream = new FileStream(CARDS_PATH, FileMode.Open, FileAccess.Read))
            {
                using (var reader =
                            XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                {
                    cards = (List<Card>)cardSerializer.ReadObject(reader);
                }
            }
        }
    }
}

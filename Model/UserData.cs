using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    [DataContract]
    public class UserData
    {
        [DataMember]
        public string login { get; private set; }
        [DataMember]
        public string password { get; private set; }

        public UserData(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}

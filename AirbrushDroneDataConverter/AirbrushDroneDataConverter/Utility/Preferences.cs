using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace AirbrushDroneDataConverter.Utility
{
    [Serializable()]
    class Preferences : ISerializable
    {
        private const string FILE_PATH = "data/config.zut";

        private string _mailAddress = "";
        private int _userId = -1;
        private string _password = "";

        private string _lastUsedFilePath = "";

        static public Preferences LoadPreferences()
        {
            Preferences preferences = new Preferences();

            Stream stream = null;

            try
            {
                stream = File.Open(FILE_PATH, FileMode.Open);
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                if (stream != null)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    preferences = (Preferences)formatter.Deserialize(stream);
                    stream.Close();
                }
            }

            return preferences;
        }

        static public void SavePreferences(Preferences preferences)
        {
            Stream stream = File.Open(FILE_PATH, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, preferences);
            stream.Close();
        }

        public Preferences()
        {
        }

        public Preferences(SerializationInfo info, StreamingContext context)
        {
            _mailAddress = (string)info.GetValue("_mailAddress", typeof(string));
            _userId = (int)info.GetValue("_userId", typeof(int));
            _password = (string)info.GetValue("_password", typeof(string));
            _lastUsedFilePath = (string)info.GetValue("_lastUsedFilePath", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("_mailAddress", _mailAddress);
            info.AddValue("_userId", _userId);
            info.AddValue("_password", _password);
            info.AddValue("_lastUsedFilePath", _lastUsedFilePath);
        }

        public string MailAddress
        {
            get { return _mailAddress; }
            set { _mailAddress = value; }
        }

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string LastUsedFilePath
        {
            get { return _lastUsedFilePath; }
            set { _lastUsedFilePath = value; }
        }
    }
}

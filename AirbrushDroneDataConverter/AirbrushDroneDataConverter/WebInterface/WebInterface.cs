using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;

using Newtonsoft.Json;

namespace AirbrushDroneDataConverter.WebInterface
{
    class WebInterface
    {
        private static string ADDRESS_POST_FLIGHT = "http://airbrush.nucular-bacon.com/api/flight";
        private static string ADDRESS_POST_LOGIN = "http://airbrush.nucular-bacon.com/api/session";
        private static string ADDRESS_POST_GET_ID = "http://airbrush.nucular-bacon.com/api/user";

        private static string SESSION_KEY = "";

        public static int GetUserID(string mailAddress)
        {
            int result = -1;

            try
            {
                string postData = "?email=" + mailAddress;

                string response = SendGet(ADDRESS_POST_GET_ID + postData);

                JsonTextReader reader = new JsonTextReader(new StringReader(response));
                while (reader.Read())
                {
                    if (reader.Value != null)
                    {
                        if (reader.Value.ToString() == "id")
                        {
                            reader.Read();
                            result = int.Parse(reader.Value.ToString());
                        }
                    }
                }
            }
            catch(Exception exception)
            {

            }
            
            return result;
        }

        public static void Login(int userId, string password)
        {
            try
            {
                byte[] input = System.Text.UTF8Encoding.UTF8.GetBytes(password);
                byte[] output = SHA256.Create().ComputeHash(input);
                string passwordHash = BitConverter.ToString(output).Replace("-", "").ToLower();

                string postData = "id=" + userId.ToString() + "&password=" + passwordHash;

                string response = SendPost(ADDRESS_POST_LOGIN, postData);

                string searchString = "\"sessionkey\":\"";
                int idx = response.IndexOf(searchString);

                string sessionKey = response.Substring(idx + searchString.Length);
                sessionKey = sessionKey.Substring(0, sessionKey.Length - 2);

                SESSION_KEY = sessionKey;
            }
            catch (Exception exception)
            {

            }
        }

        public static void PostFlight(Flight.Flight flight)
        {
            try
            {
                string postData = flight.ToHTTP();
                Cookie cookie = null;

                if (SESSION_KEY.Length > 0)
                {
                    cookie = new Cookie("airbrush_session", SESSION_KEY);
                }

                SendPost(ADDRESS_POST_FLIGHT, postData, cookie);
            }
            catch (Exception exception)
            {

            }
        }

        public static void TestCookie()
        {
            try
            {
                Cookie cookie = new Cookie("test", "foo");

                String response = SendGet("http://airbrush.nucular-bacon.com/", "", cookie);

                System.Windows.Forms.MessageBox.Show(response);
            }
            catch (Exception exception)
            {

            }
        }

        public static void TestAccountCreation()
        {
            String name = "George";
            String surname = "Grumman";
            String email = "george@test.com";
            String password = "test";

            String postData = "name=" + name + "&surname=" + surname + "&email=" + email + "&password=" + password;

            SendPost("http://airbrush.nucular-bacon.com/api/user", postData);
        }

        private static string SendPost(string address, string postData = "", Cookie cookie = null)
        {
            string responseString = "POST Request failed";

            try
            {
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(address);

                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postData);

                httpRequest.Method = "POST";
                httpRequest.ContentType = "application/x-www-form-urlencoded";
                httpRequest.Accept = "application/json";
                httpRequest.ContentLength = data.Length;

                if (cookie != null)
                {
                    httpRequest.CookieContainer = new CookieContainer();
                    httpRequest.CookieContainer.Add(new Uri(address), cookie);
                }

                //System.Windows.Forms.MessageBox.Show(httpRequest.GetRequestStream().ToString());

                using (Stream stream = httpRequest.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch(Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);

                throw (exception);
            }

            return responseString;
        }

        private static string SendGet(string address, string postData = "", Cookie cookie = null)
        {
            string responseString = "POST Request failed";

            try
            {
                HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(address);

                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] data = encoding.GetBytes(postData);

                httpRequest.Method = "GET";
                httpRequest.ContentType = "application/x-www-form-urlencoded";
                httpRequest.Accept = "application/json";
                httpRequest.ContentLength = data.Length;

                if (cookie != null)
                {
                    httpRequest.CookieContainer = new CookieContainer();
                    httpRequest.CookieContainer.Add(new Uri(address), cookie);
                }

                HttpWebResponse response = (HttpWebResponse)httpRequest.GetResponse();
                responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception exception)
            {
                throw (exception);
            }

            return responseString;
        }
    }
}

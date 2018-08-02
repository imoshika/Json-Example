using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JsonExample
{
    public partial class UserDetailsControl1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserDetails userDetails = GetUserDetails();
            if (userDetails != null)
            {
                PopulateDetails(userDetails);
            }
        }

        private UserDetails GetUserDetails()
        {
            string url = "https://jsonplaceholder.typicode.com/todos/1";
            WebRequest request = WebRequest.Create(new Uri(url));
            UserDetails details = null;

            Stream dataStream = null;
            try
            {
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                string jsonString;
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    jsonString = reader.ReadToEnd();
                }

                if (!string.IsNullOrEmpty(jsonString))
                {
                    details = JsonConvert.DeserializeObject<UserDetails>(jsonString);
                }


            }
            catch (WebException ex)
            {
            }

            return details;
        }

        private void PopulateDetails(UserDetails userDetails)
        {
            userid.Text = userDetails.UserId.ToString();
            id.Text = userDetails.Id.ToString();
            title.Text = userDetails.Title;
            completed.Text = userDetails.Completed;
        }
    }
}
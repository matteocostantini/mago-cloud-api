using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataServiceWinForm
{
    public partial class MainForm : Form
    {
        private string AuthenticationToken = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            tbxRootURL.Text = Properties.Settings.Default.RootURL;
            tbxAccountName.Text = Properties.Settings.Default.AccountName;
            tbxPassword.Text = Properties.Settings.Default.Password;
            tbxSubscription.Text = Properties.Settings.Default.subscriptionkey;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (AuthenticationToken != string.Empty)
            {
                MessageBox.Show("already connected");
                return;
            }

            if (tbxAccountName.Text == string.Empty || tbxRootURL.Text == string.Empty || tbxSubscription.Text == string.Empty)
            {
                MessageBox.Show("missing connection data");
                return;
            }

            using (var msg = new HttpRequestMessage())
            {
                var loginData = JsonConvert.SerializeObject(new
                {
                    AccountName = tbxAccountName.Text,
                    Password = tbxPassword.Text,
                    AppId = "M4",
                    subscriptionkey = tbxSubscription.Text
                });

                msg.RequestUri = new Uri(new Uri(tbxRootURL.Text), "account-manager/login");
                msg.Method = HttpMethod.Post;
                msg.Headers.TryAddWithoutValidation("Content-Type", "application/json");
                msg.Content = new StringContent(content: loginData, encoding: Encoding.UTF8, mediaType: "application/json");

                HttpClient httpClient = new HttpClient();
                using (var response = httpClient.SendAsync(msg).Result)
                {
                    string result = response.Content.ReadAsStringAsync().Result;

                    if (string.IsNullOrEmpty(result))
                    {
                        tbxMessages.Text = "Invalid login";
                        return;
                    }

                    JObject jResult = JsonConvert.DeserializeObject<JObject>(result);

                    int resultCode = int.Parse(jResult["ResultCode"]?.ToString());
                    if (resultCode != 0)
                    {
                        tbxMessages.Text = jResult["Message"]?.ToString();
                        return;
                    }

                    string token = jResult["JwtToken"]?.ToString();
                    if (string.IsNullOrEmpty(token))
                    {
                        tbxMessages.Text = "Invalid login";
                        return;
                    }

                    AuthenticationToken = token.ToString();

                    tbxMessages.Text = "Connected succesfully!";
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.RootURL = tbxRootURL.Text;
            Properties.Settings.Default.AccountName = tbxAccountName.Text;
            Properties.Settings.Default.Password = tbxPassword.Text;
            Properties.Settings.Default.subscriptionkey = tbxSubscription.Text;

            Properties.Settings.Default.Save();
        }

        private void btnGetItems_Click(object sender, EventArgs e)
        {
            if (AuthenticationToken == string.Empty)
            {
                MessageBox.Show("not yet connected");
                return;
            }

            var authorizationData = JsonConvert.SerializeObject(new
            {
                Type = "JWT",
                SecurityValue = AuthenticationToken
            });

            Cursor.Current = Cursors.WaitCursor;
            using (var msg = new HttpRequestMessage())
            {
                UriBuilder uri = new UriBuilder(new Uri(new Uri(tbxRootURL.Text), "data-service/getdata/ERP.Items.Dbl.Items/default"));
                if (tbxFilter.Text != string.Empty)
                {
                    uri.Query = $"filter={tbxFilter.Text}";
                }
                msg.RequestUri = uri.Uri;
                msg.Method = HttpMethod.Get;
                msg.Headers.TryAddWithoutValidation("Authorization", authorizationData);
                msg.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                HttpClient httpClient = new HttpClient();
                using (var response = httpClient.SendAsync(msg).Result)
                {
                    string result = response.Content.ReadAsStringAsync().Result;

                    if (string.IsNullOrEmpty(result))
                    {
                        tbxMessages.Text = "Invalid response";
                        Cursor.Current = Cursors.Default;
                        return;
                    }

                    tbxData.Text = result;
                }

            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (AuthenticationToken == string.Empty)
            {
                MessageBox.Show("not yet connected");
                return;
            }
            try
            {
                using (var msg = new HttpRequestMessage())
                {
                    var authorizationData = JsonConvert.SerializeObject(new
                    {
                        Type = "JWT",
                        SecurityValue = AuthenticationToken
                    });

                    msg.RequestUri = new Uri(new Uri(tbxRootURL.Text), "account-manager/logoff/");
                    msg.Method = HttpMethod.Post;
                    msg.Headers.TryAddWithoutValidation("Authorization", authorizationData);
                    msg.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                    HttpClient httpClient = new HttpClient();
                    using (var response = httpClient.SendAsync(msg).Result)
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            tbxMessages.Text = "Request failed: " + response.ReasonPhrase;
                            AuthenticationToken = "";
                            return;
                        }

                        string result = response.Content.ReadAsStringAsync().Result;

                        if (string.IsNullOrEmpty(result))
                        {
                            tbxMessages.Text = "Invalid response";
                            AuthenticationToken = "";
                            return;
                        }

                        JObject jResult = JsonConvert.DeserializeObject<JObject>(result);
                        JToken ok = jResult["Result"];
                        bool bOk = ok == null ? false : ok.Value<bool>();

                        if (bOk)
                        {
                            tbxMessages.Text = "User successfully logged out";
                        }
                        else
                        {
                            tbxMessages.Text = "Logout failed";
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                tbxMessages.Text = $"Error during logout {exception.Message}";
            }

            AuthenticationToken = "";
        }
    }
}

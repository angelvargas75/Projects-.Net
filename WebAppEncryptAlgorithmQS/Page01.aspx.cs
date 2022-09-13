using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WebApplication5
{
    public partial class Page01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit(object sender, EventArgs e)
        {
            string name = HttpUtility.UrlEncode(Encrypt(txtName.Text.Trim()));
            string technology = HttpUtility.UrlEncode(Encrypt(ddlTechnology.SelectedItem.Value));
            Response.Redirect(string.Format("~/Page02.aspx?name={0}&technology={1}", name, technology));
        }

        private string Encrypt(string clearText)
        {
            string encriptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);

            using (Aes encryptor=Aes.Create())
            {
                Rfc2898DeriveBytes pbd = new Rfc2898DeriveBytes(encriptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
                });
                encryptor.Key = pbd.GetBytes(32);
                encryptor.IV = pbd.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
    }
}
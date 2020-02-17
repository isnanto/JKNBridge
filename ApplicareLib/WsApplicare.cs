using System;
using System.IO;
using System.Text;
using System.Net;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Data;

namespace JKNBridge.ApplicareLib
{
    public class WsApplicare
    {
        public static long ConvertToTimeStamp(DateTime value)
        {
            DateTime time = DateTime.SpecifyKind(new DateTime(0x7B2, 1, 1), DateTimeKind.Utc);
            TimeSpan span = (TimeSpan)(value.ToUniversalTime() - time);
            return System.Convert.ToInt64(Math.Floor(span.TotalSeconds));
        }

        public static string GenerateSignature(string sConsumerId, string sPassword, string sTimeStamp)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = encoding.GetBytes(sPassword);
            string s = (sConsumerId + "&" + sTimeStamp);
            byte[] buffer = encoding.GetBytes(s);
            using (HMACSHA256 hmacsha = new HMACSHA256(bytes))
            {
                return Convert.ToBase64String(hmacsha.ComputeHash(buffer));
            }
        }


        public static WsResponse HapusRuang(string sURL, string sKodeKelas, string sKodeRuang, string sKodePPK, string ConsID, string consPass, DateTime dtStamp)
        {
            string URL = string.Concat(sURL, "rest/bed/delete/", sKodePPK);
            string sTimeStamp = ConvertToTimeStamp(dtStamp).ToString();
            string str2 = GenerateSignature(ConsID, consPass, sTimeStamp);
            var request = WebRequest.Create(URL); // DirectCast(WebRequest.Create(sURL), HttpWebRequest)
            var cache = new CredentialCache();
            string sPostData;
            var sReq = new StringBuilder();
            var iTems = new WsResponse();

            sReq.Append("{");
            sReq.Append((char)34 + "kodekelas" + (char)34 + ":" + (char)34 + sKodeKelas + (char)34 + ",");
            sReq.Append((char)34 + "koderuang" + (char)34 + ":" + (char)34 + sKodeRuang + (char)34 + "}");

            sPostData = sReq.ToString();

            var byteArray = Encoding.UTF8.GetBytes(sPostData);

            request.Method = "POST";
            // request.KeepAlive = True
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            request.Credentials = cache;

            request.Headers.Add("X-cons-id", ConsID);
            request.Headers.Add("X-timestamp", sTimeStamp);
            request.Headers.Add("X-signature", str2);
            try
            {
                var oStream = request.GetRequestStream();
                oStream.Write(byteArray, 0, byteArray.Length);
                oStream.Close();

                WebResponse response = (HttpWebResponse)request.GetResponse();  // request.GetResponse()  '
                response = request.GetResponse() as HttpWebResponse;

                var enc = Encoding.GetEncoding(1252);
                var loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                string stext = loResponseStream.ReadToEnd();

                iTems = JsonConvert.DeserializeObject<WsResponse>(stext);
                // Return stext

                return iTems;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            // Return sText

            return iTems;
        }


        public static WsResponse RuanganBaru(string sURL, string sKodeKelas, string sKodeRuang, string sNamaRuang, string sKapasitas, string sTersedia, string sTersediaPria, string sTersediaWanita, string sTersediaPriaWanita, string ConsID, string consPass, DateTime dtStamp)
        {
            string sReturn = "InValid";

            // Dim DSet As New DataSet
            string sTimeStamp = ConvertToTimeStamp(dtStamp).ToString();
            string str2 = GenerateSignature(ConsID, consPass, sTimeStamp);
            WebRequest request = WebRequest.Create(sURL); // DirectCast(WebRequest.Create(sURL), HttpWebRequest)
            CredentialCache cache = new CredentialCache();
            string sPostData;
            StringBuilder sReq = new StringBuilder();
            WsResponse iTems = new WsResponse();


            sReq.Append("{");
            sReq.Append((char)34 + "kodekelas" + (char)34 + ":" + (char)34 + sKodeKelas + (char)34 + ",");
            sReq.Append((char)34 + "koderuang" + (char)34 + ":" + (char)34 + sKodeRuang + (char)34 + ",");
            sReq.Append((char)34 + "namaruang" + (char)34 + ":" + (char)34 + sNamaRuang + (char)34 + ",");
            sReq.Append((char)34 + "kapasitas" + (char)34 + ":" + (char)34 + sKapasitas + (char)34 + ",");
            sReq.Append((char)34 + "tersedia" + (char)34 + ":" + (char)34 + sTersedia + (char)34 + ",");
            sReq.Append((char)34 + "tersediapria" + (char)34 + ":" + (char)34 + sTersediaPria + (char)34 + ",");
            sReq.Append((char)34 + "tersediawanita" + (char)34 + ":" + (char)34 + sTersediaWanita + (char)34 + ",");
            sReq.Append((char)34 + "tersediapriawanita" + (char)34 + ":" + (char)34 + sTersediaPriaWanita + (char)34 + "}");

            sPostData = sReq.ToString();

            // MessageBox.Show(sPostData)

            byte[] byteArray = Encoding.UTF8.GetBytes(sPostData);

            request.Method = "POST";
            // request.KeepAlive = True
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            request.Credentials = cache;

            request.Headers.Add("X-cons-id", ConsID);
            request.Headers.Add("X-timestamp", sTimeStamp);
            request.Headers.Add("X-signature", str2);
            try
            {
                Stream oStream = request.GetRequestStream();
                oStream.Write(byteArray, 0, byteArray.Length);
                oStream.Close();

                WebResponse response = (HttpWebResponse)request.GetResponse();  // request.GetResponse()  '
                response = request.GetResponse() as HttpWebResponse;

                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                string stext = loResponseStream.ReadToEnd();

                iTems = JsonConvert.DeserializeObject<WsResponse>(stext);
                 
                return iTems;
            }
            catch (Exception exception)
            {
                throw exception;
               
            }
           
            return iTems;
        }

        public static WsResponse UpdateRuang(string sURL, string sKodeKelas, string sKodeRuang, string sNamaRuang, string sKapasitas, string sTersedia, string sTersediaPria, string sTersediaWanita, string sTersediaPriaWanita, string ConsID, string consPass, DateTime dtStamp)
        {
            string sReturn = "InValid";

            // Dim DSet As New DataSet
            string sTimeStamp = ConvertToTimeStamp(dtStamp).ToString();
            string str2 = GenerateSignature(ConsID, consPass, sTimeStamp);
            WebRequest request = WebRequest.Create(sURL); // DirectCast(WebRequest.Create(sURL), HttpWebRequest)
            CredentialCache cache = new CredentialCache();
            string sPostData;
            StringBuilder sReq = new StringBuilder();
            WsResponse iTems = new WsResponse();


            sReq.Append("{");
            sReq.Append((char)34 + "kodekelas" + (char)34 + ":" + (char)34 + sKodeKelas + (char)34 + ",");
            sReq.Append((char)34 + "koderuang" + (char)34 + ":" + (char)34 + sKodeRuang + (char)34 + ",");
            sReq.Append((char)34 + "namaruang" + (char)34 + ":" + (char)34 + sNamaRuang + (char)34 + ",");
            sReq.Append((char)34 + "kapasitas" + (char)34 + ":" + (char)34 + sKapasitas + (char)34 + ",");
            sReq.Append((char)34 + "tersedia" + (char)34 + ":" + (char)34 + sTersedia + (char)34 + ",");
            sReq.Append((char)34 + "tersediapria" + (char)34 + ":" + (char)34 + sTersediaPria + (char)34 + ",");
            sReq.Append((char)34 + "tersediawanita" + (char)34 + ":" + (char)34 + sTersediaWanita + (char)34 + ",");
            sReq.Append((char)34 + "tersediapriawanita" + (char)34 + ":" + (char)34 + sTersediaPriaWanita + (char)34 + "}");

            sPostData = sReq.ToString();

            // MessageBox.Show(sPostData)

            byte[] byteArray = Encoding.UTF8.GetBytes(sPostData);

            request.Method = "POST";
            // request.KeepAlive = True
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            request.Credentials = cache;


            request.Headers.Add("X-cons-id", ConsID);
            request.Headers.Add("X-timestamp", sTimeStamp);
            request.Headers.Add("X-signature", str2);
            try
            {
                Stream oStream = request.GetRequestStream();
                oStream.Write(byteArray, 0, byteArray.Length);
                oStream.Close();

                WebResponse response = (HttpWebResponse)request.GetResponse();  // request.GetResponse()  '
                response = request.GetResponse() as HttpWebResponse;

                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                string stext = loResponseStream.ReadToEnd();

                iTems = JsonConvert.DeserializeObject<WsResponse>(stext);
                // Return stext

                return iTems;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            // Return sText

            return iTems;
        }


        public static string ReferensiKamar(string uriStr, string consId, string consPass, DateTime dtStamp) // DetailSEP
        {
            string sReturn = "InValid";
            string sText = "";
            DataSet DSet = new DataSet();
            string sTimeStamp = ConvertToTimeStamp(dtStamp).ToString();
            string str2 = GenerateSignature(consId, consPass, sTimeStamp);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uriStr);
            CredentialCache cache = new CredentialCache();
            WsResponse iTems = new WsResponse();

            request.Method = "GET";
            request.KeepAlive = true;

            request.Credentials = cache;
            request.Headers.Add("X-cons-id", consId);
            request.Headers.Add("X-timestamp", sTimeStamp);
            request.Headers.Add("X-signature", str2);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response = request.GetResponse() as HttpWebResponse;
                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);

                // Dim stext As String = loResponseStream.ReadToEnd()
                // iTems = JsonConvert.DeserializeObject(Of DetailSEP)(stext)
                sText = loResponseStream.ReadToEnd();
            }

            catch (Exception exception)
            {
                throw exception;
            }
            return sText;
        }
    }

}
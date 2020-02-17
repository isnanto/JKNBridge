using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sisrute
{
    /// <summary>
    /// Berisi fungsi resume medis
    /// </summary>
    public class ResumeMedis
    {
        /// <summary>
        /// Mengirim data resume medis ke server kemenkes
        /// </summary>
        /// <param name="dataResume">Objek data resume medis</param>
        /// <param name="sConsID">ConsID dari kemenkes</param>
        /// <param name="sPass">Password dari kemenkes</param>
        /// <returns></returns>
        public static PostResumeResponse wsKirim(PostResume dataResume, string sConsID, string sPass)
        {
            //Base URL : https://sisrute.kemkes.go.id/baru/index_ci.php/services/
            //End Point : resumemedis/resume

            PostResumeResponse responKirim = new PostResumeResponse();
            try
            {

                string sTimeStamp = Signature.ConvertToTimeStamp(DateTime.Now).ToString();
                string str2 = Signature.GenerateSignature(sConsID, sPass, sTimeStamp);
                WebRequest request = WebRequest.Create(BaseVar.BaseURL+ "resume/save_resume");
                CredentialCache cache = new CredentialCache();
                string sPostData;
                StringBuilder sReq = new StringBuilder();
               
                sPostData = JsonConvert.SerializeObject(dataResume);
                byte[] byteArray = Encoding.UTF8.GetBytes(sPostData);

                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                request.Credentials = cache;
                request.Headers.Add("X-cons-id", sConsID);
                request.Headers.Add("X-timestamp", sTimeStamp);
                request.Headers.Add("X-signature", str2);

           
                Stream oStream = request.GetRequestStream();
                oStream.Write(byteArray, 0, byteArray.Length);
                oStream.Close();
                WebResponse response = request.GetResponse();
                //response = request.GetResponse as HttpWebResponse;

                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                string stext = loResponseStream.ReadToEnd();


                responKirim = JsonConvert.DeserializeObject<PostResumeResponse>(stext);

                return responKirim;

                //return true;
            }
            catch (Exception exception)
            {
                throw new Exception("Pengiriman Resume Medis gagal. \n" + exception.Message);
            }

            //return responKirim;
        }

        public static string  wsCari(GetResume getResume, string sConsID, string sPass)
        {
            try
            {

                string sTimeStamp = Signature.ConvertToTimeStamp(DateTime.Now).ToString();
                string str2 = Signature.GenerateSignature(sConsID, sPass, sTimeStamp);
                WebRequest request = WebRequest.Create(BaseVar.BaseURL + "resume/load_resume");
                CredentialCache cache = new CredentialCache();
                string sPostData;
                StringBuilder sReq = new StringBuilder();

                sPostData = JsonConvert.SerializeObject(getResume);
                byte[] byteArray = Encoding.UTF8.GetBytes(sPostData);

                request.Method = "POST";
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                request.Credentials = cache;
                request.Headers.Add("X-cons-id", sConsID);
                request.Headers.Add("X-timestamp", sTimeStamp);
                request.Headers.Add("X-signature", str2);

                Stream oStream = request.GetRequestStream();
                oStream.Write(byteArray, 0, byteArray.Length);
                oStream.Close();
                WebResponse response = request.GetResponse();
                //response = request.GetResponse as HttpWebResponse;

                Encoding enc = System.Text.Encoding.GetEncoding(1252);
                StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                string stext = loResponseStream.ReadToEnd();

            //request.Credentials = cache;
            //request.Headers.Add("X-cons-id", sConsID);
            //request.Headers.Add("X-timestamp", sTimeStamp);
            //request.Headers.Add("X-signature", str2);
            
                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                ////response = request.GetResponse as HttpWebResponse;

                //Encoding enc = System.Text.Encoding.GetEncoding(1252);
                //StreamReader loResponseStream = new StreamReader(response.GetResponseStream(), enc);
                //string stext = loResponseStream.ReadToEnd();
                
                return stext;
            }
            catch (Exception exception)
            {
                throw new Exception("Pencarian Reseume Medis gagal. \n" +   exception.Message);
            }
            return "";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CsQuery;
using CsQuery.Web;
using HttpWebAdapters;
using xNet;

namespace AviParse
{
    class Program
    {
        static void Main(string[] args)
        {
            String Url = "https://www.avito.ru/ufa/kvartiry/sdam/na_dlitelnyy_srok";
            Console.WriteLine("Загрузка страницы");
            try
            {
                WebRequest wr = WebRequest.Create(Url);
                wr.Proxy = new WebProxy("10.0.25.3");
                WebResponse wrp = wr.GetResponse();
                //Uri uri = new Uri(Url);
                //String html = new WebClient().DownloadString(uri);
                //var request = new CsqWebRequest(Url);
                //IHttpWebRequest httpWebRequest = request.GetWebRequest();
                //var html = request.Get(httpWebRequest);
                //var dom = CQ.CreateFromUrl(content);
                Console.WriteLine("Страница загружена");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка загрузки. "+e.ToString());
            }
            Console.ReadKey();
        }
    }
}

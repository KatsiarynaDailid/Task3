using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.WebDriver
{
    class WebDr
    {

        /*
         d.	Класс для инициализации веб-драйвера
            i.	Проверка вариантов браузера – switch case
            ii.	Браузер считывается из конфига
            iii.	Имя браузера сохраняется в виде перечисления
        */


        public String browser = Convert.ToString(ConfigurationManager.AppSettings["Browser"]);

        public WebDr()
        {

            switch (browser)
            {

                case "Chrome":

                    //initialization
                    break;
                case "Firefox":
                    //initialization
                    break;
                case "IE":
                    //initialization
                    break;
                case "Opera":
                    //initialization
                    break;
                
                default:
                
                    break;

            }

        }
    }
}

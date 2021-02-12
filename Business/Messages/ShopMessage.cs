using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class ShopMessage
    {
        public static string AddMessage()
        {
            return "Kitabevi bilgileri başarıyla kaydedilmiştir.";
        }
        public static string UpdateMessage()
        {
            return "Kitabevi bilgileri başarıyla güncellenmiştir.";
        }
        public static string DeleteMessage()
        {
            return "Kitabevi bilgileri başarıyla silinmiştir.";
        }
    }
}

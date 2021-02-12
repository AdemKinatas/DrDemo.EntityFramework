using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class BookMessage
    {
        public static string AddMessage()
        {
            return "Kitap bilgileri başarıyla kaydedilmiştir.";
        }
        public static string UpdateMessage()
        {
            return "Kitap bilgileri başarıyla güncellenmiştir.";
        }
        public static string DeleteMessage()
        {
            return "Kitap bilgileri başarıyla silinmiştir.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class AuthorMessage
    {
        public static string AddMessage()
        {
            return "Yazar bilgileri başarıyla kaydedilmiştir.";
        }
        public static string UpdateMessage()
        {
            return "Yazar bilgileri başarıyla güncellenmiştir.";
        }
        public static string DeleteMessage()
        {
            return "Yazar bilgileri başarıyla silinmiştir.";
        }
    }
}

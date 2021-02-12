using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class PublisherMessage
    {
        public static string AddMessage()
        {
            return "Yayınevi bilgileri başarıyla kaydedilmiştir.";
        }
        public static string UpdateMessage()
        {
            return "Yayınevi bilgileri başarıyla güncellenmiştir.";
        }
        public static string DeleteMessage()
        {
            return "Yayınevi bilgileri başarıyla silinmiştir.";
        }
    }
}

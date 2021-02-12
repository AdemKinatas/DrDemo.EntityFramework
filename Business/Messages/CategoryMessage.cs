using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class CategoryMessage
    {
        public static string AddMessage()
        {
            return "Kategori bilgileri başarıyla kaydedilmiştir.";
        }
        public static string UpdateMessage()
        {
            return "Kategori bilgileri başarıyla güncellenmiştir.";
        }
        public static string DeleteMessage()
        {
            return "Kategori bilgileri başarıyla silinmiştir.";
        }
    }
}

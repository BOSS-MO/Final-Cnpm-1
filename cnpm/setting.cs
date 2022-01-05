using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnpm
{
    class setting
    {
        public static void suaChuoi(ref string chuoi) {
            string resultName = "";

            // Loại bỏ khoảng trắng ở đầu chuỗi
            chuoi = chuoi.Trim();

            // loại bỏ khoảng trắng thừa ở giữa các từ , chuyển thành 1 khoảng trắng
            while(chuoi.IndexOf("   ") != -1)
            {
                chuoi = chuoi.Replace("  ", "  ");
            }

            // sao chép các kí tự vào 1 chuỗi
            string[] arrayName = chuoi.Split(' ');

            // duyệt các phần tử trong mảng , chuyển kí tự đầu tiên thành chữ in hoa , còn lại thành chữ thường 
            for (int i  = 0; i < arrayName.Length; i++)
            {
                arrayName[i] = arrayName[i].Substring(0, 1).ToUpper() + arrayName[i].Substring(1).ToLower();
                resultName += arrayName[i].ToString() + " ";
            }

            chuoi = resultName;
        }
    }
}

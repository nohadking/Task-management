using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domin.Entity
{
    public class TBOrderOnline
    {
        [Key]
        public int IdOrderOnline { get; set; }//الرقم التا=لقائي
        public int IdInvose { get; set; }//رقم الفاتورة المحفوظة مسبقا 
        public string UserId { get; set; }//id العميل  من النظام 
        public int IdTypeOrder { get; set; }//حالة الاوردر 
        public int TotalQuantity { get; set; }//إجمالي الكمية 
        public decimal TotalPrice { get; set; }//إجمالي السعر 
        public string? Nouts { get; set; }//ملاحظات 
        public string DataEntry { get; set; }//مدخل البيانات 
        public DateTime DateTimeEntry { get; set; }//وقت وتاريخ الادخال
        public bool CurrentState { get; set; }// الحالة 
        public string ReceivingMethod { get; set; }//أسلوب الاستلام 




    }
}

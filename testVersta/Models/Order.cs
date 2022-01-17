using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVersta.Models
{
    public class Order
    {
        [Required]
        [Display(Name = "Номер заказа")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Не указан город отправителя")]
        [Display(Name = "Город отправителя")]
        public string Senderscity { get; set; }
        [Required(ErrorMessage = "Не указан адрес отправителя")]
        [Display(Name = "Адрес отправителя")]
        public string Sendersaddress { get; set; }
        [Required(ErrorMessage = "Не указан город получателя")]
        [Display(Name = "Город получателя")]
        public string Recipientscity { get; set; }
        [Required(ErrorMessage = "Не указан адрес получателя")]
        [Display(Name = "Адрес получателя")]
        public string Recipientaddress { get; set; }
        [Required(ErrorMessage = "Не указан вес груза")]
        [Display(Name = "Вес груза")]
        public double? Weight { get; set; }
        [Required(ErrorMessage = "Не указана дата забора груза")]
        [Display(Name = "Дата забора груза")]
        public DateTime? Date { get; set; }
    }
}

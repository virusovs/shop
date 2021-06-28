using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_3_1.Models
{
    public class Order
    {
        
 public int OrderId { get; set; }
 public int Width { get; set; } //Ширина
 public int Height { get; set; } //Висота
 public string Control { get; set; } //Сторона керування


 public string Userr { get; set; } //Имя фамилия покупателя
 public string Address { get; set; } //Адрес покупателя
 public string Email { get; set; } //Email покупателя
 public string ContactPhone { get; set; } //Контактный  телефон покупателя
 public int JaluziId { get; set; } //Ссылка на идентификатор  жалюзи горизонтальные
  public Jaluzi Jaluzi { get; set; } //Создание ключа на таблицу jaluzi
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_3_1.Models;


namespace MVC_3_1
{
    public class SampleData
    {
      
        public static void Initialize(JaluziContext context)
        {
            if (!context.Jaluzis.Any())
            {
                context.Jaluzis.AddRange(new Jaluzi
                {
                   ColorNumber= "201"  ,
                    Color = "Білий"   ,
                    Img ="/img/201.jpg" ,
                    Price = 230
                },
                new Jaluzi
                {
                    ColorNumber = "202",
                    Color = "Слонова кістка",
                    Img = "/img/202.jpg",
                    Price = 260
                },
                new Jaluzi
                {
                    ColorNumber = "17",
                    Color = "Коричневий",
                    Img = "/img/17.jpg",
                    Price = 260
                });
                context.SaveChanges();
            }
        }
      
    }
}


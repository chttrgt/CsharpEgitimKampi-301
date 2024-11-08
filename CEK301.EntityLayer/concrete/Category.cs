using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEK301.EntityLayer.concrete
{

    /*
        Field - Variable - Property
    
        Bir sınıfın içerisinde tanımlanan int x; şeklindeki yapıya FIELD denir.
        Bir sınıfın içerisindeki metod içinde tanımlanan void test(){int y;} şeklindeki yapıya VARIABLE denir.
        Bir sınıfın içerisinde kullanılan public int z {get; set;} şeklinde kullanılan yapıya da PROPERTY denir.

    !!!Not: CodeFirst yaklaşımında tanımlanan property'nin veritabanında birincil anahtar ve otomatik olarak artan 
            olabilmesi için oluşturulan ilgili property'nin ismi sınıf ismi ile aynı olmalı ve sonunda Id yazmalıdır.
            public int CategoryId { get; set; }  --> bu şekilde olmalıdır.
     
    */


    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}

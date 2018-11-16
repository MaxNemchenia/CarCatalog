using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace TestWF.Models
{
    public class Initializer : DropCreateDatabaseAlways<CarContext>
    {
        protected override void Seed(CarContext db)
        {
            var BMV = new Producer { ProducerId = 1, ProducerName = "BMV" };
            var Geely = new Producer { ProducerId = 2, ProducerName = "Geely" };
            var Mazda = new Producer { ProducerId = 3, ProducerName = "Mazda" };
            db.Producers.Add(BMV);
            db.Producers.Add(Geely);
            db.Producers.Add(Mazda);

            var i8 = new Mark { MarkId = 1, MarkName = "i8", Producer = BMV };
            var ATLAS = new Mark { MarkId = 2, MarkName = "ATLAS", Producer = Geely };
            var m818 = new Mark { MarkId = 3, MarkName = "818", Producer = Mazda };
            var M4 = new Mark { MarkId = 4, MarkName = "M4", Producer = BMV };
            var Z4 = new Mark { MarkId = 5, MarkName = "Z4", Producer = BMV };
            var MK = new Mark { MarkId = 6, MarkName = "MK", Producer = Geely };
            var CX9 = new Mark { MarkId = 7, MarkName = "CX9", Producer = Mazda };
            var GC6 = new Mark { MarkId = 8, MarkName = "GC6", Producer = Geely };
            var Atenza = new Mark { MarkId = 9, MarkName = "Atenza", Producer = Mazda };
            db.Marks.Add(i8);
            db.Marks.Add(ATLAS);
            db.Marks.Add(m818);
            db.Marks.Add(M4);
            db.Marks.Add(Z4);
            db.Marks.Add(MK);
            db.Marks.Add(CX9);
            db.Marks.Add(GC6);
            db.Marks.Add(Atenza);
            db.SaveChanges();
           
            db.Cars.Add(new Car { Id = 1, Mark = i8, Cost = 2000, Color = "Black", Date = 2014, Mileage = 0, Image = null});
            db.Cars.Add(new Car { Id = 2, Mark = ATLAS, Cost = 200, Color = "Black", Date = 2012, Mileage = 200, Image=null});
            db.Cars.Add(new Car { Id = 3, Mark = m818, Cost = 200, Color = "Black", Date = 2013, Mileage = 0, Image=null});
            db.Cars.Add(new Car { Id = 4, Mark = Z4, Cost = 2000, Color = "Blue", Date = 2016, Mileage = 200, Image = null });
            db.Cars.Add(new Car { Id = 5, Mark = i8, Cost = 1500, Color = "Black", Date = 2011, Mileage = 15, Image = null });
            db.Cars.Add(new Car { Id = 6, Mark = M4, Cost = 2500, Color = "Black", Date = 2017, Mileage = 0, Image = null });
            db.Cars.Add(new Car { Id = 7, Mark = i8, Cost = 1000, Color = "Green", Date = 2013, Mileage = 150, Image = null });
            db.Cars.Add(new Car { Id = 8, Mark = GC6, Cost = 200, Color = "Black", Date = 2013, Mileage = 0, Image = null });
            db.Cars.Add(new Car { Id = 9, Mark = MK, Cost = 2000, Color = "Blue", Date = 2016, Mileage = 200, Image = null });
            db.Cars.Add(new Car { Id = 10, Mark = Z4, Cost = 1500, Color = "Black", Date = 2011, Mileage = 15, Image = null });
            db.Cars.Add(new Car { Id = 11, Mark = m818, Cost = 2500, Color = "Black", Date = 2017, Mileage = 0, Image = null });
         
            base.Seed(db);
        }
    }
}
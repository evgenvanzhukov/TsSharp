using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsSharp.Models;

namespace TsSharp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext db)
        {
            db.Database.EnsureCreated();
            
            // Look for any students.
            if (db.Cats.Any() &&db.Products.Any())
            {
                return;   // DB has been seeded
            }

            var cats = new Cat[]
            {
                new Cat(){Name = "Баки для воды" },//1
                new Cat(){Name = "Пластиковые емкости", ParentId=1},//2
                new Cat(){Name = "Баки для воды вертикальные", ParentId=2 },//3
                new Cat(){Name = "Баки для воды горизонтальные", ParentId=2},//4
                new Cat(){Name = "Баки для воды плоские", ParentId=2},//5
                new Cat(){Name = "Баки для летнего душа", ParentId=5 },//6
                new Cat(){Name = "Насосы"},//7
                new Cat(){Name = "Насосы садовые, центробежные", ParentId=7},//8
                new Cat(){Name = "Мотопомпы", ParentId=7},//9
                new Cat(){Name = "Насосы погружные ", ParentId=7},//10
                new Cat(){Name = "Насосы для воды скважинные", ParentId=10},//11
                new Cat(){Name = "Насосы дренажные погружные", ParentId=10}//12
                

            };
            foreach (Cat cat in cats)
            {
                if (!db.Cats.Any(c=>c.Name==cat.Name))
                    db.Cats.Add(cat);
                db.SaveChanges();
            }
            db.SaveChanges();

            var products = new Product[]
            {
                new Product() { Name = "Бак для душа 150 л", CatId=6 },
                new Product() { Name = "Бак для душа 200 л", CatId=6 },
                new Product() { Name = "Бак для душа 250 л", CatId=6 },
                new Product() { Name = "Емкость ЭВЛ 1000 л", CatId=3 },
                new Product() { Name = "Емкость Т 5000 л", CatId=3 },
                new Product() { Name = "Насос Фекальник Ф 900", CatId=12},
                new Product() { Name = "Мотопомпа Cahmpion GP40-2", CatId=9},
                new Product() { Name = "Мотопомпа Вихрь МП80", CatId=9},
                new Product() { Name = "Насос скважинный Aquario ASP1e-90-45", CatId=11},
                new Product() { Name = "Насос погружной ВОДОМЕТ 110/110", CatId=11}
            };
            foreach (Product p in products)
            {
                if(!db.Products.Any(x=>x.Name==p.Name))
                    db.Products.Add(p);
            }
            db.SaveChanges();

        }
    }
}

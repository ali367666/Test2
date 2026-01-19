// See https://aka.ms/new-console-template for more information
using RepeatTask.Data.Context;
using RepeatTask.Data.Entities;

Console.WriteLine("Hello, World!");
AppDbContext appDbContext = new AppDbContext();

/////////////////////Umumi Qeyd 
///Convention
///Atribute
///Fluent API
///Student clası var ve StudentDetail clası
///Convention
///Class-lar arasında one-to-one relation olmalıdır ilk öncə Convention-Default üsul ilə olmalıdır.
///One-To-One relation-da Student clasinda int tipinde StudentDetailID olmalidir ve StudentDetail tipinde StudentDetail olmalidir
///StudentDetail clasinda Student tipinde Student propu olmalidir ve ya tersi cunku one-to-one prosesinde elede ferq vermir 
///Attribute
///Atribute-un ferqi nameof movzusudur adlandirmani deyise bilirem,Hemcinin Propertide yazilir ve kod cirkliliyi yaradir
///Konstreint le Entiti birge olur
///FluentApi-Application Proqraming Interface
///Constraintler DbContext-de yazilir kenarda yazilir ,
///
///One-To-Many relation //Department ve Employee
///One terefde ICollection saxlayiram cunku birden cox shobe olacaq
///Many terefde ise bir dənə saxlayiram cunku her ishchinin bir shobesi var
///
///Ondelete(DeleteBehavior.Cascade) silme emeliyyatinda istifade olunur-Department silindikde ona aid olan Divisions-lar da silinsin//Default olaraq Cascade-dir
///OnDelete(DeleteBehavior.Restrict) silme emeliyyatinda istifade olunur-Department silindikde ona aid olan basqa tablede olan datalari silemye icaze vermir.Eger data yoxdursa silir
///OnDelete(DeleteBehavior.SetNull) silme emeliyyatinda istifade olunur-Department silindikde ona aid olan Divisions-larin DepartmentId-si null olsun
///OnDelete(DeleteBehavior.ClientSetNull) silme emeliyyatinda istifade olunur-Department silindikde ona aid olan Divisions-larin DepartmentId-si 
///null olsun amma bu emeliyyat sadece client terefinden isleyir database terefinden deyil
///Ondelete(DeleteBehavior.ClientCascade) silme emeliyyatinda istifade olunur-Department silindikde ona aid olan Divisions-lar da silinsin amma bu
///emeliyyat sadece client terefinden isleyir database terefinden deyil
///
///EF -Entity Framework
///Add-Datani bazaya elave edir
///AddRange-Coxlu datani bazaya elave edir
///ToList()-IQueryable tipindeki datani List tipine cevirir
///Find-Id-ye gore axtarish edir
///First-Or-Default-Sart uygun gelen ilk datani getirir,eger data yoxdursa Null dəyər qaytarır
///First-Sart uygun gelen ilk datani getirir,eger data yoxdursa exception atir
///Last-Or-Default-Sart uygun gelen sonuncu datani getirir,eger data yoxdursa Null dəyər qaytarır
///Last-Sart uygun gelen sonuncu datani getirir,eger data yoxdursa exception atir
///Single-Or-Default-Bir sart uygun gelen yalniz bir datani getirir,eger data yoxdursa Null dəyər qaytarır,2+ data varsa exception atir
///Single-Bir sart uygun gelen yalniz bir datani getirir,eger data yoxdursa exception atir,2+ data varsa exception atir
///Update-Datani yenileyir
///Remove-Datani silir
///Any-Sart uygun gelen datanin olub olmadigini yoxlayir,eger varsa True, Yoxdursa False qaytarir
///All-Sart uygun gelen butun datalari getirir,eger butun datalar uygun gelirse True, Yoxdursa False qaytarir
///

//Country country = new Country
//{
//    Name = "Azerbaijan",
//    Cities = new List<City>
//    {
//        new City { Name = "Baku" },
//        new City { Name = "Ganja" },
//        new City { Name = "Sumqayit" }
//    }
//};
//Country country1 = new Country
//{
//    Name = "Turkey",
//    Cities = new List<City>
//    {
//        new City { Name = "Istanbul" },
//        new City { Name = "Ankara" },
//        new City { Name = "Izmir" }
//    }
//};
//appDbContext.Countries.AddRange(country, country1);
//appDbContext.SaveChanges();



//var countriesWithCityCount = appDbContext.Countries
//    .Select(c => new
//    {
//        CountryName = c.Name,
//        CityCount = c.Cities.Count
//    })
//    .ToList();
//foreach (var item in countriesWithCityCount)
//{
//    Console.WriteLine($"{item.CountryName}-{item.CityCount}");
//}
var result = appDbContext.Countries
    .GroupBy(c => c.Name)
    .Select(g => new
    {
        CountryName = g.Key,
        CityCount = g.SelectMany(x => x.Cities).Count()
    })
    .ToList();
foreach (var item in result)
{
    Console.WriteLine($"{item.CountryName}-{item.CityCount}");
    
}
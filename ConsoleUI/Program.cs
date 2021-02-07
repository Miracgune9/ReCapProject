using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {           
            CrudOperationsOfCar();

            Console.ReadLine();
        }

        private static void CrudOperationsOfCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var detail in carManager.GetCarDetail())
            {
                Console.WriteLine(detail.Description + "/" + detail.BrandName + "/" + detail.ColorName + "/" + detail.DailyPrice);
            }


        }

        private static void CrudOperationsOfColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine("COLOR Id si 2 olan gösterilitor..");
            Console.WriteLine(colorManager.GetById(2).ColorName);


            colorManager.Add(new Color { ColorId = 6, ColorName = "yellow" });
            colorManager.Update(new Color { ColorId = 6, ColorName = "NewYellow" });
            colorManager.Delete(5);

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }
        private static void CrudOperationsOfBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(2).BrandName);
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Ferrari" });
            brandManager.Update(new Brand { BrandId = 6, BrandName = "NewBrandd" });
            brandManager.Delete(5);

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }


    }
}
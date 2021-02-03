using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, CarName="Bugatti", BrandId=1, BrandName="Otomobil" ,ColorId=1, ColorName="Siyah", ModelYear= 2016, DailyPrice=3000, Description="Lüks Araç Kiralama Seçeneği" },
                new Car{CarId=2, CarName="BMW-X6",  BrandId=2, BrandName="SUV" ,ColorId=2, ColorName="Beyaz", ModelYear= 2018, DailyPrice=2200, Description="Lüks SUV Araç Kiralama Seçeneği" },
                new Car{CarId=3, CarName="Honda Cıvıc", BrandId=1, BrandName="Otomobil" ,ColorId=1, ColorName="Siyah", ModelYear= 2020, DailyPrice=600, Description="Ekonomik Araç Kiralama Seçeneği" },
                new Car{CarId=4, CarName="Renault Clio", BrandId=1, BrandName="Otomobil" ,ColorId=3, ColorName="Bej", ModelYear= 2018, DailyPrice=450, Description="Ekonomik Kiralama Seçeneği" },
                new Car{CarId=5, CarName="Jaguar F-Pace", BrandId=2, BrandName="SUV" ,ColorId=4, ColorName="Kırmızı", ModelYear= 2014, DailyPrice=1600, Description="Lüks SUV Kiralama Seçeneği" },
                new Car{CarId=6, CarName="Motoryat", BrandId=3, BrandName="Deniz Aracı" ,ColorId=2, ColorName="Beyaz", ModelYear= 2015, DailyPrice=2500, Description="Lüks Deniz Aracı Kiralama Seçeneği" },
                new Car{CarId=7, CarName="Yelkenli", BrandId=3, BrandName="Deniz Aracı" ,ColorId=2, ColorName="Beyaz", ModelYear= 2016, DailyPrice=2300, Description="Lüks Deniz Aracı Kiralama Seçeneği" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            _cars.Remove(carToDelete);


            

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => car.CarId == c.CarId);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ColorName = car.ColorName;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;


        }
    }
}

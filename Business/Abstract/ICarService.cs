using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Concrete.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetByCarId(int CarId);
        List<Car> GetCarsByColorId();
        List<Car> GetCarsByBrandId();
        void AddCar(Car car);
        void DeleteCar(int CarId);
        void UpdateCar(Car car);
        List<DtoCarDetail> GetCarDetail();

    }
}
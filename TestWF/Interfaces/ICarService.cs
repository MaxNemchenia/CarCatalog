using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWF.Models;

namespace TestWF.Interfaces
{
    public interface ICarService
    {
        IList<Car> GetCars();

        IList<Mark> GetMarks();

        IList<Producer> GetProducers();

        Car GetCarById(int id);

        Car AddCar(Car car);

        Car EditCar(Car car);

        void DeleteCar(int id);

        IList<Car> GetCarsByProducer(int producerId);

        IList<Car> GetCarsByMark(int markId);
    }
}

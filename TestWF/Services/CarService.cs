using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWF.Interfaces;
using TestWF.Models;

namespace TestWF.Services
{
    class CarService : ICarService
    {
        private CarContext db;

        public CarService()
        {
            db = new CarContext();
        }

        public IList<Car> GetCars()
        {
            return db.Cars.Include("Mark").Include("Mark.Producer").ToList();
        }

        public IList<Mark> GetMarks()
        {
            return db.Marks.Include("Producer").ToList();
        }

        public IList<Producer> GetProducers()
        {
            return db.Producers.ToList();
        }

        public Car AddCar(Car car)
        {
            var createdCar = db.Cars.Add(car);
            db.SaveChanges();
            return createdCar;
        }

        public Car EditCar(Car car)
        {
            Car editedCar = db.Cars.FirstOrDefault(x => x.Id == car.Id);
            db.Entry(editedCar).CurrentValues.SetValues(car);
            db.SaveChanges();
            return car;
        }

        public void DeleteCar(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0.");
            }

            var car = db.Cars.SingleOrDefault(m => m.Id == id);
            if (car == null)
            {
                throw new ArgumentException("Car with this id isn't existing");
            }

            db.Cars.Remove(car);
            db.SaveChanges();
        }

        public IList<Car> GetCarsByMark(int markId)
        {
            var selectionMarks = db.Cars.Where(m => m.MarkId == markId).ToList();
            return selectionMarks;
        }

        public Car GetCarById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than 0.");
            }

            var car = db.Cars.SingleOrDefault(m => m.Id == id);
            return car;
        }

        public IList<Car> GetCarsByProducer(int producerId)
        {
            var selectionMarks = db.Cars.Where(m => m.Mark.ProducerId == producerId).ToList();
            return selectionMarks;
        }
    }
}

using finalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace finalProject.DAL
{
    public class ZooInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ZooContext>
    {
        protected override void Seed(ZooContext context)
        {
            var animals = new List<Animal>
            {
                new Animal{AnimalName="Pepper",AnimalType="Giraffe",AnimalZooLocation="San Diego, CA",FoodClass="Herbivore"},
                new Animal{AnimalName="Salt",AnimalType="Polar Bear",AnimalZooLocation="San Diego, CA",FoodClass="Omnivore"},
                new Animal{AnimalName="Teddy",AnimalType="Grizzley Bear",AnimalZooLocation="Portland, OR",FoodClass="Omnivore"},
                new Animal{AnimalName="Baldy",AnimalType="Bald Eagle",AnimalZooLocation="Portland, OR",FoodClass="Carnivore"},
                new Animal{AnimalName="Trumpet",AnimalType="Elephant",AnimalZooLocation="Portland, OR",FoodClass="Herbivore"},
                new Animal{AnimalName="Static",AnimalType="Zebra",AnimalZooLocation="San Diego, CA",FoodClass="Herbivore"},
                new Animal{AnimalName="George",AnimalType="Monkey",AnimalZooLocation="San Diego, CA",FoodClass="Omnivore"},
                new Animal{AnimalName="Lester",AnimalType="Tiger",AnimalZooLocation="Portland, OR",FoodClass="Carnivore"},
            };
            animals.ForEach(s => context.Animals.Add(s));
            context.SaveChanges();

            
        }
    }
}
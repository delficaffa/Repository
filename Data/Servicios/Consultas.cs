using DataToTestLinq;
using LinqEjercicios;
using Servicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Consultas
    {


        public IEnumerable<PersonModel> Todas()
        {
            var Mayores = DataContext.People.Select(person => new PersonModel
            {
                Name = person.Name,
                Country = person.Country,
                Age = DateTime.Now.Year - person.DateOfBorn.Year
            });

            return Mayores.Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Select(child => new PersonModel
                {
                    Name = child.Name,
                    Country = child.Country,
                    Age = DateTime.Now.Year - child.DateOfBorn.Year
                }));
        }

        public IEnumerable<PersonModel> Mujeres()
        {
            var señoras = DataContext.People
                .Where(person => person.Gender == Gender.Feminine)
                .Select(person => new PersonModel
                {
                    Name = person.Name
                });
            return señoras.Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Where(child => child.Gender == Gender.Feminine)
                .Select(child => new PersonModel
                {
                    Name = child.Name,

                }));
        }

        public IEnumerable<PersonModel> HombresPeso()
        {
            var hombres = DataContext.People
                .Where(person => person.Gender == Gender.Masculine && person.Weight > 70)
                .Select(person => new PersonModel
                {
                    Name = person.Name,
                    Weight = person.Weight
                });
            return hombres.Union(DataContext.People
                .Where(person => person.Children.Count() != 0)
                .SelectMany(person => person.Children)
                .Where(child => child.Weight > 70)
                .Select(child => new PersonModel
                {
                    Name = child.Name,
                    Weight = child.Weight

                }));
        }

        public double PromEdad()
        {
            var prom = DataContext.People
            .Select(person => DateTime.Now.Year - person.DateOfBorn.Year)
            .Average();

            prom = Math.Round(prom, 2);
            return prom;
        }

        public IEnumerable<PersonModel> Hijos()
        {
            return DataContext.People
                 .Where(person => person.Children.Count() != 0)
                 .SelectMany(person => person.Children)
                 .Select(child => new PersonModel
                 {
                     Name = child.Name,

                 });

        }

        public IEnumerable<PaisModel> PromEdadPais()
        {
            return DataContext.People
                .GroupBy(x => x.Country)
                .Select(x => new PaisModel
                {
                    Country = x.Key,
                    Avg = x.Select(y => DateTime.Now.Year - y.DateOfBorn.Year)
                    .Average()
                });
        }

        public IEnumerable<GeneroModel> PromPesoGenero()
        {
            return DataContext.People
                .GroupBy(x => x.Gender)
                .Select(x => new GeneroModel
                {
                    Gender = x.Key.ToString(),
                    Avg = x.Select(y => y.Weight).Average()
                });

        }

        public PersonModel MasPesado()
        {
            return DataContext.People
                 .OrderByDescending(p => p.Weight)
                 .Select(p => new PersonModel
                 {
                     Name = p.Name,
                     Weight = p.Weight

                 }).First();
        }
    }
}

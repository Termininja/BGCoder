namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;

            this.Furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty or null!");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("The name cannot be with less than 5 symbols!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length != 10)
                {
                    throw new ArgumentException("The registration number must be exactly 10 symbols!");
                }

                if (value.Any(m => !char.IsDigit(m)))
                {
                    throw new ArgumentException("The registration number must contain only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures { get; private set; }

        public void Add(IFurniture furniture)
        {
            this.Furnitures.Add(furniture);
            this.Furnitures = this.Furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model).ToList();
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.Furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var catalog = new StringBuilder();
            catalog.AppendFormat("{0} - {1} - {2} {3}",
                this.Name, this.RegistrationNumber,
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            this.Furnitures.ToList().ForEach(f => catalog.AppendFormat("\n{0}", f.ToString()));

            return catalog.ToString();
        }
    }
}

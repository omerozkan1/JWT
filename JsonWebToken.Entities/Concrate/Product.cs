using JsonWebToken.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonWebToken.Entities.Concrate
{
    public class Product : ITable
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

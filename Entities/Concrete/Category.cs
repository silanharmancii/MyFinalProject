using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // çıplak class kalmasın. yani inheritance veya interface alsın
    public class Category:IEntity 
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

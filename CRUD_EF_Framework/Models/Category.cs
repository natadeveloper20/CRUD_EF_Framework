using System.Collections.Generic;

namespace CRUD_EF_Framework.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection <Product> Products { get; set; }
    }
}
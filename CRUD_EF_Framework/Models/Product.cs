using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_EF_Framework.Models
{
    public class Product
    {
        [Key] // Marca ProductId como la clave primaria
        public int ProductId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // Clave externa para Category
        public int CategoryId { get; set; }

        // Relación de navegación hacia Category
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}

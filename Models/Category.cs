using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEntity.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //chave gerada direto no banco
        public int Id { get; set; }

        [Required] //vai gerar o campo como NOTNULL
        [MinLength(3)] //definir tamanho minimo para futura validação
        [MaxLength(80)] //definir tamanho maximo
        [Column("Name", TypeName = "NVARCHAR")]
        public string Name { get; set; }
        [Required] //vai gerar o campo como NOTNULL
        [MinLength(3)] //definir tamanho minimo para futura validação
        [MaxLength(80)] //definir tamanho maximo
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}
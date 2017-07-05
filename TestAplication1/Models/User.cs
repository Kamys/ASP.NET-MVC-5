using System.ComponentModel.DataAnnotations;

namespace TestAplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}
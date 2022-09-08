using System.ComponentModel.DataAnnotations;

namespace ToDoApi.Models
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string? ToDoName { get; set; }
        public int MyProperty { get; set; }
    }
}

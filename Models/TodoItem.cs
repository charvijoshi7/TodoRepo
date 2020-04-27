using System.ComponentModel.DataAnnotations.Schema;
using TodoApi.Models;

public class TodoItem { 

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}

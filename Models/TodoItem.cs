using System.ComponentModel.DataAnnotations.Schema;
using TodoApi.Models;
using TodoApi.Repository;
using System.ComponentModel.DataAnnotations;
using System.Windows.Input;
using TodoApi.Coomands;
using System;

public class TodoItem
{ 

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamRabGaynutdinov2.Entities;

public class TrainingEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedAt { get; set; }

    public TrainingEntity(
        string title,
        string description,
        decimal amount)
    {
        Title = title;
        Description = description;
        Amount = amount;
        CreatedAt = DateTime.Now;
    }
}

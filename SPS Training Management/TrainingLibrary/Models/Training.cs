using System;
using System.Collections.Generic;

namespace TrainingLibrary.Models;

public partial class Training
{
    public string TrainingId { get; set; } = null!;

    public string? TechId { get; set; }

    public string? TrainerId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Technology? Tech { get; set; }

    public virtual ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();

    public virtual Trainer? Trainer { get; set; }
}

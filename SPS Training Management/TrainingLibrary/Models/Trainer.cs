using System;
using System.Collections.Generic;

namespace TrainingLibrary.Models;

public partial class Trainer
{
    public string TrainerId { get; set; } = null!;

    public virtual ICollection<Training> Training { get; set; } = new List<Training>();
}

using System;
using System.Collections.Generic;

namespace TrainingLibrary.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public virtual ICollection<Trainee> Trainees { get; set; } = new List<Trainee>();
}

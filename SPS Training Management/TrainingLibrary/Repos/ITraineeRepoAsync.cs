using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingLibrary.Models;

namespace TrainingLibrary.Repos
{
    public interface ITraineeRepoAsync
    {
        Task InsertTraineeAsync(Trainee trainee);
        Task UpdateTraineeAsync(string trainingId, int traineeId, Trainee trainee);
        Task DeleteTraineeAsync(string trainingId, int traineeId);
        Task<Trainee> GetTraineeByIdAsync(string trainingId, int traineeId);
        Task<List<Trainee>> GetAllTraineesAsync();
        Task<List<Trainee>> GetTraineesByTraining(string trainingId);
        Task<List<Trainee>> GetTrainingsByTrainee(int traineeId);
        Task InsertEmployeeAsync(Employee employee);

    }
}

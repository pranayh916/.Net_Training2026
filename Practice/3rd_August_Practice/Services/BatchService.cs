using _2nd_August_Practice.Models;
using System.Text.RegularExpressions;

namespace _2nd_August_Practice.Repository
{
    public class BatchService : IBatchService
    {
        private List<Batch> batches = new List<Batch>()
        {
            new Batch
            {
                Id = 1,
                BatchName = ".NET",
                TrainerName = "Raj",
                Duration = 60
            },
            new Batch
            {
                Id = 2,
                BatchName = "Java",
                TrainerName = "Amit",
                Duration = 45
            },
            new Batch
            {
                Id = 3,
                BatchName = "Python",
                TrainerName = "Neha",
                Duration = 30
            }
        };

        public List<Batch> GetAll()
        {
            return batches;
        }

        public Batch? GetBatch(int id)
        {
            return batches.FirstOrDefault(x => x.Id == id);
        }

        public void AddBatch(Batch batch)
        {
            batches.Add(batch);
        }

        public void UpdateBatch(Batch batch)
        {
            var existing = batches.FirstOrDefault(x => x.Id == batch.Id);

            if (existing != null)
            {
                existing.BatchName = batch.BatchName;
                existing.TrainerName = batch.TrainerName;
                existing.Duration = batch.Duration;
            }
        }

        public void DeleteBatch(int id)
        {
            var batch = batches.FirstOrDefault(x => x.Id == id);

            if (batch != null)
            {
                batches.Remove(batch);
            }
        }
    }
}
using _2nd_August_Practice.Models;
using System.Text.RegularExpressions;

namespace _2nd_August_Practice.Repository
{
    public interface IBatchService
    {
        List<Batch> GetAll();
        Batch? GetBatch(int id);
        void AddBatch(Batch batch);
        void UpdateBatch(Batch batch);
        void DeleteBatch(int id);
    }
}
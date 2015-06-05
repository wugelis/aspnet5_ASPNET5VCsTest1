using System;
using System.Threading.Tasks;

namespace ASPNET5VCsTest1.Services
{
    public class StatisticsService
    {
        public async Task<int> GetCount()
        {
            return await Task.FromResult(11);
        }

        public async Task<int> GetCompletedCount()
        {
            return await Task.FromResult(22);
        }

        public async Task<double> GetAveragePriority()
        {
            return await Task.FromResult(0.0);
        }
    }
}
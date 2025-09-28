
using CaseStudy.DAL.DomainClasses;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.DAL.DAO
{
    public class BranchDAO
    {
        private AppDbContext _db;

        public BranchDAO(AppDbContext context)
        {
            _db = context;
        }

        public async Task<List<Branch>?> GetThreeClosestStores(float lat, float lon)
        {
            List<Branch>? branches = new();
            try
            {
                var latParam = new SqlParameter("@lat", lat);
                var lonParam = new SqlParameter("@lon", lon);

                var query = _db.Branches?.FromSqlRaw("dbo.p3Closest @lat, @lon", latParam, lonParam);
                branches = await query!.ToListAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return branches;
        }
    }
}

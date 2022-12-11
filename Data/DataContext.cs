using Microsoft.EntityFrameworkCore;

namespace e_commerce_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }

}
using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace sourcetree.EntityFrameworkCore
{
    public static class sourcetreeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<sourcetreeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<sourcetreeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

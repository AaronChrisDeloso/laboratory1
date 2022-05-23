using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using sourcetree.Configuration;
using sourcetree.Web;

namespace sourcetree.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class sourcetreeDbContextFactory : IDesignTimeDbContextFactory<sourcetreeDbContext>
    {
        public sourcetreeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<sourcetreeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            sourcetreeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(sourcetreeConsts.ConnectionStringName));

            return new sourcetreeDbContext(builder.Options);
        }
    }
}

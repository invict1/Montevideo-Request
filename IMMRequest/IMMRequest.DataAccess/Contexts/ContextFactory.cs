using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IMMRequest.DataAccess
{

    public enum ContextType { MEMORY, SQL }

    public class ContextFactory: IDesignTimeDbContextFactory<IMMRequestContext>
    {
        public IMMRequestContext CreateDbContext(string[] args)
        {
            return GetNewContext();
        }


		public static IMMRequestContext GetNewContext(ContextType type = ContextType.SQL)
		{
			var builder = new  DbContextOptionsBuilder<IMMRequestContext>();
			DbContextOptions  options = null;
			if (type == ContextType.MEMORY) {
				options = GetMemoryConfig(builder);
			} else {
				options = GetSqlConfig(builder);
			}
			
			return new IMMRequestContext(options);
		}

        private static DbContextOptions GetMemoryConfig(DbContextOptionsBuilder builder) 
		{
			builder.UseInMemoryDatabase("IMMRequestDB");
			
			return  builder.Options;
		}

		private static DbContextOptions GetSqlConfig(DbContextOptionsBuilder  builder)
		 {
			// builder.UseSqlServer(@"Server=.\\SQLEXPRESS;Database=HomeworksDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
            builder.UseSqlServer(@"Server=127.0.0.1,1433;Database=IMMRequestDB;User Id=sa;Password=yourStrong(!)Password;");
            
			return  builder.Options;
		}

    } 

}

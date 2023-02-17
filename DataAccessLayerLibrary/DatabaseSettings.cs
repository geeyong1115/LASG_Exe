using System.Data.Entity;
using Exercise.DataAccessLayer;

namespace DataAccessLayer
{
    public class DatabaseSettings
    {
        public static void SetDatabase()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<UsersCoursesERPDAL>());
        }
    }
}

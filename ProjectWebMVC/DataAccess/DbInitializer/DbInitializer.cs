namespace ProjectWeb.DataAccess.DbInitializer
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize()
        {
            // 3 tasks:
            // do migrations if they are not applied
            // create roles if they are not created
            // if roles are not created, then we will create admin user as well


        }
    }
}

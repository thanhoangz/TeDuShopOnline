namespace TedShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TeDuShopDbContext dbContext;

        public TeDuShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TeDuShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
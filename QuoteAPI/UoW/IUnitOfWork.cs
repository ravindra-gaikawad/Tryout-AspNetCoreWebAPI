namespace QuoteAPI.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void CommitTransaction();

        void RollbackTransaction();
    }
}

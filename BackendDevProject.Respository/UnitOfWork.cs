namespace BackendDevProject.Respository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPostRepository _postRepository { get; }

        public UnitOfWork(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


    }
}

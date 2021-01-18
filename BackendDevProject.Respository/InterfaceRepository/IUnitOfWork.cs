namespace BackendDevProject.Respository
{
    public interface IUnitOfWork
    {
        IPostRepository _postRepository { get; }
    }
}

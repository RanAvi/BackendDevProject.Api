using BackendDevProject.Domain;
using Dapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BackendDevProject.Respository
{
    public class PostRepositoy : IPostRepository
    {

        #region Properties

        private string sql = string.Empty;
        private string TableName = "POSTS";
        private readonly IDatabaseSetup _config;

        #endregion

        public PostRepositoy(IDatabaseSetup config)
        {
            _config = config;
        }



        public Task<bool> Create(Post entity)
        {
            sql = $"INSERT INTO  {TableName} (title,Body) VALUES(@title, @Body);";
            var p = new DynamicParameters();
            p.Add("@Id", entity.Id);
            p.Add("@title", entity.title);
            p.Add("@Body", entity.Body);
            // p.AddDynamicParams(entity);
            var result = DAL.DAL<Post>.Create(p, sql);
            return result;


        }

        public Task<bool> Delete(int id)
        {
            sql = $"DELETE FROM  {TableName}   WHERE Id = @Id;";
            var p = new DynamicParameters();
            p.Add("@Id", id);
            var result = DAL.DAL<Post>.Delete(p, sql);
            return result;

        }

        public Task<Post> Get(int id)
        {

            var p = new DynamicParameters();
            p.Add("@Id", id);
            sql = $"SELECT *  FROM  {TableName} WHERE Id=@Id";
            var result = DAL.DAL<Post>.Get(p, sql);
            return result;


        }

        public Task<IEnumerable<Post>> GetAll()
        {

            var p = new DynamicParameters();
            sql = $"SELECT * FROM  {TableName}";
            var result = DAL.DAL<Post>.GetAll(p, sql);
            return result;

        }

        public Task<bool> Update(Post entity)
        {

            var p = new DynamicParameters();
            p.Add("@Id", entity.Id);
            p.Add("@title", entity.title);
            p.Add("@Body", entity.Body);

            sql = $"UPDATE {TableName} SET title = @title , Body = @Body WHERE  Id = @id";
            var result = DAL.DAL<Post>.Update(p, sql);
            return result;

        }
    }
}

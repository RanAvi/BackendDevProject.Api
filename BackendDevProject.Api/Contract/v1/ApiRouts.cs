namespace BackendDevProject.Api
{
    public static class ApiRouts
    {
        private const string root = "api";

        private const string version = "v1";

        private const string baseroot = root + "/" + version;

        public static class Posts
        {
            // api/v1/posts
            public const string GetAll = baseroot + "/Posts/get.{format}";

            public const string Get = baseroot + "/Posts/{id}";

            public const string Delete = baseroot + "/Posts/{id}";

            public const string Create = baseroot + "/Posts";

            public const string Update = baseroot + "/Posts";
        }



    }
}

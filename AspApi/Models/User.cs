using System;

namespace AspApi
{
    public class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string passwordMd5 { get; set; }
        public string phone { get; set; }
        public string session { get; set; }
    }
}

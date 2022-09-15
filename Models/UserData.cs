namespace bookwormbackend.Models
{
    public class UserData
    {

        public int Id { get; set; }

        public string name { get; set; }

        public string username { get; set; }
        
        public string email { get; set; }

        public int wallet { get; set; }

        public string address { get; set; }

        public virtual UserCreds? UserCreds { get; set; }
        public virtual UserShelf? UserShelf { get; set; }

        public DateTime created { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class User
    {
        public User()
        {
            userRoles = new HashSet<UserRole>();
            assets = new HashSet<AssetUser>();
            comments = new HashSet<Comment>();
            answers = new HashSet<Answer>();
        }


        [Key]
        public int id { get; set; }

        [MaxLength(500), Required]
        public string name { get; set; }
        [MaxLength(500), Required]
        public string email { get; set; }
        [MaxLength(500), Required]
        public string password { get; set; }
        public DateTime created { get; set; }



        public virtual ICollection<UserRole> userRoles { get; set; }
        public virtual ICollection<Comment> comments { get; set; }
        public virtual ICollection<Answer> answers { get; set; }
        public virtual ICollection<AssetUser> assets { get; set; }
    }
}

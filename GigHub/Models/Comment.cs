using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{

    public class Comment
    {
        [Key]
        [Column(Order = 1)]
        public string СommentatorId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string OrganizerId { get; set; }
        public DataType DataTime { get; set; }
        public string CommentValue { get; set; }

        public ApplicationUser Сommentator { get; set; }
        public ApplicationUser Organizer { get; set; }
    }
}
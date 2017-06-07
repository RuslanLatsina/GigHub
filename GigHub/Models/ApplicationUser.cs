using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GigHub.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        public GenderType Gender { get; set; }
        public string CreditCardNumber { get; set; }
        [Required]
        public int Age { get; set; }
        public int AverageRaiting { get; set; }
        [Required]
        [StringLength(100)]
        public string City { get; set; }

        public bool IsOrganizer { get; set; }

        public ICollection<Comment> Сommentators { get; set; }
        public ICollection<Comment> Organizers { get; set; }
        public ICollection<RaitingDetail> Estimators { get; set; }
        public ICollection<RaitingDetail> RaitingOrganizers { get; set; }
        public ICollection<Following> Followers { get; set; }
        public ICollection<Following> Followees { get; set; }
        //public ICollection<UserNotification> UserNotifications { get; set; }

        public ApplicationUser()
        {
            Followers = new Collection<Following>();
            Followees = new Collection<Following>();
            Сommentators = new Collection<Comment>();
            Organizers = new Collection<Comment>();
            //UserNotifications = new Collection<UserNotification>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public enum GenderType
    {
        Male,
        Female
    }
}
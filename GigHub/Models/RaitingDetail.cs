using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigHub.Models
{
    public class RaitingDetail
    {
        [Key]
        [Column(Order = 1)]
        public string EstimatorId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string OrganizerId { get; set; }
 
        public double RaitingValue { get; set; }

        public ApplicationUser Estimator { get; set; }
        public ApplicationUser RaitingOrganizers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public bool IsCanceled { get; private set; }

        public ApplicationUser Organizer { get; set; }

        [Required]
        public string OrganizerId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string City { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public int Seats { get; set; }

        [Required]
        [StringLength(255)]
        public string Price { get; set; }

        public Genre Genre { get; set; }

        //public byte[] Image { get; set; }

        [Required]
        public byte GenreId { get; set; }

        //public ICollection<Attendance> Attendances { get; private set; }

        //public Gig()
        //{
        //    Attendances = new Collection<Attendance>();
        //}

        //public void Cancel()
        //{
        //    IsCanceled = true;

        //    var notification = Notification.GigCanceled(this);

        //    foreach (var attendee in Attendances.Select(a => a.Attendee))
        //    {
        //        attendee.Notify(notification);
        //    }
        //}

        //public void Modify(DateTime dateTime, string venue, byte genre)
        //{
        //    var notification = Notification.GigUpdated(this, DateTime, Venue);

        //    Venue = venue;
        //    DateTime = dateTime;
        //    GenreId = genre;

        //    foreach (var attendee in Attendances.Select(a => a.Attendee))
        //        attendee.Notify(notification);
        //}
    }
}
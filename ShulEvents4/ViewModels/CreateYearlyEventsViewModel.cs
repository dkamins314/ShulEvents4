using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static ShulEvents4.ViewModels.Enums;

namespace ShulEvents4.ViewModels
{
    public class CreateYearlyEventsViewModel
    {

        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-DD-YYYY}", ApplyFormatInEditMode = true)]
        [Display(Name = "Starting Date")]
        public DateTime StartingDate { get; set; }

        [Display(Name = "Starting Time")]
        public string StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-DD-YYYY}", ApplyFormatInEditMode = true)]
        [Display(Name = "Ending Date")]
        public DateTime EndingDate { get; set; }

        [Display(Name = "Ending Time")]
        public string EndTime { get; set; }
        public SpecialEvents SpecialEvents { get; set; }
        public SpecialShabassos SpecialShabassos { get; set; }
        public Months Months { get; set; }
        public Parshios Parshios { get; set; }
        public LifeEvents LifeEvents { get; set; }
        [MaxLength(1000)]
        public string EventDescription { get; set; }

        public CreateYearlyEventsViewModel() { }


        public CreateYearlyEventsViewModel(DateTime startingDate, string startTime,
            DateTime endingDate, string endTime, SpecialEvents specialEvents,
            SpecialShabassos specialShabassos, Months months, Parshios parshios,
            LifeEvents lifeEvents, string eventDescription)
        {
            StartingDate = startingDate;
            StartTime = startTime;
            EndingDate = endingDate;
            EndTime = endTime;
            SpecialEvents = specialEvents;
            SpecialShabassos = specialShabassos;
            Months = months;
            Parshios = parshios;
            LifeEvents = lifeEvents;
            EventDescription = eventDescription;
        }

    }

}




/*   CreateContextListToYearlyEventsViewModel(items);

   }

   public void CreateContextListToYearlyEventsViewModel(IEnumerable<SelectListItem> items)
   {
       Items = new List<SelectListItem>();

       foreach (var item in items)
       {
           Items.Add(new SelectListItem()
           {
            Value = item.Id.ToString(),
            Text = item.Name
           });
       }*/




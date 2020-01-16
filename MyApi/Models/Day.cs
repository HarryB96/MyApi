using System;
using System.ComponentModel.DataAnnotations;
namespace MyApi.Models
{
    public class Day
    {
        public Day()
        {

        }
        [Key]
        public int DayId { get; set; }
        [StringLength(10)]
        public string DayName { get; set; }
    }
}

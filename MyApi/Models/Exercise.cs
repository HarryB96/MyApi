using System;
using System.ComponentModel.DataAnnotations;
namespace MyApi.Models
{
    public class Exercise
    {
        public Exercise()
        {

        }
        [Key]
        public int ExerciseId { get; set; }
        [StringLength(100)]
        public string ExerciseName { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public int? Weight { get; set; }
        [StringLength(10)]
        public string Superset { get; set; }
        public int DayId { get; set; }
    }
}

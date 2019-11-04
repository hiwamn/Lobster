using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dto.Models
{
    public class SettingModel
    {
        [Required]
        public int AdNo { get; set; }
        [Required]
        public int AdDelay { get; set; }
        [Required]
        public int SpecialNo { get; set; }
        [Required]
        public int SpecialNumberOfDays { get; set; }

        [Required]
        public int ImmediateNo { get; set; }
        [Required]
        public int ImmediateNumberOfDays { get; set; }
        [Required]
        public int SimplePrice { get; set; }
        [Required]
        public int ImmediatePrice { get; set; }
        [Required]
        public int SpecialPrice { get; set; }
        [Required]
        public int AdPrice { get; set; }
    }
}

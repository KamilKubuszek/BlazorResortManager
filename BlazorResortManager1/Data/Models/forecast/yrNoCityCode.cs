﻿using BlazorResortManager1.Data.Models.main;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorResortManager1.Data.Models.forecast
{
    [Table("yrNoCityCode")]
    public class yrNoCityCode
    {
        [Key]
        public Guid id {  get; set; }

        //2-3094802
        [Required]
        public string code { get; set; }

        [Required(ErrorMessage = "'cityName' jest wymagane")]
        [MaxLength(128, ErrorMessage = "'cityName' może mieć maksymalnie 128 znaków")]
        public string cityName { get; set; }

        public string country { get; set; }

        [JsonIgnore]
        public ICollection<Resort> resort { get; set; } = new List<Resort>();   
    }
}

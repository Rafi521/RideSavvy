//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RideSavvy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class TouristPlace
    {
        public int TouristPlace_ID { get; set; }

        [Required(ErrorMessage = "Please enter tourist place name")]
        [Display(Name = "Place Name")]
        public string TouristPlace_Name { get; set; }

        [Display(Name = "Place Image")]
        public string TouristPlace_Image { get; set; }

        [Required(ErrorMessage = "Please enter place description")]
        [Display(Name = "Description")]
        public string TouristPlace_Description { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        [Display(Name = "Location")]
        public string TouristPlace_Location { get; set; }

        [Required(ErrorMessage = "Please Enter Location Latutude")]
        [Display(Name = "Latitude")]
        public string TouuristPlace_Lat { get; set; }

        [Required(ErrorMessage = "Please enter location longitude")]
        [Display(Name = "Longitute")]
        public string TouristPlace_long { get; set; }

        public HttpPostedFileBase TouristImageFile { get; set; }
    }
}
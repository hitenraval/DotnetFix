﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Googlemaps.Models
{


    //------------------------------------------------------------------------------
    // <auto-generated>
    //    This code was generated from a template.
    //
    //    Manual changes to this file may cause unexpected behavior in your application.
    //    Manual changes to this file will be overwritten if the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------

    using System;
    using System.Collections.Generic;


    public partial class SchoolInfo
   {

        public string Name { get; set; }

        public System.Data.Spatial.DbGeography Geolocation { get; set; }

        public double? lat
        {
            get; set;
        }
        public double? lng
        {
            get;
            set;
        }

        public double? Distance { get; set; }

    }


}
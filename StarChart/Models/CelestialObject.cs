﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObjectId { get; set; }

        [NotMapped]
        public List<CelestialObject> Satellites;

        public DateTime OrbitalPeriod { get; set; }
    }
}

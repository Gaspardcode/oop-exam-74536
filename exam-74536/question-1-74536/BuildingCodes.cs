/*
=============================
        Stu n° 74536
 Gaspard TORTERAT SLANDA
 ============================= */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1_74536
{
    class BuildingCodes
    {
        [Required]
        public int BuildingId { get; set; }
        [Required]
        [MaxLength(20)]
        string BuildingLocation { get; set; }
        [Required]
        [MinLength(4)]
        [MaxLength(6)]
        string BuildingCode {get;  set;}

        public BuildingCodes(int id, string loc, string code)
        {
            BuildingId = id;
            BuildingLocation = loc; 
            BuildingCode = code;
        }

        public void Show()
        {
            Console.WriteLine($"Building n°{BuildingId} at {BuildingLocation} as code {BuildingCode}");
        }
    }
}

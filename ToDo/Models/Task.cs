using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Task
    {
        [Key]
        public int TaskID { get; set; }
        [Display(Name ="Due")]
        public DateTime TaskDate { get; set; }
        [Display(Name="Completed")]
        public bool IsDone { get; set; }
        [Display(Name ="Task")]
        public string TaskName { get; set; }
        [Display(Name ="Description")]
        public string TaskDescription { get; set; }
        
        [ForeignKey("List")]
        public int ListID { get; set; }
        public virtual List List { get; set; }
    }
}
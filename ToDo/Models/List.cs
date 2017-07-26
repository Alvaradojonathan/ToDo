using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class List
    {
        [Key]
        public int ListID { get; set; }
        [Display(Name ="List")]
        public string ListName { get; set; }
        [Display(Name ="Date Created")]
        public DateTime ListDate { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
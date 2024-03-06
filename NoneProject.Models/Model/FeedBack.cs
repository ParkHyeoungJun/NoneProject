using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoneProject.Models.Model
{
    [Table("FeedBack")]
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public string Name { get; set; }
    }
}

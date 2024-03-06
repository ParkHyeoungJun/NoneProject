using Microsoft.EntityFrameworkCore;
using NoneProject.Models.Model;

namespace NoneProject.Models.Context
{
    public class FeedBackContext:DbContext
    {
        public FeedBackContext()
        {
                
        }
      
        public DbSet<FeedBack> FeedBacks { get; set; }
    }
}

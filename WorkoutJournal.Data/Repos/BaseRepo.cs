using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Data.Data;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Repos
{
    public class BaseRepo
    {
        private readonly AppDbContext context;

        public BaseRepo(AppDbContext context)
        {
            this.context = context;
            var st = new List<WorkoutTemplate>();
            Expression<Func<WorkoutTemplate, bool>> s = wt => wt.Description == "" || wt.Name == "";
        }


    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutJournal.Data.Data.Models;

namespace WorkoutJournal.Data.Data.EntityConfig
{
    internal class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            throw new NotImplementedException();
        }
    }
}

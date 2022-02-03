using GhostDiary.Data;
using GhostDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostDiary.Service
{
   public class GhostService
    {
        public bool CreateGhost(GhostCreate model)
        {
            var entity =
                new Ghost()
                {
                    GhostName = model.GhostName,
                    GhostClue1 = model.GhostClue1,
                    GhostClue2 = model.GhostClue2,
                    GhostClue3 = model.GhostClue3,
                    GhostClue4 = model.GhostClue4
                };
            using (ctx = new ApplicationDbContext())
            {
                ctx
            }
        }
    }
}

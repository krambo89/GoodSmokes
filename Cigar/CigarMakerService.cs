using ClassLibrary1;
using GoodSmokes.Data;
using GoodSmokes.Models;
using GoodSmokes.Models.CigarMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokesService.Service
{
    public class CigarMakerService
    {
        public CigarMakerService()
        {
        }
        public bool CreateCigarMaker(CigarMakerCreate model)
        {
            var entity =
                new CigarMaker
                {


                    MakerName = model.MakerName,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.CigarMakers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public List<CigarMakerListItems> GetCigarMakers()
        {
            using (var ctx = new ApplicationDbContext())
            {

                var cigarMakerEntity = ctx.CigarMakers;

                var cigarMakerListItems = new List<CigarMakerListItems>();

                foreach (var cigar in cigarMakerEntity)
                {
                    var cigarMakerListItem = new CigarMakerListItems()
                    {


                        
                        MakerId = cigar.MakerId,
                        MakerName = cigar.MakerName
                    };

                    cigarMakerListItems.Add(cigarMakerListItem);
                }

                return cigarMakerListItems;

            }
        }



        public bool UpdateCigarMaker(CigarMakerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarMakers
                        .Single(e => e.MakerId == model.MakerId);
                if (entity.MakerName == model.MakerName)
                {
                    return true;
                }

                {
                    entity.MakerId = model.MakerId;
                    entity.MakerName = model.MakerName;
                }
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCigarMaker(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarMakers
                        .Single(e => e.MakerId == id);
                ctx.CigarMakers.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public CigarMakerDetails GetCigarMakerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarMakers
                        .SingleOrDefault(e => e.MakerId == id);

                var cigarsEntity =
                    ctx
                        .Cigars
                        .Where(s => s.MakerId == id);

                List<string> cigars = new List<string>();

                foreach (var cigarName in cigarsEntity)
                    cigars.Add(cigarName.CigarName);

                return
                    new CigarMakerDetails
                    {

                        
                        MakerId = entity.MakerId,
                        MakerName = entity.MakerName,
                        TheirCigars = cigars,

                    };
            }
        }
    }
}

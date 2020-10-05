using ClassLibrary1;
using GoodSmokes.Data;
using GoodSmokes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokesService.Service
{
    public class CigarService
    {
        public CigarService()
        {
        }
        public bool CreateCigar(CigarCreate model)
        {
            var entity =
                new Cigar
                {

                    CigarName = model.CigarName,
                    MakerId = model.MakerId,
                    CigarTypeId = model.CigarTypeId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Cigars.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<CigarListItems> GetCigars()
        {
            using (var ctx = new ApplicationDbContext())
            {

                var cigarListItems = new List<CigarListItems>();

                foreach (var cigar in ctx.Cigars)
                {
                    var cigarListItem = new CigarListItems()
                    {

                        CigarId = cigar.CigarId,
                        CigarName = cigar.CigarName,
                        TheMaker = cigar.TheMaker.MakerName,
                        TheType = cigar.TheType.CigarTypeName,
                        MakerId = cigar.MakerId,
                        CigarTypeId = cigar.CigarTypeId,
                    };

                    cigarListItems.Add(cigarListItem);
                }

                

                return cigarListItems;

            }
        }



        public bool UpdateCigar(CigarEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Cigars
                        .Single(e => e.CigarId == model.CigarId);
                if (entity.CigarName == model.CigarName)
                {
                    return true;
                }

                {
                    entity.CigarName = model.CigarName;
                }
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCigar(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Cigars
                        .Single(e => e.CigarId == id);
                ctx.Cigars.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public CigarDetail GetCigarById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Cigars
                        .SingleOrDefault(e => e.CigarId == id);

                return
                    new CigarDetail
                    {
                        CigarId = entity.CigarId,
                        CigarName = entity.CigarName,
                        TheMaker = entity.TheMaker.MakerName,
                        TheType = entity.TheType.CigarTypeName,


                    };
            }
        }
    }
}

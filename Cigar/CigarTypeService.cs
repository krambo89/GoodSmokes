using ClassLibrary1;
using GoodSmokes.Data;
using GoodSmokes.Models.CigarType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodSmokesService.Service
{
    public class CigarTypeService
    {

        public bool CreateCigarType(CigarTypeCreate model)
        {
            var entity =
                new CigarType
                {

                    CigarName = model.CigarName,
                    CigarTypeName = model.CigarTypeName,
                    CigarTypeId = model.CigarTypeId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.CigarTypes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public List<CigarTypeListItems> GetCigarTypes()
        {
            using (var ctx = new ApplicationDbContext())
            {

                var cigarTypeEntity = ctx.CigarTypes;

                var cigarTypeListItems = new List<CigarTypeListItems>();

                foreach (var cigar in cigarTypeEntity)
                {
                    var cigarTypeListItem = new CigarTypeListItems()
                    {


                        CigarName = cigar.CigarName,
                        CigarTypeName = cigar.CigarTypeName,
                        CigarTypeId = cigar.CigarTypeId
                    };

                    cigarTypeListItems.Add(cigarTypeListItem);
                }

                return cigarTypeListItems;

            }
        }



        public bool UpdateCigarType(CigarTypeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarTypes
                        .Single(e => e.CigarTypeId == model.CigarTypeId);
                entity.CigarName = model.CigarName;
                entity.CigarTypeName = model.CigarTypeName;
                entity.CigarTypeId = model.CigarTypeId;
                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteCigarType(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarTypes
                        .Single(e => e.CigarTypeId == id);
                ctx.CigarTypes.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public CigarTypeDetails GetCigarTypeById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .CigarTypes
                        .SingleOrDefault(e => e.CigarTypeId == id);

                return
                    new CigarTypeDetails
                    {

                        CigarName = entity.CigarName,
                        CigarTypeId = entity.CigarTypeId,


                    };
            }
        }
    }
}

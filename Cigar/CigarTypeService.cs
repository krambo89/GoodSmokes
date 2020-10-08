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


                    CigarTypeName = model.CigarTypeName,
                    
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

                        CigarTypeId = cigar.CigarTypeId,
                        CigarTypeName = cigar.CigarTypeName,
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
                if (entity.CigarTypeName == model.CigarTypeName)
                {
                    return true;
                }

                {
                    entity.CigarTypeId = model.CigarTypeId;
                    entity.CigarTypeName = model.CigarTypeName;
                }
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

                var cigarsEntity =
                    ctx
                        .Cigars
                        .Where(s => s.CigarTypeId == id);

                List<string> cigars = new List<string>();

                foreach (var cigarName in cigarsEntity)
                    cigars.Add(cigarName.CigarName);

                return
                    new CigarTypeDetails
                    {

                        
                        CigarTypeId = entity.CigarTypeId,
                        CigarTypeName = entity.CigarTypeName


                    };
            }
        }
    }
}

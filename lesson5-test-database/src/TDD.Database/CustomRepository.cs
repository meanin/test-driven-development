using System.Linq;
using TDD.Database.DbModels;

namespace TDD.Database
{
    public class CustomRepository
    {
        private readonly CustomContext _context;

        public CustomRepository(CustomContext context)
        {
            _context = context;
        }

        public void Create(CustomType type)
        {
            _context.CustomTypes.Add(type);
            _context.SaveChanges();
        }

        public CustomType Read(int id)
        {
            return _context.CustomTypes.SingleOrDefault(ct => ct.Id == id);
        }

        public void Update(CustomType type)
        {
            var singleOrDefault = _context.CustomTypes.SingleOrDefault(ct => ct.Id == type.Id);
            singleOrDefault.Field = type.Field;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var singleOrDefault = _context.CustomTypes.SingleOrDefault(ct => ct.Id == id);
            if (singleOrDefault != null)
                _context.CustomTypes.Remove(singleOrDefault);

            _context.SaveChanges();
        }
    }
}

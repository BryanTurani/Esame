using AssociazioneSportiva.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.DataAccess
{
    public class SocietàEntityFrameworkRepository : IRepository<Società>
    {
        private AppDbContext _context;

        public SocietàEntityFrameworkRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Delete(Società model)
        {
            _context.Società.Remove(model);

            var result = _context.SaveChanges();

            return result == 1;
        }

        public Società Find(int id)
        {
            var models = _context.Società.FirstOrDefault(x => x.IdSocietà == id);
            return models;
            
        }

        public List<Società> FindAll()
        {
            var models = _context.Società.Include(x => x.Persone).ToList();
            return models;
        }

        public void Insert(Società model)
        {
            _context.Società.Add(model);
            _context.SaveChanges();
        }


        public void Update(Società model)
        {
            //_context.Società.Update(model);

            //var result = _context.SaveChanges();

            //return result == 1;

            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

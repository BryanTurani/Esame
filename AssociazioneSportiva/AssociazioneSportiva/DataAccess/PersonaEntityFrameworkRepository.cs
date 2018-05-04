using AssociazioneSportiva.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociazioneSportiva.DataAccess
{
    public class PersonaEntityFrameworkRepository : IRepository<Persona>
    {
        private AppDbContext _context;

        public PersonaEntityFrameworkRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool Delete(Persona model)
        {
            _context.Persone.Remove(model);
            var result = _context.SaveChanges();
            return result == 1;
        }

        public Persona Find(int id)
        {
            var result = _context.Persone.FirstOrDefault(x => x.IdPersona == id);
            return result;
        }

        public List<Persona> FindAll()
        {
            var models = _context.Persone.Include(x => x.Società).ToList();
            return models;
        }

        public void Insert(Persona model)
        {
            _context.Persone.Add(model);
            _context.SaveChanges();
        }

        public void Update(Persona model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}

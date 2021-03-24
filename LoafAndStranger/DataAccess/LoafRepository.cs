using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoafAndStranger.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace LoafAndStranger.DataAccess
{
    public class LoafRepository
    {
        AppDbContext _db;
        public LoafRepository(AppDbContext db)
        {
            _db = db;
        }

        public List<Loaf> GetAll()
        {

            return _db.Loaves.ToList();
        }

        public void AddLoaf(Loaf loaf)
        {
            _db.Loaves.Add(loaf);
            _db.SaveChanges();
        }

        public Loaf Get(int id)
        {

            return _db.Loaves.Find(id);
        }

        public void Remove(int id)
        {
            _db.Loaves.Remove(Get(id));
        }

        public void Update(Loaf loaf)
        {
            var existingLoaf = Get(loaf.Id);
            existingLoaf.Sliced = loaf.Sliced;
            //....
            _db.SaveChanges();
        }

        public void Slice(int id)
        {
            var loaf = Get(id);
            loaf.Sliced = true;
            _db.SaveChanges();
        }
    }
}

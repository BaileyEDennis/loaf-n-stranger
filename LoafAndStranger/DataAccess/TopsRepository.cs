using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoafAndStranger.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.EntityFrameworkCore;

namespace LoafAndStranger.DataAccess
{
    public class TopsRepository
    {
        AppDbContext _db;
        public TopsRepository(AppDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Top> GetAll()
        {
            return _db.Tops
                .Include(t => t.Strangers)
                .ThenInclude(s => s.Loaf)
                .AsNoTracking();
        }

        public Top Add(int numberOfSeats)
        {
            var top = new Top { NumberOfSeats = numberOfSeats };

            _db.Tops.Add(top);

            _db.SaveChanges();

            //using var db = new SqlConnection(ConnectionString);

            //var sql = @"INSERT INTO [dbo].[Tops]([NumberOfSeats])
            //                output inserted.*
            //                VALUES(@numberOfSeats)";
            //var top = db.QuerySingle<Top>(sql, new { numberOfSeats });
            return top;
        }
    }
}

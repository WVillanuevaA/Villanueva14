using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Villanueva14.DataContext;
using Villanueva14.Models;

namespace Villanueva14.Services
{
    public class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();


        public bool Create(Compra item)
        {
            try
            {
                _context.Product.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception) { 
                return false;
            
            }
        }
        public bool CreateRange(List<Compra> item) 
        {
            try
            {
                _context.Product.AddRange(item);
                _context.SaveChanges();
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        public List<Compra> Get()
        {
            return _context.Product.ToList();
        }
        public List<Compra> GetByText(string text)
        {
            return _context.Product.Where(x => x.Vendedor.Contains(text)).ToList();
        }
    }
}

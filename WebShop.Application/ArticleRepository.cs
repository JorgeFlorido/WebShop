using System.Collections.Generic;
using System.Linq;
using WebShop.Database;
using WebShop.Domain;

namespace WebShop.Application
{
    public class ArticleRepository
    {
        private ApplicationDbContext _context;

        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Article> GetAll()
        {
            return _context.Articles;
        }

        public Article GetById(int id)
        {
            return _context.Articles.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}

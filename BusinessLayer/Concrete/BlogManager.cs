using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetlistAll();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetByID(id);
        }
        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetlistAll(x=>x.BlogID==id);
        }
    }
}

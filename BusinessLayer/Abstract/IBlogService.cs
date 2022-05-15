using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog blog);
        void BlogDelete(Blog blog);
        void BlogUpdate(Blog blog);
        Blog GetById(int id);
        List<Blog> GetAll();
        
        //Blog içinde include işlemi yaptık. Blogları çagırırken category adını çagırınca hata veriyor. Bu yüzden include işlemi yaptık. Bu metodda include işlemi yapılan metodu çagırcaz
        List<Blog> GetBlogListWithCategory();



    }
}

using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogDal : GenericRepositoryDal<Blog>, IBlogDal
    {
        //Burayı yapmamızın amacı Blogları listelerken Category Adını alırken sistem hata veriyor. Bunun önüne geçmek için Hangi Entityde iş yapıyorsakonun interfacesinde ve Somut sınıf tarafında bu işlemleri yapmak gerekiyor. Include işlemi ilişkili oldugun sınıflarıda getir demek.Joın işlemi gibi. Bu işleme Eager Loading deniyor

        public List<Blog> GetListWithCategory()
        {
            using(var context = new Context())
            {
                return context.Blogs.Include(x=>x.Category).ToList();
            };
        }
    }
}

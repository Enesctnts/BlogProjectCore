using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICommentService
    {
        void ContactAdd(Comment comment);
        void ContactDelete(Comment comment);
        void ContactUpdate(Comment comment);
        Comment GetById(int id);
        List<Comment> GetAll();

    }
}

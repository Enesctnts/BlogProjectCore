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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void ContactAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void ContactDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void ContactUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> GetAll()
        {
            return _commentDal.GetlistAll();
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetByID(id);
        }
    }
}

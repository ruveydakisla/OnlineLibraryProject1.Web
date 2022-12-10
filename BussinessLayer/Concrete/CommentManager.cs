using BussinessLayer.Abstract;
using DataAccessLayer.Abstact;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentdal.Insert(comment);
        }

        public void CommentRemove(Comment comment)
        {
            _commentdal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentdal.Update(comment);
        }

        public List<Comment> GetAllComments()
        {
            return _commentdal.GetListAll();
        }

        public Comment GetById(int id)
        {
            return _commentdal.GetById(id);
        }

    }
}

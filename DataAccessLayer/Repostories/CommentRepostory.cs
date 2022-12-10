using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class CommentRepostory : ICommentDal
    {
        public void CommentAdd(Comment comment)
        {
            using var context = new Context();
            context.Add(comment);
            context.SaveChanges();
        }

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void DeleteComment(Comment comment)
        {
            using var context = new Context();
            context.Remove(comment);
            context.SaveChanges();
        }

        public Comment GetByID(int id)
        {
            using var context = new Context();
            return context.Comments.Find(id);
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> ListAllComments()
        {
            using var context = new Context();
            return context.Comments.ToList();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(Comment comment)
        {
            using var context = new Context();
            context.Update(comment);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Entities;
using Reddit.Models;

namespace Reddit.Repositories
{
    public class ContentRepository
    {
        ContentContext contentContext;

        public ContentRepository (ContentContext contentContext)
        {
            this.contentContext = contentContext;
        }

        public List<Content>GetList()
        {
            return contentContext.Contents.OrderByDescending(x=> x.Votes).ToList();
        }

        public void AddPost(string post)
        {
            var content = new Content { Post = post, };

            contentContext.Contents.Add(content);
            contentContext.SaveChanges();
        }

        public Content GetId(int id)
        {
            return contentContext.Contents.FirstOrDefault(x => x.Id == id);
        }

        public void DeletePost(int id)
        {
            contentContext.Contents.Remove(GetId(id));
            contentContext.SaveChanges();
        }

        public void Update(Content content)
        {
            contentContext.Contents.Update(content);
            contentContext.SaveChanges();
        }

        internal void Vote(int id, string operation)
        {
            if (operation.Equals("plus"))
            {
                GetId(id).Votes++;
            }
            else if (operation.Equals("minus"))
            {
                GetId(id).Votes--;
            }
            contentContext.Update(GetId(id));
            contentContext.SaveChanges();
        }
    }
}


using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly BasedProjectDbContext _context;
        public TagRepository(BasedProjectDbContext context)
        {
            _context = context;
        }
        public void AddTag(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        public void DeleteTag(Tag tag)
        {
            _context?.Tags.Remove(tag);
            _context?.SaveChanges();
        }

        public void DeleteTag(Guid tagId)
        {
            var tag=Find(tagId);
            if (tag!=null)
            {
                DeleteTag(tag);
            }
        }

        public Tag Find(Guid tagId)
        {
            return _context.Tags.FirstOrDefault(t => t.Id == tagId);
        }

        public IList<Tag> GetAllTags()
        {
            return _context.Tags.ToList();
        }

        public Tag GetTagByUrlSlug(string urlSlug)
        {
            return _context.Tags.FirstOrDefault(t => t.TagUrlSlug == urlSlug);
        }

        public void UpdateTag(Tag tag)
        {
            _context.Tags.Update(tag);
            _context.SaveChanges(); 
        }

        //get popular tag
        public IList<Tag> GetPopularTags(int count)
        {
            return _context.Tags
                           .OrderByDescending(t => t.UsageCount) // Sort by UsageCount in descending order
                           .Take(count) // Limit the result
                           .ToList();
        }
    }
}

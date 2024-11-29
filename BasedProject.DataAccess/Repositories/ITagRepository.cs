using BasedProject.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedProject.DataAccess.Repositories
{
    public interface ITagRepository
    {
        Tag Find(Guid tagId);
        void AddTag(Tag tag);
        void UpdateTag(Tag tag);
        void DeleteTag(Tag tag);
        void DeleteTag(Guid tagId);
        IList<Tag> GetAllTags();
        Tag GetTagByUrlSlug(string urlSlug);
        IList<Tag> GetPopularTags(int count);
    }
}

using WeekThreeHomework.Core.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.DataAccess.Abstract
{
    public interface IArticleDal:IEntityRepository<Article>
    {
        
    }
}
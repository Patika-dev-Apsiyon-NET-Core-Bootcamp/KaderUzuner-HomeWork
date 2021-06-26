using WeekThreeHomework.Core.DataAccess.Concrete.EntityFramework;
using WeekThreeHomework.DataAccess.Abstract;
using WeekThreeHomework.Entities.Concrete;

namespace WeekThreeHomework.DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal:EfEntityRepositoryBase<Article,WeekThreeHomeworkContext>, IArticleDal
    {
        
    }
}
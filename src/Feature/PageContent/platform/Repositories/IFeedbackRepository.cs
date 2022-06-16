using Feature.PageContent.Model;
using Sitecore.Data.Items;

namespace Feature.PageContent.Repositories
{
    public interface IFeedbackRepository
    {      

        SubmitViewModel GetSubmitFormItem(Item item, SubmitViewModel submitViewModel);
    }
}

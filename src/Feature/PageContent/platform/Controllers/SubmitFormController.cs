using Feature.PageContent.Model;
using Feature.PageContent.Repositories;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using System;
using System.Web.Mvc;

namespace Feature.PageContent.Controllers
{
    public class FormController : SitecoreController
    {
       
        private readonly IFeedbackRepository feedbackRepository;

        public FormController(IFeedbackRepository _feedbackRepository)
        {
            this.feedbackRepository = _feedbackRepository;
            
        }

        // GET: FeebackForm
        public ActionResult SubmitForm()
        {
            Item currentItem = RenderingContext.Current.Rendering.Item;

            SubmitViewModel submitViewModel = new SubmitViewModel();

            try
            {
                submitViewModel = feedbackRepository.GetSubmitFormItem(currentItem, submitViewModel);

            }
            catch (Exception ex)
            {

                throw ex;
            }

            return View(Constants.SubmitView, submitViewModel);
        }

      


    }
}
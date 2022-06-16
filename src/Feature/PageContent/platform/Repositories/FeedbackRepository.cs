using Feature.PageContent.Model;
using Newtonsoft.Json;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace Feature.PageContent.Repositories
{

    public class FeedbackRepository : IFeedbackRepository
    {


        public SubmitViewModel GetSubmitFormItem(Item currentItem, SubmitViewModel submitViewModel)
        {
            if (currentItem != null && currentItem.Fields != null && currentItem.Fields.Count > 0)
            {
                submitViewModel.SubmitFormItems = new SubmitFormItem
                {
                    FullNameLabel = currentItem.Fields[Template.SubmitForm.Fields.FullNameId].ToString(),
                    MobileNoLabel = currentItem.Fields[Template.SubmitForm.Fields.MobileNoId].ToString(),
                    WritePlacholderLabel = currentItem.Fields[Template.SubmitForm.Fields.WritePlacholderId].ToString(),
                    HelpTextLabel = currentItem.Fields[Template.SubmitForm.Fields.HelpTextId].ToString(),
                    EmailIDLabel = currentItem.Fields[Template.SubmitForm.Fields.EmailIDId].ToString(),
                    AgreeLabel = currentItem.Fields[Template.SubmitForm.Fields.AgreeId].ToString(),
                    SubmitButtonLabel = currentItem.Fields[Template.SubmitForm.Fields.SubmitButtonId].ToString(),
                    ModalLabel = currentItem.Fields[Template.SubmitForm.Fields.ModalLabelId].ToString(),
                    CloseLabel = currentItem.Fields[Template.SubmitForm.Fields.CloseLabelId].ToString(),

                };

                submitViewModel.FeedbackFormData = new FeedbackForm();
            }

            return submitViewModel;

        }

    }
}
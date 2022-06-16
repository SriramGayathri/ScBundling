namespace Feature.PageContent.Model
{
    public class SubmitViewModel
    {
        public SubmitFormItem SubmitFormItems { get; set; }

        public FeedbackForm FeedbackFormData { get; set; }

    }
    
    public class SubmitFormItem
    {       

        public string FullNameLabel { get; set; }

        public string MobileNoLabel { get; set; }

        public string EmailIDLabel { get; set; }

        public string HelpTextLabel { get; set; }

        public string WritePlacholderLabel { get; set; }

        public string AgreeLabel { get; set; }

        public string SubmitButtonLabel { get; set; }

        public string ModalLabel { get; set; }

        public string CloseLabel { get; set; }
    }
}
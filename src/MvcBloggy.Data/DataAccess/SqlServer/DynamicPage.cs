//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Data.DataAccess.SqlServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class DynamicPage
    {
        public int DynamicPageID { get; set; }
        public int LanguageID { get; set; }
        public System.Guid DynamicPageGUID { get; set; }
        public string PageTitle { get; set; }
        public string PageBriefInfo { get; set; }
        public string PageContent { get; set; }
        public string PageTags { get; set; }
        public string PageUrlPortion { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
    
        public virtual Language Language { get; set; }
    }
}
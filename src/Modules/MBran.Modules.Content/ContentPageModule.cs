﻿using MBran.Core;
using MBran.Core.Models;
using MBran.Core.Modules;
using MBran.Core.Modules.Models;
using MBran.Models;
using System.Collections.Generic;
using Umbraco.Core.Models;

namespace MBran.Modules.Content
{
    public class ContentPageModule : PageModule
    {
        public ContentPageModule(IContentHelper contentHelper) 
            : base(contentHelper)
        {

        }

        public override IPageModuleModel GetModel()
        {
            var contentModule = PublishedContent.As<ContentModule>();

            return new ContentPageModuleModel
            {
                Components = contentModule.ContentModuleComponents ?? new List<IPublishedContent>()
            };
            
        }
    }
}

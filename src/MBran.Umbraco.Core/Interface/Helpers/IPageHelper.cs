﻿using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;

namespace MBran.Umbraco.Core
{
    public interface IPageHelper
    {
        int CurrentPageId();
        IPublishedContent CurrentPage();
        T CurrentPage<T>() where T: PublishedContentModel;
    }
}
﻿using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MBran.Core.Components
{
    public static class HtmlHelperComponentExtensions
    {
        public static MvcHtmlString Component<T>(this HtmlHelper helper)
            where T : IComponent, IComponentRender
        {
            //T component = (T)Activator.CreateInstance(typeof(T), helper);
            
            IComponentRender component = DependencyResolver.Current.GetService<T>();
            component.SetHtmlHelper(helper);
            return component.Render();
        }

        //public static MvcHtmlString Component<T>(this HtmlHelper helper,
        //    object model = null,
        //    RouteValueDictionary options = null)
        //    where T : IComponent, IComponentRender
        //{
        //    T component = (T)Activator.CreateInstance(typeof(T), helper);
        //    return component.Render(model, options);
        //}

        //public static MvcHtmlString Component<T>(this HtmlHelper helper,
        //    string viewPath,
        //    object model = null,
        //    RouteValueDictionary options = null)
        //    where T : IComponent, IComponentRender
        //{
        //    T component = (T)Activator.CreateInstance(typeof(T), helper);
        //    return component.Render(viewPath, model, options);
        //}
    }
}

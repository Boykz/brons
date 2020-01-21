using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRONKZ.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;

namespace BRONKZ.HLPClasess
{
    
    public class MainController : Controller
    {
        public SqlClass sql = new SqlClass(ShareClass.BRONCONNECTION);
      //  private readonly CachingClass cachingClass;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);            
        }
        IMemoryCache memoryCache;
        public MainController(IMemoryCache memory)
        {
            memoryCache = memory;
        }
        /// <summary>
        /// Get data from cachingClass. Use like getCacheData<dataType>(key)
        /// (c) Djan
        /// </summary>
        /// <param name="key">Cache key</param>
        /// <returns></returns>
        public T getCacheData<T>(string key)
        {
            object obj = null;
            CachingClass cache = new CachingClass(memoryCache);
            obj = cache.GetDataFromCache(key);
            return (T)obj;
        }
     
        public class CachingClass
        {
            public SqlClass sql = new SqlClass(ShareClass.BRONCONNECTION);

            IMemoryCache memoryCache;
            public CachingClass(IMemoryCache memory)
            {
                memoryCache = memory;
            }

            /// <summary>
            /// Uses in other child methods for getting data from MemoryCache. If data is null returns data from database and sets it to cache.
            /// (c) Djan
            /// </summary>
            /// <param name="key">Cache key</param>
            /// <returns>object</returns>
            public object GetDataFromCache(string key)
            {
                object obj = new object();
                
                if (!memoryCache.TryGetValue(key, out obj))
                {
                    obj = AddDataToCache(key);
                    MemoryCacheEntryOptions options = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(30),
                        SlidingExpiration = TimeSpan.FromDays(30)
                    };
                    memoryCache.Set(key, obj, options);
                }
                return obj;
            }

            /// <summary>
            /// Add data to cache from sql
            /// </summary>
            /// <param name="key"></param>
            /// <returns></returns>
            private object AddDataToCache(string key)
            {                
                switch (key)
                {
                    case ShareClass.cities: { return Cities.GetCitiesList(sql) ; }
                    case ShareClass.countries: { return new Cities { Name = "Almaty", Id = 1 }; }
                    case ShareClass.districts: { return new Cities { Name = "Almaty", Id = 1 }; }
                    default: return null;
                }                
            }
        }
    }
}
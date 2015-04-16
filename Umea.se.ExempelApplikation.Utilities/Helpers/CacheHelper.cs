using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;
using Umea.se.ExempelApplikation.Utilities.Helpers.Contracts;

namespace Umea.se.ExempelApplikation.Utilities.Helpers
{
    public class CacheHelper : ICacheHelper
    {
        public object GetObject(string cacheKey)
        {
            return HttpContext.Current.Cache.Get(cacheKey);
        }

        public void RemoveObject(string cacheKey)
        {
            if (HttpContext.Current.Cache[cacheKey] != null)
                HttpContext.Current.Cache.Remove(cacheKey);
        }

        public void SetObject(string cacheKey, object value, CacheDependency dependency, DateTime absoluteExpiration,
            TimeSpan slidingExpiration)
        {
            HttpContext.Current.Cache.Insert(cacheKey, value, dependency,
                    absoluteExpiration, slidingExpiration);
        }
    }
}

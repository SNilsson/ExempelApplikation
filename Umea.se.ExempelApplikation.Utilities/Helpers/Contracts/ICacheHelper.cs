using System;
using System.Web.Caching;

namespace Umea.se.ExempelApplikation.Utilities.Helpers.Contracts
{
    public interface ICacheHelper
    {
        object GetObject(string cacheKey);
        void SetObject(string cacheKey, object value, CacheDependency dependency, DateTime absoluteExpiration, TimeSpan slidingExpiration);
        void RemoveObject(string cacheKey);
    }
}

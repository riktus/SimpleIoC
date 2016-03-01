using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Container
{
    public static class IoContainer
    {
        private static readonly Dictionary<Type, Type> inversionDict = new Dictionary<Type, Type>();

        /// <summary>
        /// Bind Interface to Class
        /// </summary>
        /// <typeparam name="TSource">Interface</typeparam>
        /// <typeparam name="TDestination">Class</typeparam>
        public static void Bind<TSource, TDestination>()
        {
            inversionDict[typeof(TSource)] = typeof(TDestination);
        }

        /// <summary>
        /// Create instance that inherits interface
        /// </summary>
        /// <typeparam name="TSource">Interface</typeparam>
        /// <returns></returns>
        public static TSource GetInstance<TSource>()
        {
            return (TSource)GetSingleObject(typeof(TSource));
        }

        private static object GetSingleObject(Type targetType)
        {
            var destination = inversionDict[targetType];

            return Activator.CreateInstance(destination);
        }
    }
}

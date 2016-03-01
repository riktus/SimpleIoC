using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public static partial class Core
    {
        /// <summary>
        /// Resolve dependencies with params in ctors
        /// </summary>
        /// <typeparam name="T">Interface to resolve</typeparam>
        /// <returns></returns>
        public static T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private static object Resolve(Type targetType)
        {
            var destination = inversionDict[targetType];
            var ctor = destination.GetConstructors().First();
            var ctorParams = ctor.GetParameters();

            if (ctorParams.Length == 1)
                return Activator.CreateInstance(destination);

            var parameters = new List<object>(ctorParams.Length);

            foreach (var param in ctorParams)
            {
                parameters.Add(Resolve(param.ParameterType));
            }

            return ctor.Invoke(parameters.ToArray());
        }
    }
}

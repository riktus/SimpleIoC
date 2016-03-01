﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Container
{
    public static partial class Core
    {
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

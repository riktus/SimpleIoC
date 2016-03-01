using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Container
{
    public static partial class Core
    {
        private static readonly Dictionary<Type, Type> inversionDict = new Dictionary<Type, Type>();
    }
}

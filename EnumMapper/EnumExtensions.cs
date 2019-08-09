using System;
using System.Collections.Generic;
using System.Text;

namespace EnumMapper
{
    public static class EnumExtensions
    {
        private static EnumMapping mapping = new EnumMapping();

        public static TDest To<TDest>(this Enum source)
            where TDest : Enum
        {
            return mapping.Convert<TDest>(source);
        }
    }
}

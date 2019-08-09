using System;
using System.Collections.Concurrent;

namespace EnumMapper
{
    public class EnumMapping
    {
        private ConcurrentDictionary<(Type, Type, Enum), Enum> converisons = new ConcurrentDictionary<(Type, Type, Enum), Enum>();

        public T Convert<T>(Enum sourceValue)
            where T : Enum
        {
            var sourceType = sourceValue.GetType();
            var destinationType = typeof(T);
            if (converisons.TryGetValue((sourceType, destinationType, sourceValue), out Enum enumValue))
            {
                return (T)enumValue;
            }

            var returnValue = (T)Enum.Parse(destinationType, sourceValue.ToString());

            converisons.TryAdd((sourceType, destinationType, sourceValue), returnValue);
            return returnValue;
        }
    }
}

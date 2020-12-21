using System;

    /// <summary> class obj </summary>
    class Obj
    {
        /// <summary> is only method </summary>
        public static bool IsOnlyASubclass(Type derivedType, Type baseType)
        {
            if (derivedType.IsSubclassOf(baseType))
            {
                return(true);
            }
            return(false);
        }
    }
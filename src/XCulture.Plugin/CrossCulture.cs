using System;
using System.Threading;
using Plugin.XCulture.Abstractions;

namespace Plugin.XCulture
{
    public class CrossCulture
    {
        static readonly Lazy<IXCulture> Implementation = new Lazy<IXCulture>(CreateXCulture, LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Current settings to use
        /// </summary>
        public static IXCulture Current
        {
            get
            {
                var ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }


        private static IXCulture CreateXCulture()
        {
#if PORTABLE
            return null;
#else
            return new XCultureImplementation();
#endif

        }


        private static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }




   
}

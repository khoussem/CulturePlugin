using System.Globalization;

namespace Plugin.XCulture.Abstractions
{

    /// <summary>
    /// Base class of XCulture
    /// </summary>
    public abstract class XCultureBase : IXCulture
    {

        /// <summary>
        /// set or get the current culture
        /// </summary>
        public CultureInfo Culture
        {
            get { return CultureInfo.CurrentCulture; }
            set { SetCulture(value); }
        }


        /// <summary>
        /// set the current culture
        /// </summary>
        /// <param name="cultureInfo"></param>
        protected abstract void SetCulture(CultureInfo cultureInfo);
    }
}

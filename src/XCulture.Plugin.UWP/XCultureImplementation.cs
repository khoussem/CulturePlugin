using System.Globalization;
using Plugin.XCulture.Abstractions;

namespace Plugin.XCulture
{
    /// <summary>
    /// Windows implementation of XCulture
    /// </summary>
    public class XCultureImplementation : XCultureBase
    {

        /// <summary>
        /// Set the culture
        /// </summary>
        /// <param name="cultureInfo">the new culture to be set</param>
        protected override void SetCulture(CultureInfo cultureInfo)
        {
            CultureInfo.CurrentCulture = cultureInfo;
        }
    }
}

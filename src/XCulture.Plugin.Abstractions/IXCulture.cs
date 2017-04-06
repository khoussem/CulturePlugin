using System.Globalization;

namespace Plugin.XCulture.Abstractions
{

    /// <summary>
    /// Interface for culture
    /// </summary>
    public interface IXCulture
    {
        /// <summary>
        /// get or set the current culture
        /// </summary>
        CultureInfo Culture { get; set; }
    }
}

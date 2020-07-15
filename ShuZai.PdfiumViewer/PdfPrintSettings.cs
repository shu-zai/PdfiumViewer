using System;
using System.Collections.Generic;
using System.Text;

namespace ShuZai.PdfiumViewer
{
    /// <summary>
    /// Configures the print document.
    /// </summary>
    public class PdfPrintSettings
    {
        /// <summary>
        /// Gets the mode used to print margins.
        /// </summary>
        public PdfPrintMode Mode { get; }


        /// <summary>
        /// Gets configuration for printing multiple PDF pages on a single page.
        /// </summary>
        public PdfPrintMultiplePages MultiplePages { get; }

        /// <summary>
        /// 是否自适应打印方向
        /// </summary>
        public bool AutoOrientation { get; }

        /// <summary>
        /// Creates a new instance of the PdfPrintSettings class.
        /// </summary>
        /// <param name="mode">The mode used to print margins.</param>
        /// <param name="multiplePages">Configuration for printing multiple PDF
        /// pages on a single page.</param>
        public PdfPrintSettings(PdfPrintMode mode, PdfPrintMultiplePages multiplePages, bool autoOrientation = true)
        {
            Mode = mode;
            MultiplePages = multiplePages;
            AutoOrientation = autoOrientation;
        }
    }
}

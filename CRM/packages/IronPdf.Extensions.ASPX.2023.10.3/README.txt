IronPdf.Extensions.ASPX is an extension package that adds ASPX Functionality to IronPDF.

IronPDF is a .NET library to generate, read, edit & save PDF files in .NET projects. IronPDF features HTML to PDF for .NET 8, .NET 7, .NET 6, .NET 5, Core, Standard & Framework with full HTML to PDF support including CSS3 and JS.

# HOW TO USE
========================

ATTENTION .NET Standard, .NET Core, .NET 5.0, and .NET 6.0 Users:
You MUST add a NuGet package reference to System.Drawing.Common to your project: https://www.nuget.org/packages/System.Drawing.Common/5.0.3

Visit our website for a quick-start guide at https://ironpdf.com/docs/

# C# Code Example
========================
using IronPdf;
 
private void Form1_Load(object sender, EventArgs e)
{
    // Changes the ASPX output into a pdf instead of HTML
    IronPdf.AspxToPdf.RenderThisPageAsPdf();
}
 
# Documentation Links
========================
Code Examples : https://ironpdf.com/examples/
API Reference : https://ironpdf.com/object-reference/api/
Tutorials : https://ironpdf.com/tutorials/
Licensing : https://ironpdf.com/licensing/
Support : developers@ironsoftware.com

# Compatibility
========================
* C#, F#, and VB.NET
* .NET Framework 4.6.2 and above
* Console, Web, and Desktop Apps
* Windows, macOs, Linux (Debian, CentOS, Ubuntu), Docker, Azure, and AWS
* Microsoft Visual Studio or Jetbrains ReSharper & Rider

using Android.Content;
using Android.Graphics.Drawables;
using FFImageLoading;
using FFImageLoading.Svg.Platform;
using SvgImageSource.CustomControl;
using SvgImageSource.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(SvgTabbedPage), typeof(SvgTabbedPageRenderer))]
namespace SvgImageSource.Droid.Renderers
{
    /// <summary>
    /// Defines the <see cref="IconTabbedPage" /> renderer.
    /// </summary>
    /// <seealso cref="TabbedPageRenderer" />
    public class SvgTabbedPageRenderer : TabbedPageRenderer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SvgTabbedPageRenderer"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public SvgTabbedPageRenderer(Context context)
            : base(context)
        {
            // Intentionally left blank
        }

        /// <inheritdoc />
        protected override Drawable GetIconDrawable(FileImageSource icon)
        {



            return ImageService.Instance
                        .LoadUrl(icon.File)
                        .WithCustomDataResolver(new SvgDataResolver(200, 0, true))
                        .AsBitmapDrawableAsync().Result;

        }
    }
}
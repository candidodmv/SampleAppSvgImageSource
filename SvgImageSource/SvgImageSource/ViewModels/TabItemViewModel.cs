using SkiaSharp.Views.Forms;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SvgImageSource.ViewModels
{
    public class TabItemViewModel : INotifyPropertyChanged
    {
        private FFImageLoading.Svg.Forms.SvgImageSource _sourceImage;


        public string RawSource { get; set; } = "https://image.flaticon.com/icons/svg/149/149200.svg";

        public FFImageLoading.Svg.Forms.SvgImageSource SourceImage { get => _sourceImage; set
            {
                _sourceImage = value;
                OnPropertyChanged(nameof(SourceImage));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public TabItemViewModel()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                SourceImage = new FFImageLoading.Svg.Forms.SvgImageSource(ImageSource.FromUri(new Uri("https://image.flaticon.com/icons/svg/149/149200.svg")), 36, 36, true);
            });
        }
    }
}

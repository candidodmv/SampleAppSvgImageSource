using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TabbedSvgIconImageSource.ViewModels
{
    public class TabbedItemViewModel
    {
        private ImageSource _sourceImage;


        public string RawSource { get; set; } = "https://image.flaticon.com/icons/svg/149/149200.svg";

        public ImageSource SourceImage
        {
            get => _sourceImage; set
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


        public TabbedItemViewModel(string url)
        {
            SourceImage = Xamarin.Forms.Svg.SvgImageSource.FromSvgUri(url ?? "https://image.flaticon.com/icons/svg/149/149200.svg", 36, 36, Color.Black);
            //Device.BeginInvokeOnMainThread(async () =>
            //{
            //    SourceImage = new FFImageLoading.Svg.Forms.SvgImageSource(ImageSource.FromUri(new Uri("https://image.flaticon.com/icons/svg/149/149200.svg")), 36, 36, true);
            //});
        }
    }
}

using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SvgImageSource.ViewModels
{
    public class TabItemViewModel : INotifyPropertyChanged
    {
        private FFImageLoading.Svg.Forms.SvgImageSource _sourceImage;


        public string RawSource { get; set; } = "https://mobile-portalfacil.azurewebsites.net/icons/servicos_online.svg";

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
                await Task.Delay(TimeSpan.FromSeconds(8));
                SourceImage = FFImageLoading.Svg.Forms.SvgImageSource.FromUri(new Uri("https://mobile-portalfacil.azurewebsites.net/icons/servicos_online.svg"), 96, 96, true);
            });
        }
    }
}

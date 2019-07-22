using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SvgImageSource.ViewModels
{
    public class TabItemViewModel : INotifyPropertyChanged
    {
        public FFImageLoading.Svg.Forms.SvgImageSource SourceImage { get; set; }
        public string RawSource { get; set; } = "https://mobile-portalfacil.azurewebsites.net/icons/servicos_online.svg";
        public event PropertyChangedEventHandler PropertyChanged;


        public TabItemViewModel()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                SourceImage = FFImageLoading.Svg.Forms.SvgImageSource.FromUri(new Uri(RawSource));
            });
            
        }
    }
}

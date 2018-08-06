using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FitnessGuru.Model;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms;

namespace FitnessGuru
{
    public partial class Progress : ContentPage


    {
        ObservableCollection<MediaModel> Photos = new ObservableCollection<MediaModel>();


        public Progress()
        {
            InitializeComponent();

        }

        private async void photoBtn_Pressed(object sender, EventArgs e)

        {


            var isInitialized = await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialized)
            {
                await DisplayAlert("Error!" , "Camera not Found", "ok");
                return;
            }

            var newPhotoId = Guid.NewGuid();

            using (var photo = await CrossMedia.Current.TakePhotoAsync(new StoreVideoOptions()
            {
                Name = newPhotoId.ToString(),
                SaveToAlbum = true,
                DefaultCamera = CameraDevice.Rear,
                Directory = "Fitness Gallery",
                CustomPhotoSize = 50

            }))
            {
                if (string.IsNullOrWhiteSpace(photo?.Path))
                {
                    return;
                }

                var newPhotoMedia = new MediaModel()
                {
                    MediaID = newPhotoId,
                    Path = photo.Path,
                    LocalDateTime = DateTime.Now
                };

                Photos.Add(newPhotoMedia);
                photo.Dispose();
            
            }

            listPhotos.ItemsSource = Photos;

        }
        
    }
}

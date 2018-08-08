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
        /// <summary>
        /// Gets if a camera is available on the device
        /// </summary>
        bool IsCameraAvailable { get; }

        /// <summary>
        /// Gets if ability to take photos supported on the device
        /// </summary>
        bool IsTakePhotoSupported { get; }

        /// <summary>
        /// Gets if the ability to pick photo is supported on the device
        /// </summary>
        bool IsPickPhotoSupported { get; }

        /// <summary>
        /// Gets if ability to take video is supported on the device
        /// </summary>
        bool IsTakeVideoSupported { get; }

        /// <summary>
        /// Gets if the ability to pick a video is supported on the device
        /// </summary>
        bool IsPickVideoSupported { get; }




        public Progress()
        {
            InitializeComponent();


        }

        private async void photoBtn_Pressed(object sender, EventArgs e)

        {


            var isInitialized = await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported || !CrossMedia.IsSupported || !isInitialized)
            {
                await DisplayAlert("Error!", "Camera not Found", "ok");
                return;
            }

            var newPhotoId = Guid.NewGuid();

            using (var photo = await CrossMedia.Current.TakePhotoAsync(new StoreVideoOptions()
            {
                Name = newPhotoId.ToString(),
                SaveToAlbum = true,
                DefaultCamera = CameraDevice.Rear,
                Directory = "Fitness Gallery",
               // CustomPhotoSize = 50

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

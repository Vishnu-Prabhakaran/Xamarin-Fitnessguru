using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Plugin.Media;
using UIKit;

namespace FitnessGuru.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static async System.Threading.Tasks.Task MainAsync(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");

            Func<object> func = () =>
            {
                var imageView = new UIImageView(UIImage.FromBundle("face-template.png"));
                imageView.ContentMode = UIViewContentMode.ScaleAspectFit;

                var screen = UIScreen.MainScreen.Bounds;
                imageView.Frame = screen;

                return imageView;
            };

            //Take Photo, could be in iOS Project, or in shared code where there function is passed up via Dependency Services.
            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                OverlayViewProvider = func
            });
        }

        }


}

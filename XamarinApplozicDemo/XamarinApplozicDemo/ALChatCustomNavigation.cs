using System;
using Foundation;
using UIKit;
using ApplozicXamarinWrapper;


//TODO Navigation: ALChatCustomNavigation custom controller which extends ALNavigationController
namespace XamarinApplozicDemo
{
    public enum MessageContentType : uint
    {
        ALMESSAGE_CONTENT_DEFAULT = 0,
        ALMESSAGE_CONTENT_ATTACHMENT = 1,
        ALMESSAGE_CONTENT_LOCATION = 2,
        ALMESSAGE_CONTENT_TEXT_HTML = 3,
        ALMESSAGE_CONTENT_PRICE= 4,
        ALMESSAGE_CONTENT_TEXT_URL= 5,
        ALMESSAGE_CONTENT_VCARD= 7,
        ALMESSAGE_CONTENT_AUDIO =8,
        ALMESSAGE_CONTENT_CAMERA_RECORDING= 9,
        ALMESSAGE_CHANNEL_NOTIFICATION =10,
        ALMESSAGE_CONTENT_CUSTOM =101,
        ALMESSAGE_CONTENT_HIDDEN =11
    }

    public class ALChatCustomNavigation : ALNavigationController

    {
        public ALChatCustomNavigation()
        {
        }

        public ALChatCustomNavigation(IntPtr argument){
            
        }

        override
        public NSMutableArray GetCustomButtons (UIViewController controllerReference)
        {
            NSMutableArray<UIView> array = new NSMutableArray<UIView>();
            array.AddObjects(GetButtonView(controllerReference));
            return array;
        } 

        //Preaper Your view
        public UIView GetButtonView (UIViewController controllerReference)
        {

            UIImageView imageView = new UIImageView();
            imageView.Frame = new CoreGraphics.CGRect(0, 0, 20f, 20f);
            imageView.TintColor = UIColor.White;
            imageView.BackgroundColor = UIColor.Red;

            UIView view = new UIView();
            view.Frame = new CoreGraphics.CGRect(0, 0,imageView.Frame.Size.Width, imageView.Frame.Size.Width);
            view.Bounds = new CoreGraphics.CGRect(view.Bounds.X, view.Bounds.Y, view.Bounds.Width, view.Bounds.Height);
            view.AddSubview(imageView);
            view.BackgroundColor = UIColor.Clear;
            
            // Report touch
            Action action = () =>
            {

                //Presenting View controller with navigation   
                Console.WriteLine("Custom Button selector selected");
                UIStoryboard Storyboard1 = UIStoryboard.FromName("Main", null);
                MainViewController MainViewController = Storyboard1.InstantiateViewController("MainViewController") as MainViewController;

                ALChatViewController chatControllers = (ALChatViewController)controllerReference;

                Console.WriteLine("chatControllers #### : " + chatControllers.ContactIds);

                UINavigationController ctrl = new UINavigationController(MainViewController);
                ctrl.NavigationBar.BarTintColor = UIColor.FromRGB(17, 62, 105);
                ctrl.NavigationBar.TintColor = UIColor.White;

                ctrl.NavigationItem.SetLeftBarButtonItem(
                    new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain, (sender, e) => { }),true);
                
                controllerReference.PresentViewController(ctrl, true, () => { });


            };

            UITapGestureRecognizer tapGesture = new UITapGestureRecognizer(action);
            tapGesture.NumberOfTapsRequired = 1;
            view.AddGestureRecognizer(tapGesture);
            return view;
        }

        public UIView NewButtonClicked()
        {
            UIButton btn = new UIButton();
            btn.Frame = new CoreGraphics.CGRect(0, 0, 30f, 30f);
            btn.SetBackgroundImage(UIImage.FromFile("Images/BrowseImage.png"), UIControlState.Normal);
            btn.TouchUpInside += (sender, e) =>
            {
                // NSObject CallSender = new NSObject();
                //this.PerformSegue("kannan", CallSender);

                UINavigationController ctrl = new UINavigationController();
                ctrl.NavigationBar.BarTintColor = UIColor.FromRGB(17, 62, 105);
                ctrl.NavigationBar.TintColor = UIColor.White;
                UIStoryboard Storyboard1 = UIStoryboard.FromName("Main", null);
                MainViewController MainViewController = Storyboard1.InstantiateViewController("MainViewController") as MainViewController;
                this.PresentViewController(MainViewController, true, () => { });


            };

            UIView view = new UIView();
            view.Frame = new CoreGraphics.CGRect(0, 0, btn.Frame.Size.Width, btn.Frame.Size.Width);
            view.Bounds = new CoreGraphics.CGRect(view.Bounds.X, view.Bounds.Y, view.Bounds.Width, view.Bounds.Height);
            view.AddSubview(btn);
            view.BackgroundColor = UIColor.Clear;
            return view;    
        }

        //Sending Message With Attachment
        public void sendMessageWithAttachment(){
            
            UIImageView imageview = new UIImageView();
            imageview.Image = UIImage.FromBundle("test.png");

            NSData imgData = imageview.Image.AsJPEG();
            NSError err = null;

            var documentsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string sTempPath = "Demand.png";
            string jpgFilename = System.IO.Path.Combine(documentsDirectory, sTempPath);

            bool b = imgData.Save(jpgFilename, false, out err);

            ALMessageServiceWrapper messaageService = new ALMessageServiceWrapper();
            ALMessage messageObject =   messaageService.CreateMessageEntityOfContentType(1, "119933", "PhotoTAG :");

            messaageService.SendMessageWithAttachment(messageObject, jpgFilename, this, 1); 
        }

    }
}

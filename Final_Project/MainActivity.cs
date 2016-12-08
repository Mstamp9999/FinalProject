using Android.App;
using Android.Widget;
using Android.OS;

namespace Final_Project
{
    [Activity(Label = "Final_Project", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var startButton = FindViewById<Button>(Resource.Id.button1);
            startButton.Click += delegate {
                ShowTitle(this);
                ShowNext(this);
                ShowBack(this);
                HidePage(this);
                HideSecondBack(this);
                HideThirdBack(this);
                HideSecondNext(this);
                HideThirdNext(this);
                HideNextPage(this);
                HideThirdPage(this);
            };

            var nextButton = FindViewById<Button>(Resource.Id.button5);
            nextButton.Click += delegate {
                HideTitle(this);
                ShowPage(this);
                HideNext(this);
                HideBack(this);
                ShowSecondBack(this);
                ShowSecondNext(this);
            };

            var SecondnextButton = FindViewById<Button>(Resource.Id.button6);
            SecondnextButton.Click += delegate {
                ShowNextPage(this);
                ShowThirdBack(this);
                HidePage(this);
                HideSecondBack(this);
                HideSecondNext(this);
            };

            var ThirdnextButton = FindViewById<Button>(Resource.Id.button7);
            ThirdnextButton.Click += delegate {
                ShowThirdPage(this);
                HideNextPage(this);
                HideSecondBack(this);
                HideSecondNext(this);
                ShowThirdNext(this);
                ShowThirdBack(this);
            };

            var backButton = FindViewById<Button>(Resource.Id.button3);
            backButton.Click += delegate {
                ShowTitle(this);
                HidePage(this);
            };

            var SecondbackButton = FindViewById<Button>(Resource.Id.button8);
            SecondbackButton.Click += delegate {
                ShowPage(this);
                HideSecondBack(this);
                HideSecondNext(this);
                ShowBack(this);
                ShowNext(this);
                HideNextPage(this);
            };

            var ThirdbackButton = FindViewById<Button>(Resource.Id.button9);
            ThirdbackButton.Click += delegate {
                ShowNextPage(this);
                HideThirdBack(this);
                HideThirdNext(this);
                ShowSecondBack(this);
                ShowSecondNext(this);
            };
        }

        public static void ShowTitle(Activity Appear)
        {
            var MainTitle = Appear.FindViewById<TextView>(Resource.Id.Title);
            MainTitle.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HidePage(Activity activity)
        {
            var FirstPage = activity.FindViewById<TextView>(Resource.Id.textView2);
            FirstPage.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowBack(Activity Appear)
        {
            var FirstBackButton = Appear.FindViewById<Button>(Resource.Id.button3);
            FirstBackButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideBack(Activity Appear)
        {
            var FirstBackButton = Appear.FindViewById<Button>(Resource.Id.button3);
            FirstBackButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void HideSecondBack(Activity activity)
        {
            var SecondBackButton = activity.FindViewById<Button>(Resource.Id.button8);
            SecondBackButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowSecondBack(Activity Appear)
        {
            var SecondBackButton = Appear.FindViewById<Button>(Resource.Id.button8);
            SecondBackButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideThirdBack(Activity activity)
        {
            var ThirdBackButton = activity.FindViewById<Button>(Resource.Id.button9);
            ThirdBackButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void HideThirdNext(Activity activity)
        {
            var ThirdNextButton = activity.FindViewById<Button>(Resource.Id.button7);
            ThirdNextButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowThirdBack(Activity Appear)
        {
            var ThirdBackButton = Appear.FindViewById<Button>(Resource.Id.button9);
            ThirdBackButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideTitle(Activity activity)
        {
            var MainTitle = activity.FindViewById<TextView>(Resource.Id.Title);
            MainTitle.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void HideNext(Activity activity)
        {
            var FirstNextButton = activity.FindViewById<Button>(Resource.Id.button5);
            FirstNextButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowNext(Activity Appear)
        {
            var FirstNextButton = Appear.FindViewById<Button>(Resource.Id.button5);
            FirstNextButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideSecondNext(Activity activity)
        {
            var SecondNextButton = activity.FindViewById<Button>(Resource.Id.button6);
            SecondNextButton.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowSecondNext(Activity Appear)
        {
            var SecondNextButton = Appear.FindViewById<Button>(Resource.Id.button6);
            SecondNextButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void ShowThirdNext(Activity Appear)
        {
            var ThirdNextButton = Appear.FindViewById<Button>(Resource.Id.button7);
            ThirdNextButton.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void ShowPage(Activity Appear)
        {
            var FirstPage = Appear.FindViewById<TextView>(Resource.Id.textView2);
            FirstPage.Visibility = Android.Views.ViewStates.Visible;
        }
        public static void ShowNextPage(Activity Appear)
        {
            var SecondPage = Appear.FindViewById<TextView>(Resource.Id.textView3);
            SecondPage.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideNextPage(Activity activity)
        {
            var SecondPage = activity.FindViewById<TextView>(Resource.Id.textView3);
            SecondPage.Visibility = Android.Views.ViewStates.Gone;
        }

        public static void ShowThirdPage(Activity Appear)
        {
            var ThirdPage = Appear.FindViewById<TextView>(Resource.Id.textView4);
            ThirdPage.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HideThirdPage(Activity activity)
        {
            var ThirdPage = activity.FindViewById<TextView>(Resource.Id.textView4);
            ThirdPage.Visibility = Android.Views.ViewStates.Gone;
        }
    }
}


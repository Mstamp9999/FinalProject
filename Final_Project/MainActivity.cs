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
                HidePage(this);
            };

            var nextButton = FindViewById<Button>(Resource.Id.button5);
            nextButton.Click += delegate {
                HideTitle(this);
                ShowPage(this);
                HideNext(this);
                ShowSecondNext(this);
            };

            var SecondnextButton = FindViewById<Button>(Resource.Id.button6);
            SecondnextButton.Click += delegate {
                ShowNextPage(this);
                HidePage(this);
                HideSecondNext(this);
                ShowThirdNext(this);
                HideNextPage(this);
            };

            var ThirdnextButton = FindViewById<Button>(Resource.Id.button7);
            ThirdnextButton.Click += delegate {
                ShowThirdPage(this);
                HideNextPage(this);
            };

            var backButton = FindViewById<Button>(Resource.Id.button3);
            backButton.Click += delegate {
                ShowTitle(this);
                HidePage(this);
            };

            var ThirdbackButton = FindViewById<Button>(Resource.Id.button8);
            ThirdbackButton.Click += delegate {
                ShowNextPage(this);
                HideBack(this);
                HidePage(this);
            };
        }

        public static void ShowTitle(Activity activity)
        {
            var MainTitle = activity.FindViewById<TextView>(Resource.Id.Title);
            MainTitle.Visibility = Android.Views.ViewStates.Visible;
        }

        public static void HidePage(Activity Appear)
        {
            var FirstPage = Appear.FindViewById<TextView>(Resource.Id.textView2);
            FirstPage.Visibility = Android.Views.ViewStates.Gone;
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
    }
}


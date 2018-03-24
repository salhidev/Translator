using Android.Content;
using Android.OS;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public partial class App : Application
    {
        static bool bHasClipChangedListener = false;
        ClipboardManager ClipBoardManager = (ClipboardManager) Forms.Context.GetSystemService(Context.ClipboardService);
        public App()
        {
            InitializeComponent();

            MainPage = new App1.MainPage();
        }

        protected override void OnStart()
        {

            // Handle when your app starts

        }




        public class OnPrimaryClipChangedListener : Java.Lang.Object, ClipboardManager.IOnPrimaryClipChangedListener
        {
            ClipboardManager myClipBoard;

            public void onPrimaryClipChanged()
            {
                ClipData clipData = myClipBoard.PrimaryClip;
                //Toast.MakeText(Application.Current, 1, ToastLength.Short).Show();
                ClipData.Item item = clipData.GetItemAt(0);
                //Translator.MainPage.likecount.Text = item.Text;
            }

            public void OnPrimaryClipChanged()
            {
                throw new NotImplementedException();
            }
        }

        private void RegPrimaryClipChanged()
        {

            if (!bHasClipChangedListener)
            {
                ClipBoardManager.AddPrimaryClipChangedListener(new OnPrimaryClipChangedListener());
                bHasClipChangedListener = true;
            }
        }
        private void UnRegPrimaryClipChanged()
        {
            if (bHasClipChangedListener)
            {
                ClipBoardManager.RemovePrimaryClipChangedListener(new OnPrimaryClipChangedListener());
                bHasClipChangedListener = false;
            }
        }
        protected override void OnSleep()
        {
            // Handle when your app sleeps
            base.OnSleep();
            RegPrimaryClipChanged();

        }


        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
namespace App1
{

    public class OnPrimaryClipChangedListener : Java.Lang.Object, ClipboardManager.IOnPrimaryClipChangedListener
    {

        /// <summary>
        /// Callback that gets invoked when the primary clip of the device changes.
        /// </summary>
        public void OnPrimaryClipChanged()
        {
            //performClipboardCheck();
            Android.OS.Vibrator v = (Android.OS.Vibrator)Xamarin.Forms.Forms.Context.GetSystemService(Context.VibratorService);
            // Vibrate for 5 seconds
            v.Vibrate(5000);
        }
        //private void performClipboardCheck()
        //{
        //    ClipboardManager cb = (ClipboardManager)Forms.Context.GetSystemService(Context.ClipboardService);
        //    if (cb.HasPrimaryClip)
        //    {
        //        ClipData cd = cb.PrimaryClip;
        //        ClipData.Item item = cd.GetItemAt(0);
        //        System.String text1 = item.Text;
        //        Vibrator v = (Vibrator)Forms.Context.GetSystemService(Context.VibratorService);
        //        // Vibrate for 5 seconds
        //        v.Vibrate(5000);
        //    }
        //}

    }
}

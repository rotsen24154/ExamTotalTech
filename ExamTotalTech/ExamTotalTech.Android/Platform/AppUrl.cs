using Android.App;
using Android.Content;
using ExamTotalTech.Platform;
using System;

namespace ExamTotalTech.Droid.Platform
{
    /// <summary>
    /// Implementation of interface IAppUrl for Android
    /// </summary>
    public class AppUrl : IAppUrl
    {
        /// <summary>
        /// Opens phone aplication to make call.
        /// </summary>
        /// <param name="number">Number to make call</param>
        public void OpenCallPhone(string number)
        {
            var primaryUrl = string.Format("tel:{0}", number);
            var intent = new Intent(Intent.ActionDial, Android.Net.Uri.Parse(primaryUrl));
            intent.AddFlags(ActivityFlags.NewTask);
            Application.Context.StartActivity(intent);
        }
    }
}
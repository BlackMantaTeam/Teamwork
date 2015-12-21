using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using Windows.UI.Xaml;
using Windows.UI.Notifications;
using NotificationsExtensions.Toasts;

namespace MusicPlayer.Common
{
    public class NotificationManager
    {

        private void DisplayNotification()
        {
            //string toastXmlString = "<toast>"
            //                   + "<visual version='1'>"
            //                   + "<binding template='ToastText04'>"
            //                   + "<text id='1'>Header</text>"
            //                   + "<text id='2'>Line 1</text>"
            //                   + "<text id='3'>Line 2</text>"
            //                   + "</binding>"
            //                   + "</visual>"
            //                   + "</toast>";

            //Windows.Data.Xml.Dom.XmlDocument toastDOM = new Windows.Data.Xml.Dom.XmlDocument();
            //toastDOM.LoadXml(toastXmlString);

            //// Create a toast, then create a ToastNotifier object to show
            //// the toast
            //ToastNotification toast = new ToastNotification(toastDOM);

            //ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Java.Interop;

namespace MPlayer.Droid
{
    public class JSBridge : Java.Lang.Object
    {
        readonly WeakReference<MJPEGPlayerRenderer> mjpegplayerrenderer;

        public JSBridge(MJPEGPlayerRenderer hybridRenderer)
        {
            mjpegplayerrenderer = new WeakReference<MJPEGPlayerRenderer>(hybridRenderer);
        }

        [JavascriptInterface]
        [Export("InvokeFailedAction")]
        public void InvokeFailedAction(string data)
        {
            MJPEGPlayerRenderer hybridRenderer;

            if (mjpegplayerrenderer != null && mjpegplayerrenderer.TryGetTarget(out hybridRenderer))
            {
                hybridRenderer.Element.InvokeFailedAction(data);
            }
        }
    }
}
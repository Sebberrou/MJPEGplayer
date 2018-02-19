using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MPlayer
{
    public class MJPEGPlayer : View
    {
        public static readonly BindableProperty UrlProperty = BindableProperty.Create(
            propertyName: "Url",
            returnType: typeof(string),
            declaringType: typeof(MJPEGPlayer),
            defaultValue: default(string));
        public string Url
        {
            get { return (string)GetValue(UrlProperty); }
            set { SetValue(UrlProperty, value); }
        }

        Action<string> failedAction;
        public void RegisterFailedAction(Action<string> callback)
        {
            failedAction = callback;
        }
        public void InvokeFailedAction(string msg ="Stream failed")
        {
            if (failedAction == null)
                return;
            failedAction.Invoke(msg);
        }

        public void Cleanup()
        {
            failedAction = null;
        }
	}
}
// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AppBookStore
{
    [Register ("BookDetailsViewController")]
    partial class BookDetailsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView bookImageView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (bookImageView != null) {
                bookImageView.Dispose ();
                bookImageView = null;
            }
        }
    }
}
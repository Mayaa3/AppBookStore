using Foundation;
using System;
using UIKit;

namespace AppBookStore
{
    public partial class BookDetailViewController : UIViewController
    {
        public Book selectedBook;
        public BookDetailViewController (IntPtr handle) : base (handle)
        {


        }

        public override void ViewWillAppear(bool animated)
        {
            bookNameLabel.Text = selectedBook.Name;
            bookImageView.Image = UIImage.FromFile(selectedBook.ImagePath);

        }
    }
}
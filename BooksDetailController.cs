using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AppBookStore
{
    public partial class BooksDetailController : UITableViewController
    {
        public BooksDetailController (IntPtr handle) : base (handle)
        {
            public Book selectedBook;
            public BooksDetailController (IntPtr handle) : base (handle)
            {
            }

            public override void ViewWillAppear(bool animated)
        {
                bookNameLabel.Text = selectedBook.Name;
            bookImageView.Image = UIImage.FromFile(selectedBook.ImagePath);

        }


        }
    }
}
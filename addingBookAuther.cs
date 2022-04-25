// first change to view model 

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Recalla.Model.ViewModel
{
    public class BookViewModel
    {
        [Required]
        [DisplayName("book name")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        // book pulibsher information taking

        public int BookPublisherId { get; set; }

        public List<int> AuthersId { get; set; } // this is the new part

    }
}


//  [+] service page 

        public void AddBook(BookViewModel BookModel) {
            Book bookObj = new Book()
            {
                Title = BookModel.Title,
                PublisherId = BookModel.BookPublisherId,
            };

            this._context.Books.Add(bookObj);
            this._context.SaveChanges();

            foreach (var id in BookModel.AuthersId) // add book auther information to the book auther table
            {
                var _book_auther = new BookAutherModel
                {
                    BookId = bookObj.Id,
                    AutherId = id
                };
                this._context.BookAutherModels.Add(_book_auther);
                this._context.SaveChanges();
            }
        }
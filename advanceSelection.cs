 
//  new book view model 
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Recalla.Model.ViewModel
{
    public class BookVm
    {
        [Required]
        [DisplayName("book name")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        // book pulibsher information taking

        public string BookPublisherName { get; set; }

        public List<string> AuthersName { get; set; }
    }
}

 

//   selection 
// using  select 
 
 public BookVm? GetBookwithAuther(int id) {
            var bookWithAuther = this._context.Books.Where(q => q.Id == id).Select(n => new BookVm() { 
                Title = n.Title,
                BookPublisherName = n.Publisher.PublisherName,
                AuthersName = n.BookAutherModels.Select( x => x.Auther.FirstName).ToList()
            }).FirstOrDefault();
            return bookWithAuther;            
        }
    

// another 

        // authers books 
        public AutherVm? GetAutherwithBooks(int AutherId) {
            var _autherWithBooks = this._context.Authers.Where(a => a.Id == AutherId).Select(q => new AutherVm()
            {
                FirstName = q.FirstName,
                LastName = q.LastName,
                BookNames = q.BookAutherModels.Select(x => x.Book.Title).ToList()
            }).FirstOrDefault();
            return _autherWithBooks;
        }
         



         /////////////////////////// most advance 

namespace Recalla.Model.ViewModel
{
    public class PublisherVm
    {

        public string PublisherName { get; set; }
        public string PublisherCountry { get; set; }
        public string PublisherDescription { get; set; }

        public List<BookWithAuther> BookAuthers  { get; set; }
    }


    public class BookWithAuther { 
        
        public string Title { get; set; }
        public List<string> Authersname { get; set; }
    }
}

// tow model s selection 




            public PublisherVm? GetPulisherwihAllBooksAndAuthers(int publisherId) {
            var _publisherWithBooksAndAuthers = this._context.publishers.Where(publisher => publisher.ID == publisherId).Select(n => new PublisherVm()
            {
                PublisherName = n.PublisherName,
                PublisherCountry = n.PublisherCountry,
                PublisherDescription = n.PublisherDescription,
                BookAuthers = n.Books.Select(x => new BookWithAuther()
                {
                    Title = x.Title,
                    Authersname = x.BookAutherModels.Select(y => y.Auther.FirstName).ToList()
                }).ToList()
            }).FirstOrDefault();
            return _publisherWithBooksAndAuthers;
        }

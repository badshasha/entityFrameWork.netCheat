 
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
    
    
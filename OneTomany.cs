
///////////////////////////////////////////////////////////
///////////// one ///////////////////////////////////////

using System.ComponentModel.DataAnnotations;
using lastTesting.Models.baseContext;


namespace lastTesting.Models
{
    public class Publisher : BaseContext
    {
        [Required]
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }

    }
}



/////////////////////////////////////////////////////////////
/////////////////// many  ///////////////////////////////////////



using lastTesting.Models.baseContext;
using System.ComponentModel.DataAnnotations;
namespace lastTesting.Models
{
    public class Book : BaseContext
    {
        [Required]
        public string Name { get; set; }

        // one to many relationship
        // one publisher can have many book and one book belongs to one publisher 

        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }


    }
}

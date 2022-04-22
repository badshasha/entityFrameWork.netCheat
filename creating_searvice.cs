using Recalla.Data;
using Recalla.Model;
using Recalla.Model.ViewModel;

namespace Recalla.Services
{
    public class PublisherService
    {
        private readonly ApplicationDbContext _context;
        public PublisherService(ApplicationDbContext context)
        {
            this._context = context;
        }
        // ******************************************
        //          view pulisher information 
        // ******************************************

        // get pulisher from id 
        public Publisher? GetPublisherFromId(int? id) { 
            if(id == null)
            {
                return null;
            }
            return this._context.publishers.Where(p => p.ID.Equals(id)).FirstOrDefault();
        }

        // get all publishers 

        public List<Publisher>? GetAllPublishers() {
            return this._context.publishers.ToList();
        }

        // get publisher form name

        public List<Publisher>? GetPublisherFromName(string? name) {
            if (name != null) {
                return this._context.publishers.Where(p=>p.PublisherName.Contains(name)).ToList();
            }
            return null;
        }

        // ******************************************
        //          add publisehrs 
        // ******************************************

        public void AddPublisher(PublisherViewModel publisherInfo) {
            Publisher publisherObj = new Publisher()
            {
                PublisherName = publisherInfo.PublisherName,
                PublisherDescription= publisherInfo.PublisherDescription,
                PublisherCountry= publisherInfo.PublisherCountry,   
            };
            try
            {
                this._context.publishers.Add(publisherObj);
                this._context.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception("publisher informaton cannot add to the database");
            }
            

        }


    }
}

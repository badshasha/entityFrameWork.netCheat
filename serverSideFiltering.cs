        public List<Publisher>? GetAllPublishers(string sortBy,string searchString)
        {
            
            List<Publisher>? allpublisher = this._context.publishers.OrderBy(n => n.PublisherName).ToList();
            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "name_desc":
                        allpublisher = allpublisher.OrderByDescending(n => n.PublisherName).ToList();
                        break;
                    default:
                        break;

                }
            }
            if (!string.IsNullOrEmpty(searchString)) {
                allpublisher = allpublisher.Where(n => n.PublisherName.Contains(searchString)).ToList(); // this is the part 
            }
            return allpublisher;
        }
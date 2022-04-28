
        public List<Publisher>? GetAllPublishers(string sortBy)
        {
            List<Publisher>? allpublisher =  this._context.publishers.OrderBy(n=>n.PublisherName).ToList();
            if (!string.IsNullOrEmpty(sortBy)) {
                switch (sortBy) { 
                    case "name_desc":
                        allpublisher = allpublisher.OrderByDescending(n => n.PublisherName).ToList();
                        break;
                    default:
                        break;

                }
            }
            return allpublisher;
        }
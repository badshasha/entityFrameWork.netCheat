// find any thing 
List<Publisher> publisher_list = this._context.publishers.ToList();


// find specific 
var publisher = await _context.publishers.FirstOrDefaultAsync(m => m.Id == id);
 var publisher = await _context.publishers.FindAsync(id);
// value have provide vlaue other wise it's provide null value 

//  create new entity
_context.Add(publisher)
_context.SaveChages()

// update entity
// id comes update hidden infor
 _context.Update(publisher);
await _context.SaveChangesAsync();

//  Remove element 
var publisher = await _context.publishers.FindAsync(id);
_context.publishers.Remove(publisher);
await _context.SaveChangesAsync();



// most common usage 


            var p2  = _ad.publishers.First( x => x.Description.Equals("sri lanka"));
            var p3 = _ad.publishers.Where(publisher => publisher.Name.Contains("s"));
            var p4 = _ad.publishers.Where(publisher => EF.Functions.Like(publisher.Name,"%a%"));



            
            var count = _ad.publishers.Count();
            var longCount = _ad.publishers.LongCount();
            var min = _ad.publishers.MinAsync();
            var max = _ad.publishers.MaxAsync();
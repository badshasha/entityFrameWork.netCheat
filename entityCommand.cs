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

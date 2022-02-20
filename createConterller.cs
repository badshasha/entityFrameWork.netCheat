namespace lastTesting.Controllers{


class PublicController : controller
{
    private readonly ApplicationDbContext _context;
    public PublicController(ApplicationDbContext _db)
    {
        this._context = _db;
    }


    // add index with full databse table informaion
    public void Index(){
        List<Publisher> publisher_list = this._context.publishers.ToList();         // create publisher 
        View(publisher_list); // one way 

        return View(await _context.publishers.ToListAsync()); // secound way 

    }
}

}
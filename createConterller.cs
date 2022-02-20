namespace lastTesting.Controllers{


class PublicController : controller
{
    private readonly ApplicationDbContext _context;
    public PublicController(ApplicationDbContext _db)
    {
        this._context = _db;
    }
}

}
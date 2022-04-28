// most important part of the lessong 
// send informatnio based on the page number 


namespace Recalla.Data.HelperFunction.pagin
{
    public class PaginatedList<T>: List<T>
    {
        public int PageIndex { get; private set; }
        public int Totalpages { get; private set; }
      

        public PaginatedList(List<T> items , int count , int pageIndex , int pageSize)
        {
            this.PageIndex = pageIndex;
            this.Totalpages = (int)Math.Ceiling(items.Count / (double)pageSize);

            this.AddRange(items); // add values to list 
            this.AddRange(items); // add values to list 
        }

        public bool HasPrevPage
        {
            get{
                return this.PageIndex > 1;
            }
        }

        public bool HasNextPage {
            get {
                return this.PageIndex < this.Totalpages;
            }
        }


        public static PaginatedList<T> Create(IQueryable<T> source, int pageIndex, int pagesize) { // create paginated list based on the page number 
            var count = source.Count();
            var items = source.Skip((pageIndex - 1) * pagesize).Take(pagesize).ToList();
            return new PaginatedList<T>(items, count, pageIndex, pagesize);

        }

    }
}
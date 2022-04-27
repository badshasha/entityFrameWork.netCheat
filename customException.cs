namespace Recalla.Error
{
    public class PublisherNameException : Exception
    {
        public string PublisherName;

        public PublisherNameException()
        {

        }

        public PublisherNameException(string message):base(message)
        {

        }

        public PublisherNameException(string message, Exception inner) : base(message, inner) { 
        }

        public PublisherNameException(string message , string publisherName) : base(message)
        {
            this.PublisherName = publisherName;
        }
    }
}
// 
// service 
// 
// validation 

private bool IsValidPublisherName(string publisherName) => Regex.IsMatch(publisherName, @"^\d"); // return true if the value start from digit



// throw

  if (IsValidPublisherName(publisherInfo.PublisherName)) throw new PublisherNameException("name start from digit", publisherInfo.PublisherName); // cutrom exception



//   controller 

try {

}catch(PublisherNameException ex){
    badrequest("name error");
}
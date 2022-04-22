using Recalla.Data;
using Recalla.Model;
namespace Recalla
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();     

                if (!context.publishers.Any()) {
                    context.publishers.AddRange(
                        new Publisher()
                        {
                            PublisherName = "Emerald",
                            PublisherCountry = "England",
                            PublisherDescription = "number one england publisher"
                        },
                        new Publisher()
                        {
                            PublisherName = "person",
                            PublisherCountry = "England",
                            PublisherDescription = "first publisher in England",
                        });

                    context.SaveChanges(); 
                }
            }
        }
    }
}

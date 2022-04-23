using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recalla.Services;
using Recalla.Model.ViewModel;


namespace Recalla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly PublisherService _publisherService;
        public PublishersController(PublisherService pb)
        {
            this._publisherService = pb;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher([FromBody] PublisherViewModel publisherInformation) {
            this._publisherService.AddPublisher(publisherInformation);
            return Ok();
        }

        [HttpGet("get-publisher")]
        public IActionResult GetAllPublishers() {
            var pulisherList = this._publisherService.GetAllPublishers();
            return Ok(pulisherList);
        }

        [HttpGet("getPublisher/{id}")]
        public IActionResult GetPublisherId(int id) {
            var selectedPublisher = this._publisherService.GetPublisherFromId(id);
            return Ok(selectedPublisher);
        }


        [HttpPut("updatepublisher/{id}")]
        public IActionResult UpdatePublisher(int id, [FromBody] PublisherViewModel publisherInformationchange) {
            var chnageInformation = this._publisherService.UpdatePulishers(id, publisherInformationchange);
            return Ok(chnageInformation);
        }



        [HttpDelete("deletepublisher/{id}")]
        public IActionResult DeletePublisher(int id) {
            return Ok(this._publisherService.DeletePublisherId(id));
        }
    }
}

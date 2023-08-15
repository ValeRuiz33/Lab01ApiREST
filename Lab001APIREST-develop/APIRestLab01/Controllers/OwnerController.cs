//using Contracts;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace APIRestLab01.Controllers
//{
//    [Route("api/owner")]
//    public class OwnerController : Controller
//    {
//        private ILoggerManager _logger;
//        private IRepoService _repoService;

//        public OwnerController(ILoggerManager logger, IRepoService repoService)
//        {
//            _logger = logger;
//            _repoService = repoService;
//        }

//        [HttpGet ("getAllOwners")]
//        public ActionResult GetAllOwners()
//        {

//        }

//        [HttpGet("getOwnersById/{id}")]
//        //Name = "OwnerById")
//        public ActionResult GetOwnersById(Guid id)
//        {

//        }

//        [HttpGet("{id}/ account")]
//        public IActionResult GetOwnerWithDetails(Guid id)
//        {

//        }

//        [HttpPost]
//        public IActionResult CreateOwner([FromBody] Owner owner)
//        {
//            try
//            {
//                if (owner.IsObjectNull())
//                {
//                    return BadRequest("Owner object is null");
//                }
//                if (!ModelState.IsValid)
//                {
//                    return BadRequest("Invalid model object");
//                }
//                //additional code 
//                return CreatedAtRoute("OwnerById", new { id = owner.id },
//                    owner);
//            }
//            catch (Exception ex)
//            {
//                _logger.LogError($"Something went wrong inside the CreateOwner action: {ex}");
//                return StatusCode(500, "Internal server error");
//            }
//        }

//        [HttpPut("{id}")]
//        public IActionResult UpdateOwner (Guid id, [FromBody] Owner owner)
//        {

//        }

//        [HttpDelete ("{id}")]
//        public IActionResult DeleteOwner (Guid id)
//        {

//        }


//    }

//    //internal interface IRepoService
//    //{
//    //}
//}

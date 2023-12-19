using RestAPIError.Database;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using RestAPIError.Model;

namespace RestAPIError.Controllers
{

    [ApiController]
    [Route("NIST/[controller]")] // Rounting with Single Gets/Posts/ etc
                                 //[Route("[controller]/[action]")] // Routing with Multiple Gets/Posts/ etc 
    public class OptionController : ControllerBase
    {

        #region Variables        
        private readonly ILogger<OptionController> logger;
        private readonly Context dbContext;
        #endregion Variables

        #region ctor
        public OptionController(ILogger<OptionController> logger, Context dbContext)
        {
            this.logger = logger;
            this.dbContext = dbContext;
        }
        #endregion ctor

        #region Functions

        #region IActionResults

        [HttpGet("{id?}")]
        public IActionResult Get(int? id)
        {
            try
            {
                if (!id.HasValue)
                {
                    return Ok(dbContext.NIST_Option.ToList());
                }
                else
                {
                    var result = dbContext.NIST_Option.FirstOrDefault(x => x.id == id);
                    return result == null ? NotFound(id) : Ok(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.ToString());
            }
        }


        [HttpPut()]
        public IActionResult Put(Option option)
        {
            try
            {
                // Check if Exists
                var result = dbContext.NIST_Option.FirstOrDefault(x => x.name == option.name);
                if (result != null)
                {
                    // Return if Exists
                    return Ok(result);
                }
                // If not exist - add
                else
                {
                    dbContext.Add(option);
                    dbContext.SaveChanges();
                    var location = Url.Action(nameof(option), new { option.id }) ?? $"/{option.id}";
                    return Created(location, option);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.ToString());
            }
        }

        [HttpPost()]
        public IActionResult Post(Option option)
        {
            try
            {
                if (option.id == 0)
                {
                    throw new Exception("No Option ID given!");
                }
                dbContext.Update(option);
                dbContext.SaveChanges();
                return Ok(option);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.ToString());
            }
        }
        #endregion IActionResults

        #region Overrides
        public override string ToString()
        {
            var fields = typeof(OptionController).GetFields().ToList();
            var output = "";

            foreach (var field in fields)
            {
                output += field.Name + ": " + field.GetValue(this) + Environment.NewLine;
            }
            return output;
        }
        #endregion Overrides
        #endregion Functions

    }
}

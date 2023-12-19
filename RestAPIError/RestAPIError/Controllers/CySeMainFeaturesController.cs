
using RestAPIError.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using RestAPIError.Model;

namespace RestAPIError.Controllers
{

    [ApiController]
    [Route("NIST/[controller]")] // Rounting with Single Gets/Posts/ etc
                                 //[Route("[controller]/[action]")] // Routing with Multiple Gets/Posts/ etc 
    public class CySeMainFeaturesController : ControllerBase
    {

        #region Variables        
        private readonly ILogger<CySeMainFeaturesController> logger;
        private readonly Context dbContext;
        #endregion Variables

        #region ctor
        public CySeMainFeaturesController(ILogger<CySeMainFeaturesController> logger, Context dbContext)
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
                    return Ok(dbContext.NIST_CySeMainFeatures
                        .Include(x => x.communicatesAcrossNetworks)
                        .Include(x => x.computer)
                        .Include(x => x.localUserInterface)
                        .Include(x => x.logFilesSupported)
                        .Include(x => x.multipleIPConnections)
                        .Include(x => x.networkConnected)
                        .Include(x => x.networkLevel)
                        .Include(x => x.remoteUserInterface)
                        .Include(x => x.userAccountLockingAccordingToRequirements)
                        .Include(x => x.userAccounts)
                        .Include(x => x.wirelessCommunication)
                        .ToList());
                }
                else
                {
                    var result = dbContext.NIST_CySeMainFeatures
                        .Include(x => x.communicatesAcrossNetworks)
                        .Include(x => x.computer)
                        .Include(x => x.localUserInterface)
                        .Include(x => x.logFilesSupported)
                        .Include(x => x.multipleIPConnections)
                        .Include(x => x.networkConnected)
                        .Include(x => x.networkLevel)
                        .Include(x => x.remoteUserInterface)
                        .Include(x => x.userAccountLockingAccordingToRequirements)
                        .Include(x => x.userAccounts)
                        .Include(x => x.wirelessCommunication)
                        .FirstOrDefault(x => x.id == id);
                    return result == null ? NotFound(id) : Ok(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.ToString());
            }
        }


        [HttpPut()]
        public IActionResult Put(CySeMainFeatures cySeMainFeatures)
        {
            try
            {
                dbContext.Entry(cySeMainFeatures.communicatesAcrossNetworks).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.computer).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.localUserInterface).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.logFilesSupported).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.multipleIPConnections).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.networkConnected).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.networkLevel).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.remoteUserInterface).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.userAccountLockingAccordingToRequirements).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.userAccounts).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.wirelessCommunication).State = EntityState.Unchanged;
                dbContext.Add(cySeMainFeatures);
                dbContext.SaveChanges();
                var location = Url.Action(nameof(cySeMainFeatures), new { cySeMainFeatures.id }) ?? $"/{cySeMainFeatures.id}";
                return Created(location, cySeMainFeatures);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException.ToString());
            }
        }

        [HttpPost()]
        public IActionResult Post(CySeMainFeatures cySeMainFeatures)
        {
            try
            {
                if (cySeMainFeatures.id == 0)
                {
                    throw new Exception("No CySeMainFeatures ID given!");
                }
                dbContext.Entry(cySeMainFeatures.communicatesAcrossNetworks).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.computer).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.localUserInterface).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.logFilesSupported).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.multipleIPConnections).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.networkConnected).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.networkLevel).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.remoteUserInterface).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.userAccountLockingAccordingToRequirements).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.userAccounts).State = EntityState.Unchanged;
                dbContext.Entry(cySeMainFeatures.wirelessCommunication).State = EntityState.Unchanged;
                dbContext.Update(cySeMainFeatures);
                dbContext.SaveChanges();
                return Ok(cySeMainFeatures);
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
            var fields = typeof(CySeMainFeaturesController).GetFields().ToList();
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
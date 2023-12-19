using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace RestAPIError.Model
{
    public class CySeMainFeatures
    {
        public int id { get; set; }
        public int networkConnectedId { get; set; }
        public Option networkConnected { get; set; }
        public int networkLevelId { get; set; }
        public Option networkLevel { get; set; }
        public int computerId { get; set; }
        public Option computer { get; set; }
        public int localUserInterfaceId { get; set; }
        public Option localUserInterface { get; set; }
        public int remoteUserInterfaceId { get; set; }
        public Option remoteUserInterface { get; set; }
        public int userAccountsId { get; set; }
        public Option userAccounts { get; set; }
        public int wirelessCommunicationId { get; set; }
        public Option wirelessCommunication { get; set; }
        public int multipleIPConnectionsId { get; set; }
        public Option multipleIPConnections { get; set; }
        public int communicatesAcrossNetworksId { get; set; }
        public Option communicatesAcrossNetworks { get; set; }
        public int logFilesSupportedId { get; set; }
        public Option logFilesSupported { get; set; }
        public int userAccountLockingAccordingToRequirementsId { get; set; }
        public Option userAccountLockingAccordingToRequirements { get; set; }

    }
}

namespace SwissTransport
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
   
    using SwissTransport.Core;

    /// <summary>
    /// The Swiss Transport API tests.
    /// </summary>
    [TestClass]
    public class TransportTest
    {
        private ITransport testee;

        [TestMethod]
        public void Locations()
        {
            testee = new Transport();
            var stations = this.testee.GetStations("Sursee,");

            Assert.AreEqual(10, stations.StationList.Count);
        }

        [TestMethod]
        public void StationBoard()
        {
            testee = new Transport();
            var stationBoard = this.testee.GetStationBoard("Sursee", "8502007");

            Assert.IsNotNull(stationBoard);
        }

        [TestMethod]
        public void Connections()
        {
            testee = new Transport();
            var connections = this.testee.GetConnections("Sursee", "Luzern", "13:00", "22-12-2015","0");

            Assert.IsNotNull(connections);
        }

        [TestMethod]
        public void ConnectionsNotFailTest()
        {
            testee = new Transport();
            var connections = this.testee.GetConnections("Malters", "Luzern", "13:00", "22-12-2015", "1");
            Assert.IsNotNull(connections);
        }
    }
}

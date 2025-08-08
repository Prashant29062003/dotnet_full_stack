namespace TicketManager.Tests
{
    public class Tests
    {
        private TicketManager manager;

        [SetUp]
        public void Setup()
        {
            manager = new TicketManager();
        }

        [Test]
        public void GenerateServiceToken_AddsTokenToQueueAndList()
        {
            manager.GenerateServiceToken("Clerk");
            Assert.AreEqual(1, manager.TokenQueue.Count);
            Assert.AreEqual(1, manager.AllToken.Count);
        }

        [Test]
        public void GetNextToken_ReturnsFirstToken()
        {
            manager.GenerateServiceToken("Guard");
            var next = manager.GetNextToken();
            Assert.AreEqual("Guard", next.Position);
        }

        [Test]
        public void UpdateToken_ChangesStatusToCompleted()
        {
            manager.GenerateServiceToken("Clerk");
            var token = manager.GetNextToken();
            manager.UpdateToken(token.tokenID);

            var updated = manager.AllToken.Find(t => t.tokenID == token.tokenID);
            Assert.AreEqual("Completed", updated.Status);
        }

        [Test]
        public void SkipToken_RemovesFromQueue()
        {
            manager.GenerateServiceToken("Guard");
            var skipped = manager.SkipToken();
            Assert.AreEqual(0, manager.TokenQueue.Count);
        }
    }
}

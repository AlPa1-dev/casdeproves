using WarriorMethods;

namespace TestWarriorMethods
{
    [TestClass]
    public sealed class TestWarriorUtils
    {
        [TestMethod]
        public void TC1_VerifyStatus_MaxHP()
        {
            //Arrange
            int speed, attack;
            bool canRun;
            string status, colour;

            //act
            WarriorUtils.CalculateWarriorStatus(100,out status, out speed, out attack, out canRun, out colour);

            //assert

            Assert.AreEqual("healthy", status);
            Assert.AreEqual(100, speed);
            Assert.AreEqual(100, attack);
            Assert.IsTrue(canRun);
            Assert.AreEqual("normal",colour);
        }
    }
}

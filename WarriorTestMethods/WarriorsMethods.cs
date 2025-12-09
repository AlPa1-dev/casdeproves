using WarriorMethods;

namespace WarriorTestMethods
{
    [TestClass]
    public sealed class WarriorsMethods
    {
        [TestMethod]
        public void Health_Test_State()
        {
            //Arrange
            int playerHP = 100, playerVelocity, playerAttack;
            bool canRun = true;
            string backgroundColor;
            string playerState;
            //Act
            playerState = WarriorUtils.CheckPlayerState(playerHP, out playerVelocity, out playerAttack, out canRun, out backgroundColor);
            //Assert
            Assert.AreEqual("health", playerState);
        }
        [TestMethod]
        public void Injured_State_Test_State()
        {
            //Arrange
            int playerHP = 75, playerVelocity, playerAttack;
            bool canRun = true;
            string backgroundColor;
            string playerState;
            //Act
            playerState = WarriorUtils.CheckPlayerState(playerHP, out playerVelocity, out playerAttack, out canRun, out backgroundColor);
            //Assert
            Assert.AreEqual("injured state", playerState);
        }

        [TestMethod]
        [DataRow(100)]
        [DataRow(0)]
        [DataRow(50)]
        public void TakeDamage_Plater_Test(int damage)
        {
            int playerHP = 100;

            int playerResultHP = WarriorUtils.TakeDamage(playerHP, damage);

            Assert.AreEqual(playerHP - damage, playerResultHP);
        }
    }
}

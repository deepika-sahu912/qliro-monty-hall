using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RunSimulator;

namespace RunSimulationTests
{
    [TestClass]
    public class MontyHallProblemTests
    {
        private List<bool> _doors = new List<bool>()
            {
                true,
                false,
                false
            };
        private GenerateSimulation _runSimulation;

        [TestInitialize]
        public void Initialize()
        {
            _runSimulation = new GenerateSimulation();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void CheckIfCarChosen_ReturnsTrueIfCarIsChosen()
        {
            var actual = _runSimulation.CheckIfCarChosen();
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckIfCarChosen_ReturnsFalseIfCarIsNotChosen()
        {
            _runSimulation.ChosenDoor = 2;
            var actual = _runSimulation.CheckIfCarChosen();

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RemoveDoor_RemovesADoor_ThatIsNotTheChosenDoor()
        {
            var expected = 2;
            _runSimulation.DoorToRemove = 2;
            _runSimulation.InitalizeList();
            _runSimulation.RemoveDoor();
            var actual = _runSimulation.Doors.Count;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void SwitchDoor_GivenTrue_SwitchesDoors()
        {
            var originalDoor = 2;

            var newDoor = _runSimulation.SwitchDoor(true);

            Assert.AreNotEqual(newDoor, originalDoor);
        }

        [TestMethod]
        public void SwitchDoor_GivenFalse_DoesNotSwitchDoors()
        {
            _runSimulation.ChosenDoor = 2;

            var newDoor = _runSimulation.SwitchDoor(false);

            Assert.AreEqual(newDoor, _runSimulation.ChosenDoor);
        }

        [TestMethod]
        public void ChooseDoor_ReturnsAValueBetweenZeroAndTwo()
        {
            _runSimulation.ChooseDoor();
            bool fail = _runSimulation.ChosenDoor < 0 || _runSimulation.ChosenDoor > 2;
            Assert.IsFalse(fail);
        }

        [TestMethod]
        public void InitalizeList_ReturnsAListWithOneCar()
        {
            _runSimulation.InitalizeList();
            var expected = 1;
            var actual = 0;

            foreach (bool door in _runSimulation.Doors)
            {
                if (door == true)
                {
                    actual++;
                }
            }

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void MakeSureIndexIsNotChosenDoor_GivenChosenDoorEqualToIndexToRemove_ShouldNotReturnValueEqualToChosenDoor()
        {
            var chosenDoor = 2;
            _runSimulation.ChosenDoor = chosenDoor;
            _runSimulation.DoorToRemove = 2;

            var actual = _runSimulation.MakeSureDoorToBeRemovedIsNotChosenDoor();

            Assert.AreNotEqual(chosenDoor, actual);
        }
    }
}

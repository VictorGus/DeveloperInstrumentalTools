using System;
using FluentAssertions;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    public class DayShiftServiceTests
    {
        private DayShiftService ServiceInstance = new DayShiftService(new DayOfWeekService());

        [Test]
        public void GetShiftBusinessDay_RealLogic_Year_Before()
        {
            var initialDate = new DateTime(2020, 12, 14);
            var resultDate = new DateTime(2019, 12, 13);
            
            ServiceInstance.GetShiftBusinessDay(initialDate, -365).Should().Be(resultDate);

        }
        
        [Test]
        public void GetShiftBusinessDay_RealLogic_Year_After()
        {
            var initialDate = new DateTime(2019, 12, 13);
            var resultDate = new DateTime(2020, 12, 14);

            ServiceInstance.GetShiftBusinessDay(initialDate, 365).Should().Be(resultDate);
        }
        
        [Test]
        public void GetShiftBusinessDay_RealLogic_From_End_Of_Month()
        {
            var initialDate = new DateTime(2020, 02, 28);
            var resultDate = new DateTime(2020, 03, 2);

            ServiceInstance.GetShiftBusinessDay(initialDate, 2).Should().Be(resultDate);
        }
        
        [Test]
        public void GetShiftBusinessDay_RealLogic_From_Begin_Of_Month()
        {
            var initialDate = new DateTime(2021, 01, 01);
            var resultDate = new DateTime(2020, 12, 31);

            ServiceInstance.GetShiftBusinessDay(initialDate, -1).Should().Be(resultDate);
        }

    }
}
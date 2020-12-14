using System;
using FluentAssertions;
using Moq;
using NUnit.Framework;
using UnitTestsTarget;

namespace UnitTests
{
    public class DayOfWeekServiceTests
    {
        private DayOfWeekService ServiceInstance = new DayOfWeekService();
        
        [Test]
        public void IsWeekend_RealLogic_Weekend_True()
        {
            var date = new DateTime(2020, 12, 13);
            
            this.ServiceInstance.IsWeekend(date).Should().Be(true);
        }

        [Test]
        public void IsWeekend_RealLogin_Weekend_Different_Year_True()
        {
            var date = new DateTime(2019, 12, 14);

            this.ServiceInstance.IsWeekend(date).Should().Be(true);
        }
        
        [Test]
        public void IsWeekend_RealLogic_Weekend_False()
        {
            var date = new DateTime(2020, 12, 14);
            
            this.ServiceInstance.IsWeekend(date).Should().Be(false);
        }
        
        [Test]
        public void IsWeekend_RealLogin_Weekend_Different_Year_False()
        {
            var date = new DateTime(2019, 12, 13);

            this.ServiceInstance.IsWeekend(date).Should().Be(false);
        }
    }
}
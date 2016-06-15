using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using FullContact;
using FluentAssertions;

namespace FullContactApi.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public async Task GetPersonFromEmailAsync_Found()
        {
            var client = new FullContactClient("bd873ed0253029e9");
            var result = await client.GetPersonFromEmailAsync("robert@advancedrei.com");
            result.Should().NotBeNull();
        }

        [TestMethod]
        public async Task GetPersonFromEmailAsync_NotFound()
        {
            var client = new FullContactClient("bd873ed0253029e9");
            var result = await client.GetPersonFromEmailAsync("javieravalos@gmail.com");
            result.Should().BeNull();
        }


    }
}

using System;
using NUnit.Framework;

namespace Blueprint.Tests.Unit
{
    [TestFixture]
    public class PuppetTests
    {
        [Test]
        public void ShouldForcePuppetToSayWhateverYouWant()
        {
            var puppet = new Puppet("Toby");
            Func<string, string> rubbish = wibble => String.Format("Hello, my name is {0} and I think that C sharp rocks!!!", wibble);
            Assert.That(puppet.SayThis(rubbish), Is.EqualTo("Hello, my name is Toby and I think that C sharp rocks!!!"));
        }
    }

    public class Puppet
    {
        private readonly string name;

        public Puppet(string name)
        {
            this.name = name;
        }

        public string SayThis(Func<string, string> something)
        {
            return something(name);
        }
    }
}
using System;
using Xunit;
using ZooApp.Classes;
using ZooApp.Interfaces;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void ConcreteAnimalsIsAnAnimal()
        {
            Chimpanzees Jody = new Chimpanzees();
            
            Assert.Equal("Oh you know: Bananas, nuts, other chimps. The usual", Jody.Diet());
        }

        [Fact]
        public void ProvingInheritance()
        {
            Crocodile Dundee = new Crocodile();

            Assert.True(Dundee.Coldblooded);
        }

        [Fact]
        public void ProvingPolymorphism()
        {
            Bonobos Milly = new Bonobos();

            Assert.Equal("Whoop, whoop!", Milly.Sound());
        }

        [Fact]
        public void MethodHasBeenOverridden()
        {
            Koalas Eulie = new Koalas();

            Assert.True(Eulie.Endangered);
        }
        
        [Fact]
        public void ClassImplementsInterface()
        {
            EmperorPenguin Empoleon = new EmperorPenguin();

            Assert.True(Empoleon.CanSwim);
        }
    }
}

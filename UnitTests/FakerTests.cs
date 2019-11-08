using System.Collections.Generic;
using Faker;
using NUnit.Framework;

namespace UnitTests
{
    public class FakerTests
    {
        private readonly Faker.Faker _faker = new Faker.Faker();

        [Test]
        public void TestCreateList()
        {
            var faker = new Faker.Faker();

            var list = faker.Create<List<int>>() as List<int>;

            Assert.IsNotNull(list);
            Assert.AreNotEqual(list, default);
        }

        [Test]
        public void TestCreateClassWithInnerClass()
        {
            var myObject = _faker.Create<MyClass>() as MyClass;

            Assert.IsNotNull(myObject);
            Assert.IsNull(myObject.InnerClass.MyClass);
            Assert.AreNotEqual(myObject.PublicField, default);
            Assert.AreNotEqual(myObject.PublicProperty, default);
        }

        [Test]
        public void TestCreateInt()
        {
            var int32Value = _faker.Create<int>();
            Assert.AreNotEqual(int32Value, default);
        }

        [Test]
        public void TestCreateBoolean()
        {
            var boolValue = _faker.Create<bool>();
            Assert.AreNotEqual(boolValue, default);
        }

        [Test]
        public void TestCreateDouble()
        {
            var doubleValue = _faker.Create<double>();
            Assert.AreNotEqual(doubleValue, default);
        }

        [Test]
        public void TestCreateEnumeration()
        {
            var enumValue = _faker.Create<MyEnum>();
            Assert.AreNotEqual(enumValue, default);
        }

        [Test]
        public void TestCreateLong()
        {
            var longValue = _faker.Create<long>();
            Assert.AreNotEqual(longValue, default);
        }

        [Test]
        public void TestCreateString()
        {
            var stringValue = _faker.Create<string>();
            Assert.AreNotEqual(stringValue, default);
        }

        [Test]
        public void TestCreateObjectWithCustomStringGenerator()
        {
            var fakerConfig = new FakerConfig();
            fakerConfig.Add<Foo, string, FooStringGenerator>(foo => foo.Field);

            var faker = new Faker.Faker(fakerConfig);
            var myFoo = faker.Create<Foo>() as Foo;

            Assert.NotNull(myFoo);
            Assert.AreEqual(myFoo.Field, "TEST");
        }

        [Test]
        public void TestCreateObjectWithCustomIntGenerator()
        {
            var fakerConfig = new FakerConfig();
            fakerConfig.Add<Foo, int, FooIntGenerator>(foo => foo.FieldInt);

            var faker = new Faker.Faker(fakerConfig);
            var myFoo = faker.Create<Foo>() as Foo;

            Assert.NotNull(myFoo);
            Assert.AreEqual(myFoo.FieldInt, 123);
        }

        class A
        {
            public B B { get; set; }
            
        }
        
        class B
        {
            public A A { get; set; }
        }

        [Test]
        public void METHOD()
        {
            A a = (A) _faker.Create<A>();
            Assert.NotNull(a.B);
            Assert.Null(a.B.A);
        }

        [Test]
        public void ListTest()
        {
            var list = _faker.Create<List<int>>() as List<int>;

            Assert.IsNotNull(list);
            Assert.AreNotEqual(list, default);
        }
        

        private enum MyEnum
        {
            One,
            Two,
            Three
        }
    }

    
}
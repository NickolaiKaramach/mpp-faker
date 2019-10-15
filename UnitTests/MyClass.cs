namespace UnitTests
{
    public class MyClass
    {
        private int _privateField;

        public int PublicField;

        public MyClass(int privateProperty, int privateField, int publicField, int publicProperty)
        {
            PrivateProperty = privateProperty;
            _privateField = privateField;
            PublicField = publicField;
            PublicProperty = publicProperty;
        }

        private int PrivateProperty { get; }
        public int PublicProperty { get; }
        public MyClass InnerSameClass { get; set; }
        public MyOtherClass InnerClass { get; set; }
    }
}
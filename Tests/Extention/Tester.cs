using AutoFixture;

namespace Tests.Extention
{
    public abstract class Tester
    {
        protected readonly Fixture Fixture;

        protected Tester()
        {
            Fixture = new Fixture();
            Fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        protected T CreateOne<T>() where T : class
        {
            return Fixture.Create<T>();
        }
    }
}

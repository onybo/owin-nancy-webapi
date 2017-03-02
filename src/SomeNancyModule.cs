namespace OwinTest
{
    using Nancy;
    public class SomeNancyModule : NancyModule
    {
        public SomeNancyModule()
        {
            Get["/nancy"] = args => "Hello from Nancy";            
        }
    }
}
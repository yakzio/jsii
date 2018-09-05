using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <summary>
    /// awslabs/jsii#175
    /// Interface proxies (and builders) do not respect optional arguments in methods
    /// </summary>
    [JsiiInterface(typeof(IInterfaceWithOptionalMethodArguments), "jsii-calc.InterfaceWithOptionalMethodArguments")]
    public interface IInterfaceWithOptionalMethodArguments
    {
        [JsiiMethod("hello", null, "[{\"name\":\"arg1\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"arg2\",\"type\":{\"primitive\":\"number\",\"optional\":true}}]")]
        void Hello(string arg1, double? arg2);
    }
}
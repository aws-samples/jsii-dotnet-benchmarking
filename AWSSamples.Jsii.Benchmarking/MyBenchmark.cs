// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: MIT-0

using BenchmarkDotNet.Attributes;

namespace AWSSamples.Jsii.Benchmarking
{
    public class MyBenchmark
    {
        [Benchmark]
        public void JsiiImplementation()
        {
            // create a new instance of the Jsii `HelloWorld` class
            var helloWorld = new HelloWorld();

            // call `SayHello`
            helloWorld.SayHello("World");

            // call `Fibonacci` for numbers 0 to 25
            var i = 0;
            while (i <= 25)
            {
                helloWorld.Fibonacci(i);
                i++;
            }
        }

        [Benchmark]
        public void NativeImplementation()
        {
            // create a new instance of the Native `HelloWorld` class
            var helloWorld = new Native.HelloWorld();

            // call `SayHello`
            helloWorld.SayHello("World");

            // call `Fibonacci` for numbers 0 to 25
            var i = 0;
            while (i <= 25)
            {
                helloWorld.Fibonacci(i);
                i++;
            }
        }
    }
}
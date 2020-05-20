// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: MIT-0

using BenchmarkDotNet.Running;

namespace AWSSamples.Jsii.Benchmarking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MyBenchmark>();
        }
    }
}
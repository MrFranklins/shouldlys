﻿#if net40
using System;
using System.Threading;
using System.Threading.Tasks;
using Shouldly.Tests.TestHelpers;

namespace Shouldly.Tests.ShouldThrow
{
    public class FuncOfTaskScenario : ShouldlyShouldTestScenario
    {
        protected override void ShouldThrowAWobbly()
        {
            var task = Task.Factory.StartNew(() => { },
                CancellationToken.None, TaskCreationOptions.None,
                TaskScheduler.Default);

            task.ShouldThrow<InvalidOperationException>("Some additional context");
        }

        protected override string ChuckedAWobblyErrorMessage
        {
            get { return @"`task` should throw System.InvalidOperationException but did not
Additional Info:
Some additional context"; }
        }

        protected override void ShouldPass()
        {
            var task = Task.Factory.StartNew(() => { throw new InvalidOperationException(); },
                CancellationToken.None, TaskCreationOptions.None,
                TaskScheduler.Default);

            var ex = task.ShouldThrow<InvalidOperationException>();

            ex.ShouldNotBe(null);
            ex.ShouldBeOfType<InvalidOperationException>();
        }
    }
}
#endif
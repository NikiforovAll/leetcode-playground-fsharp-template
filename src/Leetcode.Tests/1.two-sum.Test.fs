// using NUnit.Framework;

// public class TwoSumTest
// {
//     [Test]
//     public void Test1()
//     {
//         var res = Solution.twoSum(new int[] { 2, 7, 11, 15 }, 9);
//         var expected = new int[] { 0, 1 };
//         Assert.That(res, Is.EquivalentTo(expected));
//     }
// }

namespace Tests

open Xunit
open Xunit.Abstractions
open TwoSum

type Tests(output:ITestOutputHelper) =
    let write result =
        output.WriteLine (sprintf "The actual result was %O" result)

    [<Fact>]
    let two_sum() =
        let result = Solution.twoSum [|2; 7; 11; 15|] 9
        write result


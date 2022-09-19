using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7};
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 20, 23, 19, 13, 109, 709, 5029 };   //Fact = (1, 2, 6, 24, 120, 720, 5040) then Xor = (20, 23, 19, 13, 109,709 ,5029)

            CollectionAssert.AreEqual(expected, output);
        }

    }
}

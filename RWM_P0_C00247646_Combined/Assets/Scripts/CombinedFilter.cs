using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
  
  public static int[] combinedFilter(int[] xs)
  {
      return xor21filter.xors(Fact.outputFact(xs));
  }

}

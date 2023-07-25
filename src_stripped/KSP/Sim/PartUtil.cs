// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  public static class PartUtil
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Transform FindTransformInChildrenExplicit(Transform parent, Transform find) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T GetComponentInPart<T>(Transform targetPartTransform) where T : Behaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<T> GetAllComponentsInPart<T>(Transform targetPartTransform) where T : Behaviour => throw null;
  }
}

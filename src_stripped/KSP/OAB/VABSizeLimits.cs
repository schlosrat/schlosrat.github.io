// Decompiled with JetBrains decompiler
// Type: KSP.OAB.VABSizeLimits
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class VABSizeLimits : IObjectAssemblyBuilderSizeLimits
  {
    private Bounds SizeBounds;
    private DebugShapesDraw.Cuboid DebugCuboid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VABSizeLimits(
      GameObject gameObj,
      Vector3 center,
      float height,
      float width,
      float depth)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssemblyOutOfBounds(Bounds assemblyBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableDebugSizeLimits(bool enable) => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.OcclusionCylinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public class OcclusionCylinder
  {
    public ThermalOcclusionData occlusionData;
    public Vector3 center;
    public double radius;
    public Vector2 extents;
    public Vector2 offset;
    public double cylNoseDot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Setup(ThermalOcclusionData occData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OcclusionCylinder() => throw null;
  }
}

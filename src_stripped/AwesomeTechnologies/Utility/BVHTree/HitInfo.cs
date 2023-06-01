// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.HitInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace AwesomeTechnologies.Utility.BVHTree
{
  public struct HitInfo
  {
    public float3 HitPoint;
    public float3 HitNormal;
    public float HitDistance;
    public byte TerrainSourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HitInfo(HitInfo hitInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;
  }
}

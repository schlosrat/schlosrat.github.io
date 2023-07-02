// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.HitInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

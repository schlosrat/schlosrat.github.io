// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.BVHRaycastContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using Unity.Collections;

namespace AwesomeTechnologies.MeshTerrains
{
  public struct BVHRaycastContainer
  {
    public NativeArray<HitInfo> RaycastHits;
    public NativeList<HitInfo> RaycastHitList;
    public NativeArray<BVHRay> Rays;
    public NativeArray<HitInfo> TempHi;
  }
}

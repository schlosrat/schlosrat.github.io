// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.BVHRaycastContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

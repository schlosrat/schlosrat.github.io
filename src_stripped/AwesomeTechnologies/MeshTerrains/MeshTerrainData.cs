// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.BVHTree;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.MeshTerrains
{
  [PreferBinarySerialization]
  [Serializable]
  public class MeshTerrainData : ScriptableObject
  {
    public Bounds Bounds;
    public int TriangleCount;
    public List<LBVHNODE> lNodes;
    public List<LBVHTriangle> lPrims;
    public List<byte> CoverageList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshTerrainData() => throw null;
  }
}

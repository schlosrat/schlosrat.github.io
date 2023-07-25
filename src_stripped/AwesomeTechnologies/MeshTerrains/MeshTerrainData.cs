// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

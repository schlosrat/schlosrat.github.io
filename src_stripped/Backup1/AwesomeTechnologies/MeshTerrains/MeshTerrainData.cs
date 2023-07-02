// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.MeshTerrains.MeshTerrainData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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

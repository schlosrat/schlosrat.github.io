// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.ObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility.BVHTree
{
  [Serializable]
  public struct ObjectData
  {
    public MeshRenderer Renderer;
    public Mesh Mesh;
    public int SubMesheCount;
    public List<Vector3> VerticeList;
    public List<Vector3> NormalList;
    public int[] Indices;
    public bool HasNormals;
    public BVHNode BVH;
    public bool IsValid;
    public List<BVHNode> Nodes;
    public List<BVHTriangle> Prims;
    public int TerrainSourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectData(MeshRenderer r, int terrainSourceID) => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.ObjectData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

// Decompiled with JetBrains decompiler
// Type: BVH_.BVHNodeAdaptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BVH_
{
  public class BVHNodeAdaptor
  {
    public Dictionary<BVHBox, BVHNode> mToLeafMap;

    public BVH mBVH
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBVH(BVH Bvh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 ObjectPos(BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Radius(BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MapObjectToBVHLeaf(BVHBox Obj, BVHNode Leaf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnObjChanged(BVHBox obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnMapObjects(BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckMap(BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHNode GetLeaf(BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHNodeAdaptor() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: RTG.Object2ObjectSnapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Object2ObjectSnapData
  {
    private GameObject _gameObject;
    private AABB[] _snapAreaBounds;
    private BoxFaceAreaDesc[] _snapAreaDesc;
    private List<Vector3> _vertsBuffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Initialize(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxFaceAreaDesc GetWorldSnapAreaDesc(BoxFace boxFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<OBB> GetAllWorldSnapAreaBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB GetWorldSnapAreaBounds(BoxFace boxFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<AABB> BuildVertOverlapAABBs(GameObject gameObject, Sprite sprite, RTMesh rtMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Object2ObjectSnapData() => throw null;
  }
}

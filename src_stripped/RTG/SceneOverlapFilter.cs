// Decompiled with JetBrains decompiler
// Type: RTG.SceneOverlapFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SceneOverlapFilter
  {
    private List<GameObjectType> _allowedObjectTypes;
    private List<GameObject> _ignoreObjects;
    private int _layerMask;

    public List<GameObjectType> AllowedObjectTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<GameObject> IgnoreObjects
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int LayerMask
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FilterOverlaps(List<GameObject> gameObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneOverlapFilter() => throw null;
  }
}

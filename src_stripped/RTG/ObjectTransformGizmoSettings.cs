﻿// Decompiled with JetBrains decompiler
// Type: RTG.ObjectTransformGizmoSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class ObjectTransformGizmoSettings : Settings
  {
    [SerializeField]
    private int _transformableLayers;
    private HashSet<GameObject> _nonTransformableObjects;

    public int TransformableLayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLayerTransformable(int objectLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLayerTransformable(int objectLayer, bool isTransformable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsObjectTransformable(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectTransformable(GameObject gameObject, bool isTransformable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectCollectionTransformable(
      List<GameObject> gameObjectCollection,
      bool areTransformable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmoSettings() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: RTG.ObjectCloning
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ObjectCloning
  {
    private static ObjectCloning.Config _defaultConfig;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectCloning() => throw null;

    public static ObjectCloning.Config DefaultConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GameObject> CloneHierarchies(
      List<GameObject> roots,
      ObjectCloning.Config cloneConfig)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CloneHierarchy(GameObject root, ObjectCloning.Config cloneConfig) => throw null;

    [Flags]
    public enum TransformFlags
    {
      None = 0,
      Position = 1,
      Rotation = 2,
      Scale = 4,
      All = Scale | Rotation | Position, // 0x00000007
    }

    public struct Config
    {
      public Transform Parent;
      public ObjectCloning.TransformFlags TransformFlags;
      public int Layer;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: RTG.ObjectAlign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ObjectAlign
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ObjectAlign.Result AlignToWorldAxis(
      IEnumerable<GameObject> gameObjects,
      Axis axis,
      Vector3 alignmentPlaneOrigin)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ObjectAlign.Result AlignToWorldPlane(
      IEnumerable<GameObject> gameObjects,
      Plane alignmentPlane)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AlignRootsToPlane(List<GameObject> roots, Plane alignmentPlane) => throw null;

    public enum Result
    {
      Err_NoObjects,
      Success,
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: RTG.ObjectVertexCollect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class ObjectVertexCollect
  {
    private static List<Vector3> _hierarchyVertsCollectBuffer;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CollectModelSpriteVerts(Sprite sprite, AABB collectAABB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CollectWorldSpriteVerts(
      Sprite sprite,
      Transform spriteTransform,
      OBB collectOBB)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CollectHierarchyVerts(
      GameObject root,
      BoxFace collectFace,
      float collectBoxScale,
      float collectEps)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ObjectVertexCollect() => throw null;
  }
}

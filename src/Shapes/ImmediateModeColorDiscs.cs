// Decompiled with JetBrains decompiler
// Type: Shapes.ImmediateModeColorDiscs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace Shapes
{
  [ExecuteAlways]
  public class ImmediateModeColorDiscs : ImmediateModeShapeDrawer
  {
    [Range(3f, 32f)]
    public int discCount;
    [Range(0.0f, 1f)]
    public float discRadius;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void DrawShapes(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetDiscPosition(float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImmediateModeColorDiscs() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: Shapes.ImmediateModeColorDiscs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

// Decompiled with JetBrains decompiler
// Type: DebugDrawRectTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (RectTransform))]
public class DebugDrawRectTransform : MonoBehaviour
{
  public static bool DrawDebugRects;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugDrawRectTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static DebugDrawRectTransform() => throw null;

  private enum DebugDrawMode
  {
    Box,
    Circle,
  }
}

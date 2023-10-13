// Decompiled with JetBrains decompiler
// Type: DebugDrawRectTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

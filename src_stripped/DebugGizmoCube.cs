﻿// Decompiled with JetBrains decompiler
// Type: DebugGizmoCube
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugGizmoCube : MonoBehaviour
{
  [SerializeField]
  private Color solidColor;
  [SerializeField]
  private Color wireColor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmos() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DrawCube(
    Vector3 position,
    Quaternion rotation,
    Vector3 scale,
    Color solid,
    Color wire)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugGizmoCube() => throw null;
}

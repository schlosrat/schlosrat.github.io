// Decompiled with JetBrains decompiler
// Type: DebugGizmoProjector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugGizmoProjector : MonoBehaviour
{
  [SerializeField]
  private Color solidColor;
  [SerializeField]
  private Color wireColor;
  [SerializeField]
  private Color vectorColor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDrawGizmosSelected() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void DrawProjector(
    Vector3 position,
    Quaternion rotation,
    Vector3 scale,
    Color solid,
    Color wire,
    Color vector)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugGizmoProjector() => throw null;
}

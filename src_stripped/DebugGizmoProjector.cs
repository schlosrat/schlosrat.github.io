// Decompiled with JetBrains decompiler
// Type: DebugGizmoProjector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

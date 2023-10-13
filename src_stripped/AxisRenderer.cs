// Decompiled with JetBrains decompiler
// Type: AxisRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AxisRenderer : KerbalMonoBehaviour
{
  [Tooltip("Enable or disable rendering")]
  public bool Enabled;
  [Tooltip("Size of the 3D axis rendered at this game object's transform")]
  public Vector3 Scale;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnRenderObject() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AxisRenderer() => throw null;
}

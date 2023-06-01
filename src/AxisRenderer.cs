// Decompiled with JetBrains decompiler
// Type: AxisRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

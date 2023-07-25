﻿// Decompiled with JetBrains decompiler
// Type: AxisRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingOrigin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [RequireComponent(typeof (SgtFloatingPoint))]
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Origin")]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingOrigin")]
  public class SgtFloatingOrigin : SgtLinkedBehaviour<SgtFloatingOrigin>
  {
    public static bool currentPointSet;
    public static SgtFloatingPoint currentPoint;
    [NonSerialized]
    private SgtFloatingPoint cachedPoint;

    public static SgtFloatingPoint CurrentPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Create() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtFloatingOrigin() => throw null;
  }
}

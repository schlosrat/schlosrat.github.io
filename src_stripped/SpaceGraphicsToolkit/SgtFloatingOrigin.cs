// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingOrigin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Origin")]
  [ExecuteInEditMode]
  [RequireComponent(typeof (SgtFloatingPoint))]
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

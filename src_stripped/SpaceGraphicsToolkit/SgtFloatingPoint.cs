// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Point")]
  [DisallowMultipleComponent]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingPoint")]
  public class SgtFloatingPoint : MonoBehaviour
  {
    public SgtPosition Position;
    public Action OnPositionChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PositionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPosition(SgtPosition newPosition) => throw null;

    [ContextMenu("Derive Position")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DerivePosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtFloatingPoint() => throw null;
  }
}

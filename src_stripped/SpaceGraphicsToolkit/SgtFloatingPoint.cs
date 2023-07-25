// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [DisallowMultipleComponent]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtFloatingPoint")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Floating Point")]
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

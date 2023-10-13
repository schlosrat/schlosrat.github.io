// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtFloatingPoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

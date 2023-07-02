// Decompiled with JetBrains decompiler
// Type: RTG.MoveGizmoHotkeys
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class MoveGizmoHotkeys : Settings
  {
    [SerializeField]
    private Hotkeys _enable2DMode;
    [SerializeField]
    private Hotkeys _enableSnapping;
    [SerializeField]
    private Hotkeys _enableVertexSnapping;

    public Hotkeys Enable2DMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Hotkeys EnableSnapping
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Hotkeys EnableVertexSnapping
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmoHotkeys() => throw null;
  }
}

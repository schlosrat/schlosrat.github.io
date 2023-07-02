// Decompiled with JetBrains decompiler
// Type: RTG.ScaleGizmoHotkeys
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
  public class ScaleGizmoHotkeys : Settings
  {
    [SerializeField]
    private Hotkeys _enableSnapping;
    [SerializeField]
    private Hotkeys _changeMultiAxisMode;

    public Hotkeys EnableSnapping
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Hotkeys ChangeMultiAxisMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleGizmoHotkeys() => throw null;
  }
}

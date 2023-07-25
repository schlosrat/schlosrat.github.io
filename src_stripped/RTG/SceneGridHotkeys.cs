// Decompiled with JetBrains decompiler
// Type: RTG.SceneGridHotkeys
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class SceneGridHotkeys : Settings
  {
    [SerializeField]
    private Hotkeys _gridUp;
    [SerializeField]
    private Hotkeys _gridDown;
    private Hotkeys _snapToCursorPickPoint;

    public Hotkeys GridUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Hotkeys GridDown
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Hotkeys SnapToCursorPickPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGridHotkeys() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SceneTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  [Obsolete("Deprecated. Use TimeScale and/or SceneReload instead")]
  public class SceneTools : MonoBehaviour
  {
    public bool slowTimeMode;
    public float slowTime;
    public KeyCode hotkeyReset;
    public KeyCode hotkeyTime;
    private bool m_prevSlowTimeMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneTools() => throw null;
  }
}

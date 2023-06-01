// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SceneTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

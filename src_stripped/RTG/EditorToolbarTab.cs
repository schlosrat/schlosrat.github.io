// Decompiled with JetBrains decompiler
// Type: RTG.EditorToolbarTab
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class EditorToolbarTab
  {
    [SerializeField]
    private string _tooltip;
    [SerializeField]
    private string _text;
    [NonSerialized]
    private EditorToolbar _targetToolbar;
    [NonSerialized]
    private List<Settings> _targetSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EditorToolbarTab(string text, string tooltip) => throw null;

    public string Tooltip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public EditorToolbar TargetToolbar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumTargetSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetSettings(Settings targetSettings) => throw null;
  }
}

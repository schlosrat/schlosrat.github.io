// Decompiled with JetBrains decompiler
// Type: FlagBrowser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("deprecated/not ported", true)]
public class FlagBrowser : MonoBehaviour
{
  public List<FlagBrowser.FlagEntry> Flags;
  public FlagBrowser.FlagEntry selected;
  public string uiSkinName;
  public Rect windowRect;
  private Vector2 scrollPos;
  public float width;
  public float height;
  public float iconSize;
  public float iconSpacing;
  public FlagBrowser.FlagSelectedCallback OnFlagSelected;
  public Callback OnDismiss;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FlagBrowser() => throw null;

  [Serializable]
  public class FlagEntry
  {
    public string name;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlagEntry() => throw null;
  }

  public delegate void FlagSelectedCallback(FlagBrowser.FlagEntry selected);
}

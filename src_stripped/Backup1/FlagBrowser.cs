﻿// Decompiled with JetBrains decompiler
// Type: FlagBrowser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

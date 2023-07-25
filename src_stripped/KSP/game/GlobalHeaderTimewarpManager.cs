﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.GlobalHeaderTimewarpManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class GlobalHeaderTimewarpManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    private ButtonExtended _expandTimeWarpLevelsButton;
    [SerializeField]
    private ButtonExtended _collapseTimeWarpLevelButton;
    [SerializeField]
    private CanvasGroup _collapsedTimeWarpCanvasGroup;
    [SerializeField]
    private CanvasGroup _expandedTimeWarpCanvasGroup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOpenBigTimeWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHideBigTimeWarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GlobalHeaderTimewarpManager() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.Map.Map3DTooltips
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  [Serializable]
  public class Map3DTooltips
  {
    private const string INIT_ASSERT_MESSAGE = "Map3DTooltips has not been initialized with Configure(...)!";
    [SerializeField]
    private Map3DPopup _popupTemplate;
    private bool _initialized;
    private Dictionary<GameObject, Map3DPopup> _lookupPopup;
    private List<Map3DPopup> _poolPopup;
    private GameInstance _game;
    private MapCamera _mapCamera;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(MapCamera mapCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TooltipOnObject(GameObject target, MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveObjectPopup(GameObject target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PoolTarget(Map3DPopup target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Map3DPopup AcquireTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Map3DTooltips() => throw null;
  }
}

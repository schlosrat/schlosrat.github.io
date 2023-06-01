// Decompiled with JetBrains decompiler
// Type: KSP.UI.InfoPanelMissionAccordion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Game.Missions.Definitions;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class InfoPanelMissionAccordion : KerbalMonoBehaviour
  {
    [SerializeField]
    private GameObject _content;
    [SerializeField]
    private MissionToggleExtended _missionTogglePrefab;
    private GameObjectPool<MissionToggleExtended> _missionsPool;
    private List<MissionToggleExtended> _missions;
    private List<MissionToggleExtended> _missionsExpired;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopulateAccordion(List<MissionData> missionsData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseInstances() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InfoPanelMissionAccordion() => throw null;
  }
}

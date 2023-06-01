// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.MissionToggleExtended
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Game.Missions.Definitions;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  public class MissionToggleExtended : KerbalMonoBehaviour
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private ToggleExtended _toggleExtended;
    private MissionControlAction _missionControlAction;
    [HideInInspector]
    public Property<string> Id;
    [HideInInspector]
    public Property<string> Name;
    [HideInInspector]
    public Property<bool> Active;
    [HideInInspector]
    public Property<string> Description;
    [HideInInspector]
    public Property<int> MaxStageID;
    public List<MissionStage> MissionStages;
    public List<string> MissionStagesNameItems;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeMissionToggleExtended(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionToggleExtended() => throw null;
  }
}

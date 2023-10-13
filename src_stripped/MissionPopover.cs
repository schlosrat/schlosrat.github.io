// Decompiled with JetBrains decompiler
// Type: MissionPopover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game.Missions.Definitions;
using KSP.UI;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MissionPopover : KSP2UIWindow
{
  private const string MISSION_TITLE = "MissionTitle";
  private const string MISSION_DESCRIPTION = "MissionDescription";
  private Property<string> _missionTitle;
  private Property<string> _missionDescription;
  private MissionData _missionData;
  private bool _isInitialized;
  [SerializeField]
  [Header("Debug")]
  private string debug_missionID;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitializeContextBinding() => throw null;

  [ContextMenu("DebugUpdateData")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DebugUpdateData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MissionPopover() => throw null;
}

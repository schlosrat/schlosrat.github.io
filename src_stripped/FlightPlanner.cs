// Decompiled with JetBrains decompiler
// Type: FlightPlanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FlightPlanner : MonoBehaviour
{
  public TextMeshProUGUI stageDeltaPrefab;
  public TextMeshProUGUI stageTimePrefab;
  public Transform stageDeltaContainer;
  public Transform stageTimeContainer;
  public TextMeshProUGUI escapeText;
  public TextMeshProUGUI destinationDeltaV;
  public TextMeshProUGUI destinationName;
  public Dropdown destinationDropdown;
  public bool oneWay;
  private int requiredDeltaV;
  public List<TextMeshProUGUI> stageDeltaTexts;
  public List<TextMeshProUGUI> stageTimeTexts;
  public List<FlightPlannerNode> nodes;

  private int SelectedNode
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [Obsolete("ui not ported", false)]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateStagesDV() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateStageTimes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDestination() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePositions() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateDropdown() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTest() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePrefabCount() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetOneWay(bool val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public FlightPlanner() => throw null;
}

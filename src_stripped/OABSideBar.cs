// Decompiled with JetBrains decompiler
// Type: OABSideBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.OAB;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class OABSideBar : MonoBehaviour
{
  private ObjectAssemblyBuilderEvents builderEvents;
  private ObjectAssemblyUIEvents uiEvents;
  private ObjectAssemblyBuilder builder;
  [SerializeField]
  private Toggle toggleChecklist;
  [SerializeField]
  private Toggle toggleStaging;
  [SerializeField]
  private Toggle togglePartsManager;
  [SerializeField]
  private Toggle toggleColorPicker;
  [SerializeField]
  private Toggle toggleResourceAssignment;
  [SerializeField]
  private Toggle toggleTripPlanner;
  [SerializeField]
  private Toggle toggleHistory;
  [SerializeField]
  private Toggle toggleActionGroupManager;
  [SerializeField]
  private Toggle toggleKerbalManager;
  [SerializeField]
  [Space]
  private float widgetSpeed;
  protected List<Toggle> allToggles;
  private Dictionary<Toggle, WidgetInfo> WidgetInfos;
  private Dictionary<Toggle, UnityAction<bool>> toggleDelegates;
  [SerializeField]
  private ContextBindRoot _context;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(ObjectAssemblyBuilder currentBuilder) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetCallbacks() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RemoveCallbacks() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AddToggle(Toggle t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ShowSideWidget(GameObject o, bool onscreen = true, bool immediate = true) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetChecklistWidget(GameObject o) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetStagingWidget(GameObject o) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetColorPickerWidget(GameObject o) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetHistoryWidget(GameObject o) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void HandleToggle(Toggle t) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEngineersReportWindowCloseClicked(MessageCenterMessage messageCenterMessage) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABSideBar() => throw null;
}

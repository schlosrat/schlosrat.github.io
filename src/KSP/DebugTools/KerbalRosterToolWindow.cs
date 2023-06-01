// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.KerbalRosterToolWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class KerbalRosterToolWindow : KerbalMonoBehaviour
  {
    private static readonly string PREFAB_KEY;
    private static KerbalRosterToolWindow Instance;
    [Header("Display Prefabs")]
    [SerializeField]
    private KerbalRosterKerbalRow _kerbalRowPrefab;
    [SerializeField]
    private Transform kerbalRowsParent;
    [SerializeField]
    private TMP_InputField creationName;
    [SerializeField]
    private TextMeshProUGUI activitiesLog;
    [SerializeField]
    private ScrollRect activitiesLogScrollRect;
    private KerbalRosterManager _roster;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshRoster() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRandomKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSpecificKerbal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeleteKerbal(IGGuid kerbalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearRosterList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalAddedToRoster(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalRemovingFromRoster(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnKerbalLocationChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddToLog(string verb, MessageCenterMessage message, string suffix = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddToLog(string text) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ToggleWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalRosterToolWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KerbalRosterToolWindow() => throw null;
  }
}

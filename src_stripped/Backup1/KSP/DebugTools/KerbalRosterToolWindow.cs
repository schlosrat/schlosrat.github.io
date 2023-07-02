// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.KerbalRosterToolWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
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
    [FormerlySerializedAs("kerbalRowsParent")]
    [SerializeField]
    private Transform _kerbalRowsParent;
    [SerializeField]
    [FormerlySerializedAs("creationName")]
    private TMP_InputField _customKerbalKeyInputField;
    [SerializeField]
    private TMP_InputField _kerbalSpawnAmountInputField;
    [FormerlySerializedAs("activitiesLog")]
    [SerializeField]
    private TextMeshProUGUI _activitiesLog;
    [SerializeField]
    [FormerlySerializedAs("activitiesLogScrollRect")]
    private ScrollRect _activitiesLogScrollRect;
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
    public void ResetCurrentRoster() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSpecificNumberOfKerbals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SpawnXKerbals(int amountToSpawn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddQAKerbals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetPredefinedKerbalsByOriginType(
      KerbalOriginType originType,
      out List<string> predefinedKerbalKeys)
    {
      throw null;
    }

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

// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.SimObjectItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class SimObjectItem : MonoBehaviour
  {
    [SerializeField]
    private TextMeshProUGUI _textName;
    [SerializeField]
    private TextMeshProUGUI _textPhysicsMode;
    [SerializeField]
    private TextMeshProUGUI _textParentReferenceFrame;
    [SerializeField]
    private Button _buttonToggleLoadUnload;
    [SerializeField]
    private Button _buttonSetActive;
    [SerializeField]
    private Button _buttonDestroy;
    private SimulationObjectModel _simObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncTo(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleLoadUnloadViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnloadViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveViewObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroySimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadPartOwnerViewObject(PartOwnerComponent partOwnerComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LoadCelestialBodyScaledSpaceView(
      CelestialBodyComponent celestialBodyComponent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UnloadCelestialBodyScaledSpaceView(
      CelestialBodyComponent celestialBodyComponent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadFinished(ISimulationObjectView viewObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateButtonStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsViewObjectLoaded(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimObjectItem() => throw null;
  }
}

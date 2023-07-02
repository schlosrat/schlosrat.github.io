// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.FXDebugPartItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  public class FXDebugPartItem : MonoBehaviour
  {
    [SerializeField]
    private TextMeshProUGUI _textName;
    [SerializeField]
    private Button _buttonDamage;
    [SerializeField]
    private Button _buttonSetActive;
    [SerializeField]
    private Button _buttonDestroy;
    [SerializeField]
    private Toggle _toggleSelected;
    private SimulationObjectModel _simObject;
    private PartBehavior _part;
    private FXDebugTools fXDebugTools;

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
    public void DestroyObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BreakJoint() => throw null;

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
    public void SelectedToggleChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXDebugPartItem() => throw null;
  }
}

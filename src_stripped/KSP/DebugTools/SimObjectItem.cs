// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.SimObjectItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.DebugTools
{
  internal class SimObjectItem : FlightToolsItem<SimulationObjectModel>
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
    private static string[] PHYSICS_MODE_ENUM_NAMES;
    private static string[] TRANSFORM_FRAMETYPE_ENUM_NAMES;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(SimulationObjectModel simObject) => throw null;

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
    private static bool IsViewObjectLoaded(GameInstance game, SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimObjectItem() => throw null;
  }
}

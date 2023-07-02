// Decompiled with JetBrains decompiler
// Type: KSP.Game.StagePartDataContext
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Modules;
using KSP.OAB;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class StagePartDataContext : DataContext
  {
    public AssemblyPartStageType StageType;
    public EngineType EngineType;
    public bool DidInitSymmetrySetOAB;

    public PropertyReadonly<IGGuid> Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyReadonly<string> PartName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> FuelOneActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<string> FuelOneType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> FuelOneCurAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> FuelOneTotalAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<string> FuelOneUnits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyDerived<float, StagePartDataContext> FuelOneNormalize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> FuelTwoActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<string> FuelTwoType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> FuelTwoCurAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<float> FuelTwoTotalAmount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyExternal<string> FuelTwoUnits
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PropertyDerived<float, StagePartDataContext> FuelTwoNormalize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> IsHighlighted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<bool> IsDragging
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<Sprite> StageIcon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Property<int> SymmetrySetID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Property<bool> HasBackground
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart associatedPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Data_Engine associatedEngineData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PartComponent associatedPartComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartDataContext(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagePartDataContext(PartComponent partComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEngineModeChanged(string guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetStageIconAssetAddress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitForEngineInitialized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeFuelProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetFuelProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceRequestsUpdated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFuelOneDerived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFuelTwoDerived() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFuelType(int fuelIngredientIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFuelUnits(int fuelIngredientIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFuelInternalName(int fuelIngredientIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetFuelCurAmount(int fuelIngredientIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetFuelTotalAmount(int fuelIngredientIndex) => throw null;
  }
}

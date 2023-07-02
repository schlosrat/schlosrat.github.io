// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.VegetationItemMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility;
using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.Masks
{
  [AwesomeTechnologiesScriptOrder(99)]
  public class VegetationItemMask : MonoBehaviour
  {
    public Vector3 Position;
    public VegetationType VegetationType;
    public string VegetationMaskID;
    private bool _isDirty;
    private CircleMaskArea _currentMaskArea;
    private string _vegetationItemID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVegetationItemInstanceInfo(
      VegetationItemInstanceInfo vegetationItemInstanceInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVegetationItemInstanceInfo(Vector3 position, VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVegetationItemInstanceInfo(
      Vector3 position,
      VegetationType vegetationType,
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateVegetationItemMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRemoveVegetationTypes(CircleMaskArea circleMaskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemMask() => throw null;
  }
}

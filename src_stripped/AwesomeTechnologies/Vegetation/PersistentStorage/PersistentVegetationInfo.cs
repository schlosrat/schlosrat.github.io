// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [Serializable]
  public class PersistentVegetationInfo
  {
    public string VegetationItemID;
    [SerializeField]
    public List<PersistentVegetationItem> VegetationItemList;
    [NonSerialized]
    public NativeArray<PersistentVegetationItem> NativeVegetationItemArray;
    public List<SourceCount> SourceCountList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyToNativeArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCell() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPersistentVegetationItemInstance(
      ref PersistentVegetationItem persistentVegetationItem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePersistentVegetationItemInstance(
      ref PersistentVegetationItem persistentVegetationItem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePersistentVegetationInstanceAtIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePersistentVegetationItemInstanceSourceId(
      ref PersistentVegetationItem persistentVegetationItem,
      byte newSourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IncreaseSourceCount(int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SourceCount GetSourceCount(int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DecreaseSourceCount(int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationInfo() => throw null;
  }
}

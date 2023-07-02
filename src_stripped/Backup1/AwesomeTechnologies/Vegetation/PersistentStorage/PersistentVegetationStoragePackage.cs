// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStoragePackage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [PreferBinarySerialization]
  [Serializable]
  public class PersistentVegetationStoragePackage : ScriptableObject
  {
    public List<PersistentVegetationCell> PersistentVegetationCellList;
    public List<PersistentVegetationInstanceInfo> PersistentVegetationInstanceInfoList;
    public List<byte> PersistentVegetationInstanceSourceList;
    [SerializeField]
    private bool _instanceInfoDirty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExportToFile(string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExportToStream(Stream outputStream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportFromStream(Stream inputStream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportFromFile(string filename) => throw null;

    public bool Initialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearPersistentVegetationCells() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInstanceInfoDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID, int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationCell() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstance(
      PersistentVegetationCell cell,
      string vegetationItemID,
      Vector3 position,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float distanceFalloff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstanceEx(
      PersistentVegetationCell cell,
      string vegetationItemID,
      Vector3 position,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float minimumDistance,
      float distanceFalloff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstance(
      int cellIndex,
      string vegetationItemID,
      Vector3 position,
      float minimumDistance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<PersistentVegetationInstanceInfo> GetPersistentVegetationInstanceInfoList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePersistentVegetationInstanceInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PersistentVegetationInstanceInfo GetPersistentVegetationInstanceInfo(
      string vegetationItemID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationStoragePackage() => throw null;
  }
}

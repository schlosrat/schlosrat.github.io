// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.PersistentStorage.PersistentVegetationStorage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.PersistentStorage
{
  [HelpURL("http://www.awesometech.no/index.php/persistent-vegetation-storage")]
  public class PersistentVegetationStorage : MonoBehaviour
  {
    public PersistentVegetationStoragePackage PersistentVegetationStoragePackage;
    public VegetationSystemPro VegetationSystemPro;
    [NonSerialized]
    public int CurrentTabIndex;
    public int SelectedBrushIndex;
    public float BrushSize;
    public float SampleDistance;
    public bool RandomizePosition;
    public bool PaintOnColliders;
    public bool UseSteepnessRules;
    public bool DisablePersistentStorage;
    public LayerMask GroundLayerMask;
    public int SelectedVegetationPackageIndex;
    public string SelectedEditVegetationID;
    public string SelectedPaintVegetationID;
    public string SelectedBakeVegetationID;
    public string SelectedStorageVegetationID;
    public string SelectedPrecisionPaintingVegetationID;
    public PrecisionPaintingMode PrecisionPaintingMode;
    public List<IVegetationImporter> VegetationImporterList;
    public int SelectedImporterIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasValidPersistentStorage(int cellCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPersistentVegetationStoragePackage(
      PersistentVegetationStoragePackage persistentVegetationStoragePackage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializePersistentStorage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializePersistentStorage(int cellCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstance(
      string vegetationItemID,
      Vector3 worldPosition,
      Vector3 scale,
      Quaternion rotation,
      bool applyMeshRotation,
      byte vegetationSourceID,
      float distanceFalloff,
      bool clearCellCache = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PersistentVegetationCell AddPersistentVegetationCell(int xIndex, int yIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationItemInstanceEx(
      string vegetationItemID,
      Vector3 worldPosition,
      Vector3 scale,
      Quaternion rotation,
      byte vegetationSourceID,
      float minimumDistance,
      float distanceFalloff,
      bool clearCellCache = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstance(
      string vegetationItemID,
      Vector3 worldPosition,
      float minimumDistance,
      bool clearCellCache = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RepositionCellItems(int cellIndex, string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetPersistentVegetationCellCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationCell GetPersistentVegetationCell(int xIndex, int yIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID, int vegetationSourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveVegetationItemInstances(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BakeVegetationItem(string vegetationItemID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentVegetationStorage() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.OAB.SymmetrySet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class SymmetrySet : IDisposable
  {
    private static int _nextID;
    public int ID;
    private SymmetrySetData _data;
    private readonly ISymmetrySetPositioner _positioner;
    private readonly SymmetrySetVisualizer _visualizer;
    private ObjectAssemblyPartTracker _partTracker;
    private OABSessionInformation _sessionInfo;
    private List<IObjectAssemblyPart> _parts;
    private List<PositionData> _lastPositions;
    private Dictionary<IObjectAssemblyPart, PositionData> _mirrorPositions;
    private IObjectAssemblyPart _anchorReference;
    private bool _isSynching;

    public SymmetrySetVisualizer Visualizer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SymmetrySetData Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IReadOnlyList<IObjectAssemblyPart> Parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ISymmetrySetPositioner Positioner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IObjectAssemblyPart Anchor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Create(
      ObjectAssemblyPartTracker partTracker,
      OABSessionInformation sessionInfo,
      IObjectAssemblyPart anchor,
      BuilderSymmetryMode symmetryMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Create(
      ObjectAssemblyPartTracker partTracker,
      OABSessionInformation sessionInfo,
      SymmetrySetData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymmetrySet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymmetrySet(
      ObjectAssemblyPartTracker partTracker,
      OABSessionInformation sessionInfo,
      IObjectAssemblyPart anchor,
      BuilderSymmetryMode symmetryMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymmetrySet(
      ObjectAssemblyPartTracker partTracker,
      OABSessionInformation sessionInfo,
      IObjectAssemblyPart anchor,
      ISymmetrySetPositioner positioner)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private SymmetrySet(
      ObjectAssemblyPartTracker partTracker,
      OABSessionInformation sessionInfo,
      SymmetrySetData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DriveFromAnchorCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ChangeAnchor(IObjectAssemblyPart anchor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSet(
      IObjectAssemblyPart temporaryParent,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPart(
      IObjectAssemblyPart temporaryParent,
      IObjectAssemblyPart anchor,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncPartsToAnchor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncData(IObjectAssemblyPart syncSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasValidAttachNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlaceSet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IObjectAssemblyPart GetHighestPartWithSymmetry(
      IObjectAssemblyPart origin,
      SymmetryType symmetryType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IObjectAssemblyPart GetHighestPartWithSymmetryMode(
      IObjectAssemblyPart origin,
      BuilderSymmetryMode symmetryMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Quaternion ReflectRotation(Quaternion rotation, Vector3 normal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddValueToKeys(
      Dictionary<IGGuid, List<IGGuid>> newGUIDLookups,
      Dictionary<IGGuid, IGGuid> guidMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddValueToKey(Dictionary<IGGuid, List<IGGuid>> table, IGGuid key, IGGuid value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcedurallyDriveFromAnchor(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearProdecuralDriver(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGeneratePlacement(
      PositionData positionData,
      IObjectAssemblyPart anchor,
      out Dictionary<IGGuid, IGGuid> guidMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecursivelyContortChildren(
      IObjectAssemblyPart anchor,
      IReadOnlyDictionary<IGGuid, IGGuid> guidMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PositionData GetPositionData(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPart OABPartByGUID(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ISymmetrySetPositioner CreatePositionerFromMode(BuilderSymmetryMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool TryInferPositionerFromData(
      SymmetrySetData data,
      out ISymmetrySetPositioner positioner)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SymmetrySetData ExtractData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SymmetrySet() => throw null;
  }
}

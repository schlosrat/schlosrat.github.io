// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyPartTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyPartTracker : IDisposable
  {
    protected ObjectAssemblyBuilderEvents events;
    protected ObjectAssemblyCameraManager cameraManager;
    protected ObjectAssemblyInputHandler input;
    protected OABSessionInformation stats;
    protected ObjectAssemblyBuilderFileIO fileIO;
    protected float raycastDistance;
    protected ObjectAssemblyAssets builderPrefabs;
    private List<IObjectAssemblyAvailablePart> _allKnownParts;
    private List<IObjectAssemblyAvailablePart> _partsAvailableInVariant;
    private List<IObjectAssemblyPart> _partsMasterList;
    public Dictionary<IObjectAssemblyPart, List<System.Type>> partModuleTypeCache;
    public Dictionary<System.Type, List<IObjectAssemblyPart>> moduleTypePartCache;
    public List<IObjectAssembly> partAssemblies;
    private IObjectAssemblyPart _partBeingManipulated;
    private IObjectAssemblyPart _partGrabbed;
    private AssemblyIconMode assemblyIconMode;
    private AssemblyIconMode anchorIconMode;
    private List<SymmetrySet> _symmetrySets;
    private Coroutine _coroutineLoadingParts;
    private bool _isLoadingParts;
    private WaitForSeconds _delayPartLoadSeconds;
    private List<IObjectAssemblyAvailablePart> partObjectsToLoad;
    private List<IObjectAssemblyAvailablePart> partObjectsLoading;
    private List<IObjectAssemblyAvailablePart> partObjectsLoaded;
    public IObjectAssemblyPart PotentialParentPart;
    public List<float> AssemblySizeTypeDiameters;

    public IReadOnlyList<IObjectAssemblyPart> PartsMasterList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsActiveManipulationWidget
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart PartBeingManipulated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart partGrabbed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IReadOnlyList<SymmetrySet> SymmetrySets
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int PartObjectToLoadCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int PartObjectLoadingCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyPartTracker(
      ObjectAssemblyBuilderEvents eventSystemToUse,
      ObjectAssemblyInputHandler inputToUse,
      ObjectAssemblyCameraManager cameraToUse,
      OABSessionInformation statsToUse,
      ObjectAssemblyBuilderFileIO fileIOToUse,
      ObjectAssemblyAssets prefabs,
      IReadOnlyCollection<PartCore> allPossibleParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssemblyDeleted(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(
      IObjectAssembly oldObjectAssembly,
      IObjectAssembly newObjectAssembly)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInternalRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPartToMasterList(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemovePartFromMasterList(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemovePartFromMasterList(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrioritizePart(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadPartDirectly(IObjectAssemblyAvailablePart target, Action loaded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineLoadPartsAtInterval() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadPartsAtInterval() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetPartWithGUID(IGGuid guid, out IObjectAssemblyPart foundPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool DoesGameObjectHaveCorePartData(GameObject targetGOToTest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPartPrefabLoaded(IObjectAssemblyAvailablePart obj, GameObject prefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearCachedOabPartModuleTypes(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecacheOABPartModuleTypes(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<IObjectAssemblyPart> GetPartsWithModule<TModule>() where TModule : IPartModule => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isAllowed(IObjectAssemblyAvailablePart ap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Initialize(IReadOnlyCollection<PartCore> allPossibleParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyAssets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRequestPartLoad(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPrePartCreate(IObjectAssemblyAvailablePart part) => throw null;

    public KeyValuePair<IObjectAssemblyPart, Vector3>[] PartsUnderCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KeyValuePair<IObjectAssemblyPart, Vector3> ClosestPartToCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly CreatePartAtCursor(
      IObjectAssemblyAvailablePart partToCreate,
      ref IObjectAssemblyPart part)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly CreatePartFreeFloating(
      IObjectAssemblyAvailablePart partToCreate,
      Vector3? partPosition,
      ref IObjectAssemblyPart part)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IObjectAssemblyAvailablePart Locate(
      string partName,
      List<IObjectAssemblyAvailablePart> permittedParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAll() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly PartSetParent(
      IObjectAssemblyPart parent,
      IObjectAssemblyPart child,
      IObjectAssemblyPartNode parentNode,
      IObjectAssemblyPartNode childNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly PartRemoveParent(IObjectAssemblyPart child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeletePart(IObjectAssemblyPart partToDelete, bool omitPartDeletedMessages = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalDelete(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GrabPart(IObjectAssemblyPart partToGrab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DropPart(IObjectAssemblyPart partToDrop, bool isLastPartPlaced = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPart ClonePart(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPart ClonePart(
      IObjectAssemblyPart target,
      List<IObjectAssemblyAvailablePart> permittedParts,
      out Dictionary<IGGuid, IGGuid> oldToNew)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessClonedCompoundPartsRecursive(
      IObjectAssemblyPart clone,
      Dictionary<IGGuid, IGGuid> oldToNew,
      bool canDelete = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StackParts(IObjectAssemblyPartNode parent, IObjectAssemblyPartNode child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SurfaceAttachParts(IObjectAssemblyPart parent, IObjectAssemblyPart child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPartNode TryGetSurfaceAttachNode(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DetachParts(IObjectAssemblyPart parent, IObjectAssemblyPart child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssembly MakeAssembly(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMainAssembly(IObjectAssembly assembly = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFromAssembly(IObjectAssemblyPart part, IObjectAssemblyPart formerParent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpkeepAssembly(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssemblyPart ManuallyCreatePart(
      IObjectAssemblyAvailablePart partToCreate,
      List<SerializedPartModule> existingModuleData = null,
      bool spawnInHand = true,
      bool isInAssembly = true,
      IObjectAssemblyPart referenceCurrent = null,
      IGGuid? guid = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int PartAssemblyCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DumpAssemblyState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPartNode GetNodeByPart(
      IObjectAssemblyPart toCheck,
      IObjectAssemblyPart target)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPartNode GetNodeByTag(IObjectAssemblyPart reference, string tag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HookChildrenRecursive(
      IObjectAssemblyPart newParent,
      IObjectAssemblyPart referenceCurrent,
      List<IObjectAssemblyAvailablePart> permittedParts,
      Dictionary<IGGuid, IGGuid> oldToNew)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AreSymmetrySiblings(IObjectAssemblyPart partA, IObjectAssemblyPart partB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyIconsPosition(Camera curCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyIconsState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyIcon(IObjectAssemblyPart partGrabbed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAssemblyDeltaV(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetBoundsPart(IObjectAssemblyPart part, ref Bounds totalbounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAssemblyIconMode(AssemblyIconMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyIconMode GetAssemblyIconMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAnchorIconMode(AssemblyIconMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyIconMode GetAnchorIconMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<IObjectAssemblyPartStageInfo> GetStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOmitStagingMessages(bool omitStagingMsgs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterSymmetrySet(SymmetrySet symmetrySet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterSymmetrySet(SymmetrySet symmetrySet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetOABPart(string partName, out IObjectAssemblyPart oabPart) => throw null;

    public struct SymmetryColorInfo
    {
      public Color baseColor;
      public Color detailColor;
    }
  }
}

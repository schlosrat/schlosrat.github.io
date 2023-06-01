// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderFileIO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.IO;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.State;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderFileIO
  {
    private ObjectAssemblyBuilderEvents events;
    private OABSessionInformation stats;
    private ObjectAssemblyBuilder builder;
    private ObjectAssemblyUIEvents _eventsUI;
    private OABHistoricalSnapshot _cachedSnapshot;
    private OABThumbnailCreator _vesselThumbnailCreator;
    public OABGlobalConfig OABGlobalConfig;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static string Clipboard
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderFileIO(ObjectAssemblyBuilder builder, OABSessionInformation stats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABGlobalConfig ConstructGlobalConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveOABGlobalConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadOABGlobalConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABHistoricalSnapshot GenerateSnapshot(
      ObjectAssemblyPartTracker partTracker,
      OABActionType type = OABActionType.Other)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OABHistoricalSnapshot GenerateSnapshot(
      SerializedAssembly assembly,
      Vector3 bounds,
      float mass)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleLoadWarningModal(string warningMessageKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyCachedSnapshot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySnapshot(
      ObjectAssemblyPartTracker partTracker,
      OABHistoricalSnapshot snapshot,
      bool sendMessages = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupOABOrientation(OABOrientation orientation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveWorkspaceToFile(
      ObjectAssemblyPartTracker partTracker,
      string filename,
      string workspaceName,
      string vehicleName,
      string description,
      bool isAutosave,
      IOProvider.DataLocation dataLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteWorkspaceSave(string name, IOProvider.DataLocation dataLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<string> GetOABWorkspaceFileNames(IOProvider.DataLocation dataLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PeekOABWorkspaceFromFile(
      string vesselFileName,
      IOProvider.DataLocation dataLocation,
      out OABSavedWorkspaceMetaInfo workspaceMetaInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool PeekOABWorkspaceFromFile(
      string file,
      out OABSavedWorkspaceMetaInfo workspaceMetaInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool CheckForWarningsOnSavedEntry(
      OABHistoricalSnapshot snapshot,
      ref bool hasEnoughResources,
      ref bool isWithinSizeLimits,
      ref string warningKey)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadWorkspaceFromFile(
      ObjectAssemblyPartTracker partTracker,
      OABLoadDialogExistingSave selectedEntry)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyOABConfig ConstructConfig(IObjectAssemblyPart anchor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadSerializedAssembly(SerializedAssembly serializedAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string AssemblyToString(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedAssembly AssemblyToSerializable(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly AssemblyFromString(
      string toLoad,
      List<IObjectAssemblyAvailablePart> permittedParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly AssemblyFromSerializable(
      SerializedAssembly sa,
      List<IObjectAssemblyAvailablePart> permittedParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyDefinition CollectAssemblyInfo(ShipInformation info, IObjectAssemblyPart anchor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingState CollectStagingInfo(IObjectAssembly objectAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int SortPartGroups(IObjectAssemblyPart x, IObjectAssemblyPart y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CollectParts(IObjectAssemblyPart current, List<SerializedPart> outDefinitions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IObjectAssembly AssemblyFromDefinitions(
      List<SerializedPart> partContainers,
      ObjectAssemblyPartTracker activePartTracker,
      AssemblyOABConfig config,
      List<IObjectAssemblyAvailablePart> permittedParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static AttachNodeState CreateStackNodeAttachState(
      IObjectAssemblyPartNode node,
      IObjectAssemblyPart otherPart,
      IObjectAssemblyPartNode otherNode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAttachmentsForParts(
      IObjectAssemblyPart part,
      ObjectAssemblyPartTracker partTracker,
      ref HashSet<IObjectAssemblyPart> doneParts,
      IObjectAssemblyPart parent = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSurfacesForParts(
      Dictionary<IGGuid, KeyValuePair<SerializedPart, IObjectAssemblyPart>> lookup,
      ObjectAssemblyPartTracker partTracker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IObjectAssemblyPartNode TryGetSurfaceAttachNode(IObjectAssemblyPart part) => throw null;
  }
}

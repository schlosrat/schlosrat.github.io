// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderEvents
  {
    [LogIgnore]
    public Action<List<IObjectAssemblyPartStageInfo>> OnStageInfoUpdate;
    [LogIgnore]
    public Action OnPreUpdate;
    [LogIgnore]
    public Action OnUpdate;
    [LogIgnore]
    public Action OnPostUpdate;
    [LogIgnore]
    public Action OnPreLateUpdate;
    [LogIgnore]
    public Action OnLateUpdate;
    [LogIgnore]
    public Action OnPostLateUpdate;
    public Action<OABActionType> OnDirtyingAction;
    public Action OnStartUp;
    public Action OnShutdown;
    public Action<OABVariant, OABEnvironmentType, OABConstructionType> OnConfigured;
    public Action<SerializedLocation> PreOnLaunchAssemblyAtLocation;
    public Action PreOnSaveAssembly;
    public Action PostOnSaveAssembly;
    public Action PreOnSaveSubAssembly;
    public Action PostOnSaveSubAssembly;
    public Action PreOnLoadAssembly;
    public Action PostOnLoadAssembly;
    public Action PreOnLoadSubAssembly;
    public Action PostOnLoadSubAssembly;
    public Action<IObjectAssembly> AssemblyDeleted;
    public Action<IObjectAssemblyTool> PreOnToolSet;
    public Action<IObjectAssemblyTool> PostOnToolSet;
    public Action<IObjectAssemblyAvailablePart> RequestPartLoad;
    public Action<IObjectAssemblyAvailablePart> PreOnPartCreated;
    public Action<IObjectAssemblyPart> PostOnPartCreated;
    public Action<IObjectAssemblyAvailablePart> PostOnPartPrefabLoaded;
    public Action<IObjectAssemblyPart> PostOnPartFinalized;
    public Action PreOnSymmetrySetCreated;
    public Action<SymmetrySet> PostOnSymmetrySetCreated;
    public Action<SymmetrySet> PreOnSymmetrySetDeleted;
    public Action PostOnSymmetrySetDeleted;
    public Action<IObjectAssemblyPart> FlipPartHorizontally;
    public Action<IObjectAssemblyPart> PreOnPartDeleted;
    public Action<IObjectAssemblyPart> PreOnPartGrabbed;
    public Action<IObjectAssemblyPart> PostOnPartGrabbed;
    public Action<IObjectAssemblyPart> PreOnPartDropped;
    public Action<IObjectAssemblyPart> PostOnPartDropped;
    public Action<IObjectAssemblyPart> PostOnPartPlacedConnected;
    public Action<IObjectAssemblyPart> PostOnPartPlacedNonConnected;
    public Action<IObjectAssemblyPart> PreOnPartSelected;
    public Action<IObjectAssemblyPart> PostOnPartSelected;
    public Action<IObjectAssemblyPart> OnPartDisconnected;
    public Action<IObjectAssemblyPart, Vector3> OnPartHighlighted;
    public Action OnPartSnapped;
    public Action<List<IObjectAssemblyResource>> PreOnResourcesUpdate;
    public Action<List<IObjectAssemblyResource>> PostOnResourcesUpdate;
    public Action<int> OnNumberPress;
    public Action OnCopyAssembly;
    public Action OnPasteAssembly;
    public Action<bool> OnSearch;
    public Action<IObjectAssemblyPart> OnDuplicateAssembly;
    public Action<bool> OnToggleAnglesnap;
    public Action OnSymmetryModeChanged;
    public Action OnManipulationModeChanged;
    public Action OnPrimaryActionUp;
    public Action OnPrimaryActionClick;
    public Action OnPrimaryActionDoubleClick;
    public Action OnSecondaryActionDown;
    public Action OnGamepadRightStickPerformed;
    public Action OnSecondaryActionUp;
    public Action OnSecondaryActionClick;
    public Action OnSecondaryActionDoubleClick;
    public Action OnTertiaryActionDown;
    public Action OnTertiaryActionUp;
    public Action OnTertiaryActionClick;
    public Action OnTertiaryActionDoubleClick;
    public Action OnCameraRotate;
    public Action OnCameraRotateReleased;
    public Action OnFavoritePart;
    public Action OnInputCancel;
    public Action PreOnCheckDesignConcerns;
    public Action PostOnCheckDesignConcerns;
    public Action PreOnUpdateAssemblyStats;
    public Action PostOnUpdateAssemblyStats;
    public Action PostOnResourceCostUpdate;
    [LogIgnore]
    public Action OnInternalRefresh;
    public Action<bool> OnTargetLockToggle;
    public Action OnRequestToggleTargetLock;
    public Action<IObjectAssemblyPart> OnSelectedPartChanged;
    public Action OnToggleConsoleToolbox;
    public Action<Camera> OnCameraSet;
    public Action OnCameraReset;
    public Action<Vector3> OnToolRotatedPart;
    public Action<IObjectAssembly> PostOnAssemblyCreatedFromUI;
    public Action<IObjectAssembly> OnMainAssemblySet;
    public Action<IObjectAssembly, IObjectAssembly> OnMainAssemblyChanged;
    public Action<IObjectAssembly> OnMainAssemblyReset;
    public Action<Vector3> OnSnapRotation;
    public Action OnResetRotation;
    public Action OnRequestNextSymmetryMode;
    public Action OnRequestPreviousSymmetryMode;
    public Action OnRequestToggleSnappingMode;
    public Action<Module_ProceduralPart> ProceduralPartMeshUpdated;
    public Action<Module_ProceduralPart, bool> ProceduralPartIsEditableChanged;
    public Action<Module_ProceduralPart> ProceduralPartEditSelectionChanged;
    public Action<Module_Fairing> ProceduralFairingMeshUpdated;
    public Action<Module_Fairing, bool> ProceduralFairingIsEditableChanged;
    public Action<Module_Fairing> ProceduralFairingEditSelectionChanged;
    public Action<bool> ProceduralFairingRingChanged;
    public Action<bool> ProceduralFairingSectionChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderEvents() => throw null;
  }
}

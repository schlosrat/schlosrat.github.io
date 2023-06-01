// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ProceduralPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.OAB;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  public class Module_ProceduralPart : PartBehaviourModule
  {
    private const string LOG_PREFIX = "Module_ProceduralPart";
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_ProceduralPart dataProceduralPart;
    private ProcedurallyEditablePart _proceduralMeshBaker;
    private readonly Dictionary<ObjectAssemblyPartNode, Transform> _oabAttachNodesToUpdate;
    private bool _lastIsSymmetryMirrored;
    private bool _lastIsEditable;
    private CorePartData _corePartData;
    private Module_Color _moduleColor;
    private Module_Drag _moduleDrag;
    private List<Transform> _wingtipVorticesTransforms;
    private List<Transform> _controlSurfaceVorticesTransforms;
    [SerializeField]
    protected string searchableWingtipVorticesVFXTransformName;
    [SerializeField]
    protected string searchableControlSurfaceVorticesVFXTransformName;
    public Module_ProceduralPart.ProceduralMeshDelegate OnBakedMeshChanged;
    public Module_ProceduralPart.ProceduralMeshDelegate OnBakedMeshFinalized;
    public Module_ProceduralPart.ProceduralMeshDelegate OnBakedMeshDataChanged;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProcedurallyEditablePart ProceduralMeshBaker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEditable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<Transform> WingtipVorticesTransforms
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<Transform> ControlSurfaceVorticesTransforms
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSymmetryMirrored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void UpdateVorticesTransformLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakedMeshChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakedMeshFinalized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMeshLayers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRenderers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleOABAttachNodeToggle(
      SkinMeshToStaticGenerator.AttachNodeData nodeData,
      bool shouldAttachNodeBeOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDynamicOABAttachNodePositions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReadValuesFromMeshBaker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetSavedData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WriteValuesToMeshBaker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleOABEventSend_OnEditableChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DoDeepCopy<TKey, TVal>(
      IReadOnlyDictionary<TKey, TVal> from,
      IDictionary<TKey, TVal> to)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMeshValues(GameObject gameObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSymmetryMirrored(bool isSymmetryMirrored) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ProceduralPart() => throw null;

    public delegate void ProceduralMeshDelegate();
  }
}

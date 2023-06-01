// Decompiled with JetBrains decompiler
// Type: KSP.Research.ResearchDevelopmentTechTreeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Research
{
  public class ResearchDevelopmentTechTreeController : KerbalMonoBehaviour
  {
    public const string RD_TECH_TREE_PREFAB = "ResearchDevelopmentTechTree.prefab";
    public TechnologyNode TechNodePrefab;
    public ContextBindRoot BindRoot;
    [SerializeField]
    private RectTransform _pinMapBoundries;
    [SerializeField]
    private GameObject _panel1;
    private bool _isLoaded;
    private Camera _rdCamera;
    private TechnologyContextData _data;
    private TechnologyNode _firstNode;

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 PinMapBoundries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTechTree(string lastSelectedNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TechnologyNode GetTechnologyByID(TechnologyContextData techData, string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNodeOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTechNodesSelection(string selectedNodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTechNodesSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetRDCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RDCameraEnable(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchDevelopmentTechTreeController() => throw null;
  }
}

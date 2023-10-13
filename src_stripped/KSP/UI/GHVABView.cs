// Decompiled with JetBrains decompiler
// Type: KSP.UI.GHVABView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class GHVABView : KerbalMonoBehaviour, IGHContextualMenu
  {
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [SerializeField]
    [Space]
    private OABSaveDialog _saveDialog;
    [SerializeField]
    private OABLoadDialog _loadDialog;
    [SerializeField]
    [Tooltip("Set this for handling is text focused, for opening console keyboard")]
    private TMP_InputField _nameInputField;
    private ObjectAssemblyBuilder _builder;
    private DataContext _dataContext;
    private Property<string> _currentWorkspaceVehicleDisplayName;
    private Property<bool> _isActiveAssemblySet;

    public GameState ID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsBackgroundVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsubscribeMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void New() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWarningModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DismissWarning() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Save() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Load() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABWorkspaceLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewOABWorkspace(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowContextualMenu(bool show) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetCurrentWorkspaceVehicleName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckIfActiveAssemblyIsSet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsOABStatsValid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCurrentWorkspaceNameSet(string newWorkspaceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBuilderWorkspaceVehicleNameChanged(string newWorkspaceVehicleName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GHVABView() => throw null;
  }
}

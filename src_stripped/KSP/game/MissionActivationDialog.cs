// Decompiled with JetBrains decompiler
// Type: KSP.Game.MissionActivationDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class MissionActivationDialog : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform _missionsParent;
    [SerializeField]
    private MissionDialogEntry _fileEntryPrefab;
    [SerializeField]
    private ButtonExtended _cancelButton;
    [Header("UI Prefabs")]
    private GameObjectPool<MissionDialogEntry> _MissionEntryPrefabPool;
    private List<GameObject> fileEntryUIControls;
    private bool _isInitialized;
    private bool _isDirty;
    private RectTransform _rectTransformParent;
    private RectTransform _rectTransform;
    private const string LOG_FILTER = "[MissionActivationDialog] - ";

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MissionActivated(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MissionReset(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DismissDialog() => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddMissionEntry(string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool NeedsRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RemoveUI(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LogError(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionActivationDialog() => throw null;
  }
}

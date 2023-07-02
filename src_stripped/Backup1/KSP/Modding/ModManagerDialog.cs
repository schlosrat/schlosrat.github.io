// Decompiled with JetBrains decompiler
// Type: KSP.Modding.ModManagerDialog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Modding
{
  public class ModManagerDialog : KerbalMonoBehaviour
  {
    [SerializeField]
    private RectTransform _saveGamesParent;
    [SerializeField]
    private ModManagerDialogModEntry _modEntryPrefab;
    [SerializeField]
    private ButtonExtended _closeWindowButton;
    [SerializeField]
    private TextMeshProUGUI _modDescription;
    [Header("UI Prefabs")]
    private GameObjectPool<ModManagerDialogModEntry> _ModPrefabPool;
    private List<GameObject> fileEntryUIControls;
    private bool _isInitialized;
    private bool _isDirty;
    public bool IsLoading;
    private const string LOG_FILTER = "[ModManagerDialog] - ";

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

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
    private void AddModEntry(KSP2Mod mod) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool NeedsRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDescriptionText(string desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RemoveUI(GameObject go) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LogError(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModManagerDialog() => throw null;
  }
}

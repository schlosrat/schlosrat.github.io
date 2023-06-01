// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2MessageBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Input;
using KSP.UserInterface;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace KSP.UI
{
  [PrefabName("KSP2MessageBox.prefab")]
  public class KSP2MessageBox : KSP2UIWindow
  {
    [Space(5f)]
    [Header("Message Box")]
    [SerializeField]
    private GameObject modalPanel;
    [SerializeField]
    private Image messageBoxIcon;
    [SerializeField]
    private TextMeshProUGUI messageBoxTitle;
    [SerializeField]
    private TextMeshProUGUI messageBoxText;
    [SerializeField]
    private Transform buttonArea;
    [SerializeField]
    private GameObject buttonPrefab;
    [SerializeField]
    private GameObject header;
    [SerializeField]
    private GameObject headerCloseButton;
    [SerializeField]
    private GameObject dragComponent;
    private Image _modalBackground;
    private List<InputAction> _globalActionsToReDisable;
    private List<InputLockDefinition> _inputLocksToReEnable;
    private bool _reEnableCameraInput;
    private KSP2UIWindowDrag _windowDrag;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(
      string title,
      string text,
      Image icon,
      List<ButtonData> buttonData,
      bool modal = true,
      bool cancelButton = false,
      string cancelButtonText = "",
      bool showCloseIcon = true,
      bool draggableWindow = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClose(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateButton(ButtonData buttonData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LockInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnlockInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2MessageBox() => throw null;
  }
}

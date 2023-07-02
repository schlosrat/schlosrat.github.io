// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ContextPanel : KerbalMonoBehaviour
  {
    [SerializeField]
    private CanvasGroup _parentCanvasGroup;
    [SerializeField]
    private RectTransform _actionButtonContainer;
    [SerializeField]
    private Button _actionButton;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private RectTransform _panelTransform;
    private GameObject _currentTarget;
    private List<Button> _currentButtons;
    private bool _isVisible;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Hide() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTarget(GameObject target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextPanel() => throw null;
  }
}

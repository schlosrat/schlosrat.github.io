// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

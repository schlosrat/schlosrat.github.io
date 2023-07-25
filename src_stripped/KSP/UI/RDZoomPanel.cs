// Decompiled with JetBrains decompiler
// Type: KSP.UI.RDZoomPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Input;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class RDZoomPanel : KerbalMonoBehaviour
  {
    public ContextBindRoot BindRoot;
    [SerializeField]
    private RDPinMapTool _pinMapTool;
    [SerializeField]
    private TMP_Text _currentZoomLevelText;
    [Header("Zoom Settings in %")]
    [SerializeField]
    private int _zoomIncrement;
    [SerializeField]
    private int _maxZoom;
    [SerializeField]
    private int _fitToScreenZoomLevel;
    private int _currentZoomLevel;
    private GameInput.RDActions _input;
    private bool _isZoomEnabled;
    private DataContext _zoomPanelContext;

    public event Action<float, Vector2?> OnZoomEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action OnFitToScreenEvent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableZoom() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnZoomedOut() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnZoomedIn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFitToScreen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPinMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ZoomHandler(bool isZoomingIn, Vector2? pointerPosition = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseScrolled(Vector2 scroll) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateZoomLevel(float zoomSpeed, Vector2? pointerPosition = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetZoomLevel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RDZoomPanel() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.UI.RDCameraManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Input;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (Camera))]
  [Obsolete("System has been replaced by KSP.Game.Science.RDCenterUIController")]
  public class RDCameraManager : KerbalMonoBehaviour
  {
    [SerializeField]
    private float _zoomAnimationSpeed;
    [SerializeField]
    private float _cameraMovementSpeed;
    [SerializeField]
    private Texture2D _dragHandPointer;
    private Camera _rdCamera;
    private RDZoomPanel _zoomPanel;
    private float _defaultOrthoSize;
    private Vector3 _defaultPosition;
    private GameInput.RDActions _input;
    private Vector3 _pointerDragOrigin;
    private Vector3 _pointerDragDistance;
    private Vector3 _mousePosition;
    private bool _isDragged;
    private bool _dragStarted;
    private Vector2 _keyInput;
    private Vector2 _pinMapBoundries;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Zoom(float zoomSpeed, Vector2? pointerposition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleKeyMovement(Vector2 keyArrowInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleClickAndDrag(Vector2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FitTreeToScreen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ClampRDCamera(Vector2 newPosition, float cameraOthoSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveCamera(Vector2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrag(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RDCameraManager() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapCameraInputHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Input;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapCameraInputHandler : KerbalMonoBehaviour
  {
    [SerializeField]
    private float _pitchLimitInDegrees;
    [SerializeField]
    private float _minSensitivity;
    private GameInput.MapViewActions _inputMap;
    private MapViewInputDefinition _inputDefinition;
    private MapCamera _mapCamera;
    private Transform _cameraTransform;
    private float _inversePitchLimit;
    private Vector3 _cameraMoveInput;
    private bool _precisionCameraEnabled;
    private bool _camMoveEnabled;
    private Vector2? _lastMouseData;
    private float _cumulativePitch;
    private float _cumulativeZoom;
    private bool _isDragging;
    private bool _initialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(MapCamera mapCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupInputMapping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindInputs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraRotation(float xAxis, float yAxis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCameraZoom(float zoomValue, bool omitCameraZoomedMessages = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCameraMoveValues(Vector2 direction, float multiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMousePosition(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseSecondary(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseTertiary(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMouseScroll(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraMoveXYPerformed(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraMoveXYCancelled(Vector2 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAltKeyModifier(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResetCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapCameraInputHandler() => throw null;
  }
}

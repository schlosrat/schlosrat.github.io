// Decompiled with JetBrains decompiler
// Type: SimpleRotateZoomCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class SimpleRotateZoomCamera : MonoBehaviour
{
  public float Distance;
  [FormerlySerializedAs("distanceRange")]
  public Vector2 DistanceRange;
  public Vector3 CenterOfRotation;
  [FormerlySerializedAs("distanceSpeedRange")]
  public Vector2 DistanceSpeedRange;
  [FormerlySerializedAs("translationSpeedRange")]
  public Vector2 TranslationSpeedRange;
  [FormerlySerializedAs("rotationSpeed")]
  public float RotationSpeed;
  public float PitchLimit;
  private Vector2 _lastFrameMouse;
  private bool _doesGameHaveFocus;
  private bool _lastFocusOnGame;
  [SerializeField]
  private float _xAxis;
  [SerializeField]
  private float _yAxis;
  [SerializeField]
  private float _curDot;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float ScaleSpeedByDistance(Vector2 speedRange) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnApplicationFocus(bool hasFocus) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool IsMouseOutsideGameView() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SimpleRotateZoomCamera() => throw null;
}

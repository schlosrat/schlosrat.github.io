// Decompiled with JetBrains decompiler
// Type: PQSRover
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("PQuadSphere/Tools/Surface Rover")]
public class PQSRover : MonoBehaviour
{
  public bool isActive;
  public double rotateSpeed;
  public float mouseSpeed;
  private bool showGUI;
  private PQS pqs;
  private double speed;
  private double altitude;
  private float mousePitch;
  private double angle;
  private double radius;
  private Vector3d direction;
  private QuaternionD rotation;
  private Vector3d realPos;
  private static double Deg2Rad;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Reset() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static string GetLatLong(Vector3 position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetPosition(Vector3 position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputSpeedFactor() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputMovement() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private double GetSpeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Pitch(float amount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Altitude(double amount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Rotate(double amount) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Translate(double x, double y) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTransform() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSRover() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static PQSRover() => throw null;
}

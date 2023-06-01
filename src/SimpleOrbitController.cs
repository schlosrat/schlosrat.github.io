// Decompiled with JetBrains decompiler
// Type: SimpleOrbitController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class SimpleOrbitController : MonoBehaviour
{
  public Transform satellite;
  public double distance;
  public double period;
  private double orbitalSpeed;
  private Vector3d orbitalPosition;
  private double orbitalAngle;
  private QuaternionD orbitalRot;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void FixedUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SimpleOrbitController() => throw null;
}

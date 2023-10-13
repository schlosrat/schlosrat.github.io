// Decompiled with JetBrains decompiler
// Type: Wheel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class Wheel
{
  public string wheelName;
  public string wheelColliderName;
  public string suspensionTransformName;
  public Transform suspensionNeutralPoint;
  public string suspensionNeutralPointName;
  public string damagedObjectName;
  public Transform damagedObject;
  public List<Transform> wheelTransforms;
  public Transform suspensionTransform;
  public Transform colliderTransform;
  public WheelCollider whCollider;
  public float rotateX;
  public float rotateY;
  public float rotateZ;
  public Vector3 wheelAxis;
  public RaycastHit hit;
  public bool isValid;
  public bool damageAble;
  public bool debug;
  private int layerMask;
  private WheelHit wheelHit;
  public float rescaleFactor;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Wheel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void damageWheel() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void repairWheel() => throw null;
}

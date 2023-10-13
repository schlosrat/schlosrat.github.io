// Decompiled with JetBrains decompiler
// Type: StartAtRandomRotation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class StartAtRandomRotation : OABOrFlightEnablable
{
  [SerializeField]
  [Space(10f)]
  private bool xAxis;
  [SerializeField]
  private bool yAxis;
  [SerializeField]
  private bool zAxis;
  [SerializeField]
  private float xAngleRange;
  [SerializeField]
  private float yAngleRange;
  [SerializeField]
  private float zAngleRange;
  [SerializeField]
  private float xOffset;
  [SerializeField]
  private float yOffset;
  [SerializeField]
  private float zOffset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetRandomAngle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StartAtRandomRotation() => throw null;
}

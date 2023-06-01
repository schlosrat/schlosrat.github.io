// Decompiled with JetBrains decompiler
// Type: fx_fly_camera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class fx_fly_camera : MonoBehaviour
{
  public float mainSpeed;
  public float shiftAdd;
  public float maxShift;
  public float camSens;
  public bool rotateOnlyIfMousedown;
  public bool movementStaysFlat;
  public bool EnableKeyboardInputs;
  private Vector3 lastMouse;
  private float totalRun;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3 GetBaseInput() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public fx_fly_camera() => throw null;
}

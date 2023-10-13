// Decompiled with JetBrains decompiler
// Type: fx_fly_camera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

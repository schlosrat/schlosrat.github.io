// Decompiled with JetBrains decompiler
// Type: RotateAtSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class RotateAtSpeed : OABOrFlightEnablable
{
  [Space(10f)]
  public float XSpeed;
  public float YSpeed;
  public float ZSpeed;
  public bool localSpaceOn;
  private Space _curSpace;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RotateAtSpeed() => throw null;
}

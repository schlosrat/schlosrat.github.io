// Decompiled with JetBrains decompiler
// Type: RotateAtSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

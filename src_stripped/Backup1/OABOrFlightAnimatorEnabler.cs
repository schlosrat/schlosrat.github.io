// Decompiled with JetBrains decompiler
// Type: OABOrFlightAnimatorEnabler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABOrFlightAnimatorEnabler : KerbalMonoBehaviour
{
  [SerializeField]
  [Tooltip("Will be enabled in OAB")]
  private bool enableInOAB;
  [Tooltip("Will be enabled in Flight")]
  [SerializeField]
  private bool enableInFlight;
  [SerializeField]
  private Animator[] animators;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABOrFlightAnimatorEnabler() => throw null;
}

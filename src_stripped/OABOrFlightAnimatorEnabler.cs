// Decompiled with JetBrains decompiler
// Type: OABOrFlightAnimatorEnabler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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

// Decompiled with JetBrains decompiler
// Type: OABOrFlightAnimatorEnabler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

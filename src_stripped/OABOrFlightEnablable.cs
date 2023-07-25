// Decompiled with JetBrains decompiler
// Type: OABOrFlightEnablable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABOrFlightEnablable : KerbalMonoBehaviour
{
  [Tooltip("Will be enabled anywhere and everywhere by default")]
  [SerializeField]
  protected bool enableEverywhere;
  [SerializeField]
  [Tooltip("Will be enabled in OAB")]
  protected bool enableInOAB;
  [Tooltip("Will be enabled in Flight")]
  [SerializeField]
  protected bool enableInFlight;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABOrFlightEnablable() => throw null;
}

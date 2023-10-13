// Decompiled with JetBrains decompiler
// Type: OABOrFlightEnablable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABOrFlightEnablable : KerbalMonoBehaviour
{
  [SerializeField]
  [Tooltip("Will be enabled anywhere and everywhere by default")]
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

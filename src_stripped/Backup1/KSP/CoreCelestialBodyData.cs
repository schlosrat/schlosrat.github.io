// Decompiled with JetBrains decompiler
// Type: KSP.CoreCelestialBodyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  [DisallowMultipleComponent]
  public class CoreCelestialBodyData : MonoBehaviour
  {
    [SerializeField]
    private CelestialBodyCore core;

    public CelestialBodyData Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CelestialBodyCore Core
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CoreCelestialBodyData() => throw null;
  }
}

// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SimColliderTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim
{
  [AddComponentMenu("SimColliderTag")]
  public class SimColliderTag : MonoBehaviour
  {
    public TagType objectColliderTag;
    public string objectColliderName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimColliderTag() => throw null;
  }
}

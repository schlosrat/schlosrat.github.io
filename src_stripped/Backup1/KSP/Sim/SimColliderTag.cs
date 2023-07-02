// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SimColliderTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

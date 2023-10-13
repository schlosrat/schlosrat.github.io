// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SimColliderTag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.SplineFollowBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace EdyCommonTools
{
  public class SplineFollowBehaviour : PlayableBehaviour
  {
    public Spline spline;
    public bool followRotation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SplineFollowBehaviour() => throw null;
  }
}

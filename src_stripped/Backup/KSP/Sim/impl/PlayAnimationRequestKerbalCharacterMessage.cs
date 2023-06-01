// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PlayAnimationRequestKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PlayAnimationRequestKerbalCharacterMessage : KerbalCharacterMessage
  {
    public int? PlayAnimTriggerId;
    public int? PlayAnimFloatId;
    public int? PlayAnimBoolId;
    public float PlayAnimFloatValue;
    public bool PlayAnimBoolValue;
    public string AnimationStateName;
    public Action OnAnimStartCallback;
    public Action OnAnimEndCallback;
    public bool DisableEVAFlightInteractInputs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationRequestKerbalCharacterMessage(
      int? triggerId,
      int? floatId,
      float floatValue,
      int? boolId,
      bool boolValue,
      bool disableEvaFlightInteractInputs,
      Action onAnimStartCallback,
      Action onAnimEndCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationRequestKerbalCharacterMessage(
      string animationStateName,
      bool disableEvaFlightInteractInputs,
      Action onAnimStartCallback,
      Action onAnimEndCallback)
    {
      throw null;
    }
  }
}

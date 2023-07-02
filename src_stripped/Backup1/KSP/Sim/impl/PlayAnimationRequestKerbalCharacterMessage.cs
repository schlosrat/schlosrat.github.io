// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PlayAnimationRequestKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

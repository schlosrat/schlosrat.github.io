// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.LadderStartClimbKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class LadderStartClimbKerbalCharacterMessage : KerbalCharacterMessage
  {
    public ClimbInstance ClimbInstance;
    public InteractInstance InteractInstance;
    public IGGuid LadderPartId;
    public bool TweenTo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LadderStartClimbKerbalCharacterMessage(
      ClimbInstance climbInstance,
      InteractInstance interactInstance,
      IGGuid ladderPartId,
      bool tweenTo)
    {
      throw null;
    }
  }
}

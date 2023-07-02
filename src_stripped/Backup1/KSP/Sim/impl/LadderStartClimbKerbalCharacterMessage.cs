// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.LadderStartClimbKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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

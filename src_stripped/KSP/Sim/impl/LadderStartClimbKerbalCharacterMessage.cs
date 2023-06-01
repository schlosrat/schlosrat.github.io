// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.LadderStartClimbKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class LadderStartClimbKerbalCharacterMessage : KerbalCharacterMessage
  {
    public ClimbInstance ClimbInstance;
    public InteractInstance InteractInstance;
    public IGGuid LadderPartId;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LadderStartClimbKerbalCharacterMessage(
      ClimbInstance climbInstance,
      InteractInstance interactInstance,
      IGGuid ladderPartId)
    {
      throw null;
    }
  }
}

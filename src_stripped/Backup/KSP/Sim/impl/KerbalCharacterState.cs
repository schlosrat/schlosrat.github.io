// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.KerbalCharacterState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct KerbalCharacterState
  {
    public bool IsFalling;
    public bool IsJetpackInUse;
    public bool IsPreJumping;
    public bool IsJumping;
    public bool IsClimbing;
    public bool IsClambering;
    public bool IsUnderwater;
    public bool IsFloatingInWater;
    public bool IsSwimming;
    public bool IsPlayingFullBodyAnim;

    public bool IsLadderClimbing
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}

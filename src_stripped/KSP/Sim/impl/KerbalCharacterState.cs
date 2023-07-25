// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.KerbalCharacterState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

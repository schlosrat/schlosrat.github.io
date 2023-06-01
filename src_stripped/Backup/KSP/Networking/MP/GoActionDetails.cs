// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.GoActionDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP
{
  public class GoActionDetails
  {
    public ulong ObjectId;
    public GoActionDetails.StagingAction GoAction;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GoActionDetails() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    public enum StagingAction : byte
    {
      None = 0,
      MoveToLaunch = 1,
      InitiateCountdown = 4,
      LaunchImmediate = 8,
      TriggerStage = 16, // 0x10
    }
  }
}

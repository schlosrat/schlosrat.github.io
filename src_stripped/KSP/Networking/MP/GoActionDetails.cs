// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.GoActionDetails
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

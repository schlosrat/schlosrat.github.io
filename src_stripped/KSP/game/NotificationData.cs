// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class NotificationData
  {
    public NotificationTier Tier;
    public NotificationLineItemData Primary;
    public NotificationLineItemData AdminTitle;
    public NotificationLineItemData AlertTitle;
    public double TimeStamp;
    public NotificationLineItemData FirstLine;
    public NotificationImportance Importance;
    public bool IsTimerActive;
    public float TimerDuration;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public NotificationData() => throw null;
  }
}

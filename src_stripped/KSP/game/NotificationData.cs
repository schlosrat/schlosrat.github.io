// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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

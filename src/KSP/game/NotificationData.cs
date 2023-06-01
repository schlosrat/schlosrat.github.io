// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

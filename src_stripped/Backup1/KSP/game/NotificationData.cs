// Decompiled with JetBrains decompiler
// Type: KSP.Game.NotificationData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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

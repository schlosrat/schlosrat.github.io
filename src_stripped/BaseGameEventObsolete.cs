// Decompiled with JetBrains decompiler
// Type: BaseGameEventObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BaseGameEventObsolete
{
  private static Dictionary<string, BaseGameEventObsolete> eventsByName;
  protected string eventName;
  public bool debugEvent;

  public string EventName
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BaseGameEventObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  internal static T FindEvent<T>(string eventName) where T : BaseGameEventObsolete => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static BaseGameEventObsolete() => throw null;
}

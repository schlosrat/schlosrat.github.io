// Decompiled with JetBrains decompiler
// Type: KSPModelEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class KSPModelEvent : Attribute
{
  public string startEvent;
  public string finishEvent;
  public bool allowMultiple;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPModelEvent(string startEvent, string finishEvent, bool allowMultiple) => throw null;
}

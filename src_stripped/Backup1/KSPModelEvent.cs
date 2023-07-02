// Decompiled with JetBrains decompiler
// Type: KSPModelEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

// Decompiled with JetBrains decompiler
// Type: KSPModelEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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

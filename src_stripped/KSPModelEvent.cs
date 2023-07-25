// Decompiled with JetBrains decompiler
// Type: KSPModelEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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

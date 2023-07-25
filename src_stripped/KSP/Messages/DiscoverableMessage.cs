// Decompiled with JetBrains decompiler
// Type: KSP.Messages.DiscoverableMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [AttributeUsage(AttributeTargets.Class)]
  public class DiscoverableMessage : Attribute
  {
    public string discoveryName;
    public bool isActive;
    public string userNotes;
    public string implNotes;
    public uint ID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(string name, string implementationNotes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(string name, uint id, string implementationNotes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(
      string name,
      bool eventIsActive = true,
      string UserNotes = "",
      string ImplementationNotes = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(string name, uint id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableMessage(
      string name,
      uint id,
      bool eventIsActive = true,
      string UserNotes = "",
      string ImplementationNotes = "")
    {
      throw null;
    }
  }
}

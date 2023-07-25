// Decompiled with JetBrains decompiler
// Type: KSP.IO.PluginConfigNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

namespace KSP.IO
{
  public class PluginConfigNode
  {
    private Dictionary<string, object> map;
    private PluginConfigNode parent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal PluginConfigNode(PluginConfigNode parent, Dictionary<string, object> _map) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PluginConfigNode(PluginConfigNode parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PluginConfigNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PluginConfigNode GetParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue<T>(string key) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T GetValue<T>(string key, T _default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetValue(string key, object value) => throw null;

    public object this[string key]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void serializeXML(ref XmlTextWriter xml) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void deserializeXML(XmlNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void handleElement(XmlNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartNamedElement(ref XmlTextWriter xml, string name, string typeID) => throw null;
  }
}

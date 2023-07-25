// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.ModuleProperty`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  public class ModuleProperty<T> : 
    Property<T>,
    IModuleProperty,
    IPropertyWritable,
    IProperty,
    IModuleDataContext
  {
    [JsonIgnore]
    private ToStringDelegate _toStringDelegate;
    private readonly bool _isReadOnly;

    [JsonIgnore]
    public ToStringDelegate ToStringDelegate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [JsonIgnore]
    public bool IsReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ContextKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetContextKey() => throw null;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleProperty(T initialValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleProperty(T initialValue, bool isReadOnly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleProperty(T initialValue, ToStringDelegate toStringDelegate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleProperty(T initialValue, bool isReadOnly, ToStringDelegate toStringDelegate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleProperty(
      T initialValue,
      Func<T, T> validator,
      bool isReadOnly,
      ToStringDelegate toStringDelegate)
    {
      throw null;
    }
  }
}

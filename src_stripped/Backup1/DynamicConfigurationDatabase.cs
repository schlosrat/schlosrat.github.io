// Decompiled with JetBrains decompiler
// Type: DynamicConfigurationDatabase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class DynamicConfigurationDatabase
{
  private readonly Dictionary<System.Type, Dictionary<string, List<object>>> configuration;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(object value, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(object value, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<System.Type> Types() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<string> Tables(System.Type type) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public IEnumerable<object> Values(System.Type type, string table = "") => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Dictionary<string, List<object>> GetByType(System.Type type, bool createIfMissing = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private List<object> Get(System.Type type, string table = "", bool createIfMissing = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ClearAll() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DynamicConfigurationDatabase() => throw null;
}

// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  public class ScriptSerializer
  {
    private ScriptEnvironment environment;
    private FormatOptions formatOptions;

    public bool serializeAsBinary
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptSerializer(ScriptEnvironment environment, bool serializeAsBinary) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object Serialize<T>(T data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object SerializeRef<T>(T? data) where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object SerializeObject(object data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected string SerializeAsString<T>(T data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected byte[] SerializeAsBin<T>(T data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected IScriptValue deserialize<T>(object storeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object DeserializeToObject(object storeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Deserialize<T>(object storeData) where T : class => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T? DeserializeRef<T>(object storeData) where T : struct => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T DeserializeRefOrDefault<T>(object storeData) where T : struct => throw null;
  }
}

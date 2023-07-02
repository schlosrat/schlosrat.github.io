// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ScriptSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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

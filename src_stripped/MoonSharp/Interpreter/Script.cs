// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Script
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using MoonSharp.Interpreter.Diagnostics;
using MoonSharp.Interpreter.Execution.VM;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class Script : IScriptPrivateResource
  {
    public const string VERSION = "2.0.0.0";
    public const string LUA_VERSION = "5.2";
    private Processor m_MainProcessor;
    private ByteCode m_ByteCode;
    private List<SourceCode> m_Sources;
    private Table m_GlobalTable;
    private IDebugger m_Debugger;
    private Table[] m_TypeMetatables;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Script() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Script() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Script(CoreModules coreModules) => throw null;

    public static ScriptOptions DefaultOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ScriptOptions Options
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static ScriptGlobalOptions GlobalOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public PerformanceStatistics PerformanceStats
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Table Globals
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue LoadFunction(string code, Table globalTable = null, string funcFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SignalByteCodeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SignalSourceCodeChange(SourceCode source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue LoadString(string code, Table globalTable = null, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue LoadStream(Stream stream, Table globalTable = null, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dump(DynValue function, Stream stream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue LoadFile(string filename, Table globalContext = null, string friendlyFilename = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue DoString(string code, Table globalContext = null, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue DoStream(Stream stream, Table globalContext = null, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue DoFile(string filename, Table globalContext = null, string codeFriendlyName = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue RunFile(string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue RunString(string code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private DynValue MakeClosure(int address, Table envTable = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(DynValue function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(DynValue function, params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(DynValue function, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(object function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Call(object function, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue CreateCoroutine(DynValue function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue CreateCoroutine(object function) => throw null;

    public bool DebuggerEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AttachDebugger(IDebugger debugger) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SourceCode GetSourceCode(int sourceCodeID) => throw null;

    public int SourceCodeCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue RequireModule(string modname, Table globalContext = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Table GetTypeMetatable(DataType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTypeMetatable(DataType type, Table metatable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WarmUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicExpression CreateDynamicExpression(string code) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ScriptExecutionContext CreateDynamicExecutionContext(CallbackFunction func = null) => throw null;

    public Table Registry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetBanner(string subproduct = null) => throw null;

    Script IScriptPrivateResource.OwnerScript
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}

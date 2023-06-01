// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DynValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter
{
  public sealed class DynValue
  {
    private static int s_RefIDCounter;
    private int m_RefID;
    private int m_HashCode;
    private bool m_ReadOnly;
    private double m_Number;
    private object m_Object;
    private DataType m_Type;

    public int ReferenceID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DataType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Closure Function
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Number
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DynValue[] Tuple
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Coroutine Coroutine
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Table Table
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Boolean
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string String
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CallbackFunction Callback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TailCallData TailCallData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public YieldRequest YieldRequest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UserData UserData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ReadOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewNil() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewBoolean(bool v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewNumber(double num) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewString(string str) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewString(StringBuilder sb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewString(string format, params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewCoroutine(Coroutine coroutine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewClosure(Closure function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewCallback(
      Func<ScriptExecutionContext, CallbackArguments, DynValue> callBack,
      string name = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewCallback(CallbackFunction function) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTable(Table table) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewPrimeTable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTable(Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTable(Script script, params DynValue[] arrayValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTailCallReq(DynValue tailFn, params DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTailCallReq(TailCallData tailCallData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewYieldReq(DynValue[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static DynValue NewForcedYieldReq() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTuple(params DynValue[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewTupleNested(params DynValue[] values) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue NewUserData(UserData userData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue AsReadOnly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Clone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue Clone(bool readOnly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue CloneAsWritable() => throw null;

    public static DynValue Void
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static DynValue Nil
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static DynValue True
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static DynValue False
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DynValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToPrintString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string ToDebugPrintString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string CastToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double? CastToNumber() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CastToBool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IScriptPrivateResource GetAsPrivateResource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue ToScalar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Assign(DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue GetLength() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNil() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNotNil() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVoid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNotVoid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNilOrNan() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AssignNumber(double num) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue FromObject(Script script, object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object ToObject(System.Type desiredType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T ToObject<T>() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue CheckType(
      string funcName,
      DataType desiredType,
      int argNum = -1,
      TypeValidationFlags flags = TypeValidationFlags.AutoConvert)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T CheckUserDataType<T>(string funcName, int argNum = -1, TypeValidationFlags flags = TypeValidationFlags.AutoConvert) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue() => throw null;
  }
}

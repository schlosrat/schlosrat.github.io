// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.ErrorFlag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class ErrorFlag
  {
    public const bool DEFAULT_ERROR_AS_WARNING = false;
    public const string NO_ERROR = "No Error";
    public const string UNSPECIFIED_ERROR = "Unspecified Error";
    private bool _errorAsWarning;
    private bool _errorFlag;
    private string _errorString;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogWarn(string warnString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogError(string errorString) => throw null;

    public bool ErrorAsWarning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetErrorAsWarning(bool errorAsWarning) => throw null;

    public bool IsErrorFlagSet
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ErrorString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorFlag(bool errorAsWarning = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~ErrorFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool errorAsWarning = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDataValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearErrorFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetErrorFlag(string errorString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ErrorFlag.StateData GetStateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreViaStateData(ErrorFlag.StateData stateData) => throw null;

    public struct StateData
    {
      public const bool DEFAULT_ERROR_AS_WARNING = false;
      public const string NO_ERROR = "No Error";
      public const string UNSPECIFIED_ERROR = "Unspecified Error";
      public bool ErrorAsWarning;
      public bool ErrorFlag;
      public string ErrorString;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StateData(bool errorAsWarning, bool errorFlag, string errorString) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Clear() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Set(bool errorAsWarning, bool errorFlag, string errorString) => throw null;
    }
  }
}

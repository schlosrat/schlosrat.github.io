// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Authentication.AuthVars
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Authentication
{
  public class AuthVars
  {
    public static string OnlinePlayerNameString;
    public static string OnlinePlayerPasswordString;
    public static string OnlinePlayerGuidString;
    public static bool IsLoggedIn;
    public static bool AccountCreationStatus;
    public static string AccountLoginStatusMessage;
    public static string AccountCreationStatusMessage;
    public static string AccountLoginStatus;
    public static string CrossSaveStatus;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AuthVars() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AuthVars() => throw null;
  }
}

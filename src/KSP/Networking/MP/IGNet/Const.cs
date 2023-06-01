// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.IGNet.Const
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Networking.MP.IGNet
{
  public static class Const
  {
    public const string DEFAULT_PLAYER_NAME_STRING_BASE = "Unnamed Player";
    public const int SERVER_MAX_PLAYERS = 1;
    public const int SERVER_MIN_PLAYERS = 1;

    public static class PlayerId
    {
      public const byte NONE = 0;
      public const byte FIRST = 1;
      public const byte HOST = 1;
      public const byte SINGLEPLAYER = 1;
    }

    public static class PlayerIdString
    {
      public const string NONE = "None";
    }
  }
}

struct LoginResponseBody{
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] 
  public char[] ip;
  public int port;
  public int cookie;
}

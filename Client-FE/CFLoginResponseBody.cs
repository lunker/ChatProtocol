struct LoginResponseBody{
  [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)] char[] ip;
  int port;
  int cookie;
}

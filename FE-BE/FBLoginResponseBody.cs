// type : Login = 210
// client의 로그인 요청에 대한 응답 
struct FBLoginResponseBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public char[] id; // user id 
}

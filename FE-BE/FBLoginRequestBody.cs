using System.Runtime.InteropServices;
// type : Login = 210
// Client의 로그인 요청을 처리하기 위하여 필요한 body
struct FBLoginRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] char[] id; // user id 
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] char[] password; // user password
}

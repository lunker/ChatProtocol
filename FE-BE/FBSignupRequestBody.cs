// type : Signup = 120
// client의 회원가입을 처리하기 위한 request body
struct FBSignupRequestBody
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] id; // user id 
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    char[] password; // user password 
}

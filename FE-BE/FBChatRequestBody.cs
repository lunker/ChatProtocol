// type : Chat_Count = 410 일때 사용. 
struct FBChatRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] char[] id;// user id 
}

/*
    type : 
    Room_Create = 310,
    Room_Leave = 320,
    Room_Join = 330,
    Room_List = 340,
    
*/
// 채팅방 관련 요청 시 사용되는 추가적인 data를 위한 body
struct FBRoomRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] id; // user id
    int roomNo; // chat room number 
}

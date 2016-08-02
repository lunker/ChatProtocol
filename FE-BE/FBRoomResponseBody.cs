/*
    type : 
    Room_Create = 310,
    Room_Leave = 320,
    Room_Join = 330,
    Room_List = 340,
    
*/
// 채팅방 관련 요청 시 응답을 위하여 사용되는 추가적인 data를 위한 body
// 가변길이로 인해 별도의 struct대신에 각 데이터들을 byte[]로 전송. 
struct FBRoomResponseBody
{
  // empty
  // data can be : chat Room List(int array), FE IP(string)-PORT(int), chat room no . . .  
  
  /*
    1) chat room list 
    : int array (4*N) 
    
    2) FE Information 
    : IP -> string
    : Port -> int 
    
    3) chat room No 
    : int
  */
}

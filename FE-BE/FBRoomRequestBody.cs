struct FBRoomRequestBody{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] id;
    int roomNo;
}

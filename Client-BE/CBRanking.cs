// containing single rank information
// will be used as struct array to provide Ranking information
public struct CBRanking
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] id; // user id
    int rank; // user's rnak 
}

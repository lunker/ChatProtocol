static class MessageType
    {
        public enum Types : short
        {

            RequestUseridCheck=100,
            
            RequestSignup =110,

            RequestLogin=200,

            RequestListRoom = 300,
            RequestJoinRoom = 310,
            RequestLeaveRoom = 320,
            RequestCreateRoom = 330,

            RequestChatting = 400,

            StatusRequest = 100,
            StatusSuccess =200,
            StatusFail=400,
        };
    }

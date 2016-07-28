static class MessageType
    {
        public enum Types : short
        {

            REQUEST_USERID_CHECK=100,
            REQUEST_SIGNUP =110,

            REQUEST_LOGIN=200,

            REQUEST_LIST_ROOM = 300,
            REQUEST_JOIN_ROOM = 310,
            REQUEST_LEAVE_ROOM = 320,
            REQUEST_CREATE_ROOM = 330,

            REQUEST_CHATTING = 400,

            STATUS_REQUEST = 100,
            STATUS_SUCCESS =200,
            STATUS_FAIL=400,
        };
    }

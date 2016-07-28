static class MessageType
    {

        public enum Types : short
        {

            REQUEST_SIGNUP=100,
            REQEUST_CHECK_SIGNEDUP=110,
            REQUEST_LOGIN=120,
            
            CHAT_MSG=200,

            REQUEST_CREATE_ROOM=310,
            REQUEST_LEAVE_ROOM=320,
            REQUEST_JOIN_ROOM=330,
            REQUEST_LIST_ROOM=340,

            STATUS_SUCCESS=200,
            STATUS_FAIL=400,

        };
        
    }

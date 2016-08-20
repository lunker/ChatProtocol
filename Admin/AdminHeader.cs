using System.Runtime.InteropServices;

namespace Agent
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    struct AdminHeader
    {
        public AdminMessageType type;
        public AdminMessageState state;
        public int length;

        public AdminHeader(AdminMessageType type, AdminMessageState state, int length)
        {
            this.type = type;
            this.state = state;
            this.length = length;
        }
    }

    enum AdminMessageType : short
    {
        DelegateCIA,
        MonitoringInfo,
        FEServerManaging
    }
    
    enum AdminMessageState : short
    {
        REQUEST = 100, // state that this message is 'Request'
        SUCCESS = 200, // state that this message is Response messgae with 'Success'
        FAIL = 400 // state that this message is Response message with 'Fail'
    }

}

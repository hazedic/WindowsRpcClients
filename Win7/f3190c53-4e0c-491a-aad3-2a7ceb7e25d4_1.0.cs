//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\vpnikeapi.dll
// Interface ID: f3190c53-4e0c-491a-aad3-2a7ceb7e25d4
// Interface Version: 1.0



namespace rpc_f3190c53_4e0c_491a_aad3_2a7ceb7e25d4_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("f3190c53-4e0c-491a-aad3-2a7ceb7e25d4", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint VpnikeGetNewTunnelID(ref long p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadInt64();
            return u.ReadUInt32();
        }
    }
    #endregion
}


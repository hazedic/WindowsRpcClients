//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\eeprov.dll
// Interface ID: 714dc5c4-c5f6-466a-b037-a573c958031e
// Interface Version: 1.0



namespace rpc_714dc5c4_c5f6_466a_b037_a573c958031e_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(string p0, long p1)
        {
            WriteConformantVaryingString(p0, p1);
        }
        public void Write_1(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
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
        public sbyte[] Read_0()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("714dc5c4-c5f6-466a-b037-a573c958031e", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PtRpcSetProcessTag(long p0, string p1, int p2, sbyte[] p3, int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p4);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int PtRpcWriteTelemetry(int p0, long p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteInt64(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
    }
    #endregion
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\WSService.dll
// Interface ID: c453c318-b4a8-4188-80c4-73e6c7417dbf
// Interface Version: 1.0



namespace rpc_c453c318_b4a8_4188_80c4_73e6c7417dbf_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public sbyte[] Read_1()
        {
            return ReadConformantArray<sbyte>();
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("c453c318-b4a8-4188-80c4-73e6c7417dbf", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int ServiceMain(out NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ServiceMain_1(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ServiceMain_2(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, int p2, sbyte[] p3, out int p4, out sbyte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteInt32(p2);
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(2, m);
            p4 = u.ReadInt32();
            p5 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_1), false);
            return u.ReadInt32();
        }
        public int ServiceMain_3(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, NtApiDotNet.Ndr.Marshal.NdrEnum16 p1, int p2, sbyte[] p3, out int p4, out sbyte[] p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteEnum16(p1);
            m.WriteInt32(p2);
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p3, "p3"), p2);
            _Unmarshal_Helper u = SendReceive(3, m);
            p4 = u.ReadInt32();
            p5 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_1), false);
            return u.ReadInt32();
        }
    }
    #endregion
}


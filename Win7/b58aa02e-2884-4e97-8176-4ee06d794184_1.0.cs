//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\WinSATAPI.dll
// Interface ID: b58aa02e-2884-4e97-8176-4ee06d794184
// Interface Version: 1.0



namespace rpc_b58aa02e_2884_4e97_8176_4ee06d794184_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(sbyte[] p0, long p1)
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
                base("b58aa02e-2884-4e97-8176-4ee06d794184", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int PfRpcServerExecuteCommand(ref sbyte[] p0, ref int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), NtApiDotNet.Win32.Rpc.RpcUtils.DeRef(p1));
            m.WriteInt32(p1);
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.Read_0();
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
    }
    #endregion
}


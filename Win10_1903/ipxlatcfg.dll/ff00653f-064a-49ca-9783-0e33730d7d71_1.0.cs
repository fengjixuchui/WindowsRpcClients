//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\ipxlatcfg.dll
// Interface ID: ff00653f-064a-49ca-9783-0e33730d7d71
// Interface Version: 1.0



namespace rpc_ff00653f_064a_49ca_9783_0e33730d7d71_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 16);
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
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public sbyte[] Read_1()
        {
            return ReadFixedPrimitiveArray<sbyte>(16);
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
            m.WriteSByte(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
            Member10 = u.ReadSByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public sbyte Member10;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new sbyte[16];
            return ret;
        }
        public Struct_0(sbyte[] Member0, sbyte Member10)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("ff00653f-064a-49ca-9783-0e33730d7d71", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int Enable464xlat(long p0, int p1, System.Nullable<Struct_0> p2, System.Nullable<Struct_0> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            m.WriteInt32(p1);
            m.WriteReferent(p2, new System.Action<Struct_0>(m.Write_0));
            m.WriteReferent(p3, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int Disable464xlat(long p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

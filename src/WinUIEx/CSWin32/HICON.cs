// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable CS1591, CS1573, CS0649, CS8019, CS1570, CS1584, CS1658
namespace Microsoft.Windows.Sdk
{
    using global::System;
    using global::System.Diagnostics;
    using global::System.Runtime.InteropServices;

    [DebuggerDisplay("{Value}")]
    internal readonly partial struct HICON : IEquatable<HICON>
    {
        internal readonly IntPtr Value;
        internal HICON(IntPtr value) => this.Value = value;
        public static implicit operator IntPtr(HICON value) => value.Value;
        public static explicit operator HICON(IntPtr value) => new HICON(value);
        public bool Equals(HICON other) => this.Value == other.Value;
        public override bool Equals(object obj) => obj is HICON other && this.Equals(other);
        public override int GetHashCode() => this.Value.GetHashCode();
    }
}
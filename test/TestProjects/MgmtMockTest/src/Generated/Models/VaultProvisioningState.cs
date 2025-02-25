// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace MgmtMockTest.Models
{
    /// <summary> Provisioning state of the vault. </summary>
    public readonly partial struct VaultProvisioningState : IEquatable<VaultProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VaultProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VaultProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string RegisteringDnsValue = "RegisteringDns";

        /// <summary> Succeeded. </summary>
        public static VaultProvisioningState Succeeded { get; } = new VaultProvisioningState(SucceededValue);
        /// <summary> RegisteringDns. </summary>
        public static VaultProvisioningState RegisteringDns { get; } = new VaultProvisioningState(RegisteringDnsValue);
        /// <summary> Determines if two <see cref="VaultProvisioningState"/> values are the same. </summary>
        public static bool operator ==(VaultProvisioningState left, VaultProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VaultProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(VaultProvisioningState left, VaultProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VaultProvisioningState"/>. </summary>
        public static implicit operator VaultProvisioningState(string value) => new VaultProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VaultProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VaultProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

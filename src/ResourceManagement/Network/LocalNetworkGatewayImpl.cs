// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;

namespace Microsoft.Azure.Management.Network.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.Network.Fluent.LocalNetworkGateway.Definition;
    using Microsoft.Azure.Management.Network.Fluent.LocalNetworkGateway.Update;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using System.Collections.Generic;

    /// <summary>
    /// Implementation for LocalNetworkGateway and its create and update interfaces.
    /// </summary>
///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50Lm5ldHdvcmsuaW1wbGVtZW50YXRpb24uTG9jYWxOZXR3b3JrR2F0ZXdheUltcGw=
    internal partial class LocalNetworkGatewayImpl  :
        GroupableResource<ILocalNetworkGateway,
            LocalNetworkGatewayInner,
            LocalNetworkGatewayImpl,
            INetworkManager,
            IWithGroup,
            LocalNetworkGateway.Definition.IWithIPAddress,
            IWithCreate,
            IUpdate>,
        ILocalNetworkGateway,
        IDefinition,
        IUpdate
    {
        ///GENMHASH:0A630A9A81A6D7FB1D87E339FE830A51:12952E8CD5F552DB05A3C835C16FDB67
        public ISet<string> AddressSpaces()
        {
            if (Inner.LocalNetworkAddressSpace == null)
                return new HashSet<string>();
            else if (Inner.LocalNetworkAddressSpace.AddressPrefixes == null)
                return new HashSet<string>();
            else
                return new HashSet<string>(Inner.LocalNetworkAddressSpace.AddressPrefixes?.ToArray());
        }

        ///GENMHASH:EE424593047EC034E4F687A7D891306B:9F58304362D8DE3E42998AA81F3F26B7
        public LocalNetworkGatewayImpl WithBgp(long asn, string bgpPeeringAddress)
        {
            var bgpSettings = EnsureBgpSettings();
            bgpSettings.Asn = asn;
            bgpSettings.BgpPeeringAddress = bgpPeeringAddress;
            return this;
        }

        ///GENMHASH:D747AFA75EF01A631FD1E74DD4950F8C:CBF36D794E88BFED53AE4DC92C5109ED
        public LocalNetworkGatewayImpl DisableBgp()
        {
            Inner.BgpSettings = null;
            return this;
        }

        ///GENMHASH:EB9638E8F65D17F5F594E27D773A247D:76CB3404F2AA8C8A92105F19077E56E5
        public string IPAddress()
        {
            return Inner.GatewayIpAddress;
        }

        ///GENMHASH:F157B95CCB8CF0DA53120069F9F2C22E:AC1F1618AD3F0F9E28C72955671856B0
        public BgpSettings BgpSettings()
        {
            return Inner.BgpSettings;
        }

        ///GENMHASH:944BF1730016EB109BA8A7D6EE074FD9:F74BB6BC059AFA1A1E3F924F48E56CEA
        public LocalNetworkGatewayImpl WithIPAddress(string ipAddress)
        {
            Inner.GatewayIpAddress = ipAddress;
            return this;
        }

        ///GENMHASH:99D5BF64EA8AA0E287C9B6F77AAD6FC4:3DB04077E6BABC0FB5A5ACDA19D11309
        public string ProvisioningState()
        {
            return Inner.ProvisioningState;
        }

        ///GENMHASH:5AD91481A0966B059A478CD4E9DD9466:BBBF85453ECDDF99A3961ECF45244C82
        protected async override Task<Models.LocalNetworkGatewayInner> GetInnerAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this.Manager.Inner.LocalNetworkGateways.GetAsync(this.ResourceGroupName, this.Name);
        }

        ///GENMHASH:FFC621DA0580E44927EBEA8D394C1105:84CEF0775356674F2DF43DA4215FAB0F
        private BgpSettings EnsureBgpSettings()
        {
            if (Inner.BgpSettings == null) {
                Inner.BgpSettings = new BgpSettings();
            }
            return Inner.BgpSettings;
        }

        ///GENMHASH:1F898F316F61076DCEA9CB72F400DA09:3881994DCADCE14215F82F0CC81BDD88
        internal  LocalNetworkGatewayImpl(string name, LocalNetworkGatewayInner innerModel, INetworkManager networkManager) : base(name, innerModel, networkManager)
        {
        }

        ///GENMHASH:2DDC261430ADA2CF9ED379E7C096EA18:DC31209198DBB3C120D21921CEFF604C
        public LocalNetworkGatewayImpl WithoutAddressSpace(string cidr)
        {
            if (Inner.LocalNetworkAddressSpace != null && Inner.LocalNetworkAddressSpace.AddressPrefixes != null) {
                Inner.LocalNetworkAddressSpace.AddressPrefixes.Remove(cidr);
            }
            return this;
        }

        ///GENMHASH:0202A00A1DCF248D2647DBDBEF2CA865:D2A6D2A6D9D7D04639AA5B3E46602E45
        public async override Task<Microsoft.Azure.Management.Network.Fluent.ILocalNetworkGateway> CreateResourceAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            var response = await Manager.Inner.LocalNetworkGateways.CreateOrUpdateAsync(ResourceGroupName, Name, Inner);
            SetInner(response);
            return this;
        }

        ///GENMHASH:BF356D3C256200922092FDECCE2AEA83:143AB2891351652F599BAE8243F35CE5
        public LocalNetworkGatewayImpl WithAddressSpace(string cidr)
        {
            if (Inner.LocalNetworkAddressSpace == null)
                Inner.LocalNetworkAddressSpace = new AddressSpace();

            if (Inner.LocalNetworkAddressSpace.AddressPrefixes == null)
                Inner.LocalNetworkAddressSpace.AddressPrefixes = new List<string>();

            Inner.LocalNetworkAddressSpace.AddressPrefixes.Add(cidr);
            return this;
        }
    }
}
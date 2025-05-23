// SPDX-FileCopyrightText: 2024 Piras314 <p1r4s@proton.me>
// SPDX-FileCopyrightText: 2024 username <113782077+whateverusername0@users.noreply.github.com>
// SPDX-FileCopyrightText: 2024 whateverusername0 <whateveremail>
// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aiden <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2025 JohnOakman <sremy2012@hotmail.fr>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 github-actions <github-actions@github.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Maths.FixedPoint;
using Content.Shared.StatusIcon;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Heretic;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class GhoulComponent : Component
{
    /// <summary>
    ///     Indicates who ghouled the entity.
    /// </summary>
    [DataField, AutoNetworkedField] public NetEntity? BoundHeretic;

    /// <summary>
    ///     Total health for ghouls.
    /// </summary>
    [DataField] public FixedPoint2 TotalHealth = 50;

    /// <summary>
    ///     Whether ghoul should be given a bloody blade
    /// </summary>
    [DataField]
    public bool GiveBlade;

    [DataField]
    public EntityUid? BoundBlade;

    [DataField]
    public EntProtoId BladeProto = "HereticBladeFleshGhoul";

    [DataField]
    public SoundSpecifier? BladeDeleteSound = new SoundCollectionSpecifier("gib");

    [DataField, ViewVariables(VVAccess.ReadOnly)]
    public ProtoId<FactionIconPrototype> MasterIcon { get; set; } = "GhoulHereticMaster";
    [DataField, ViewVariables(VVAccess.ReadOnly)]
    public ProtoId<FactionIconPrototype> GhoulIcon { get; set; } = "GhoulFaction";
}

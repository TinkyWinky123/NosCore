//  __  _  __    __   ___ __  ___ ___  
// |  \| |/__\ /' _/ / _//__\| _ \ __| 
// | | ' | \/ |`._`.| \_| \/ | v / _|  
// |_|\__|\__/ |___/ \__/\__/|_|_\___| 
// 
// Copyright (C) 2019 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.ComponentModel.DataAnnotations;
using NosCore.Data.I18N;
using NosCore.Data.Dto;
using NosCore.Data.StaticEntities;
using NosCore.Data.DataAttributes;
using NosCore.Data.Enumerations.I18N;
using Mapster;

namespace NosCore.Data.StaticEntities
{
	/// <summary>
	/// Represents a DTO class for NosCore.Database.Entities.NpcMonster.
	/// NOTE: This class is generated by GenerateDtos.tt
	/// </summary>
	[StaticMetaData(LoadedMessage = LogLanguageKey.NPCMONSTERS_LOADED)]
	public class NpcMonsterDto : IStaticDto
	{
		public byte AmountRequired { get; set; }

	 	public byte AttackClass { get; set; }

	 	public byte AttackUpgrade { get; set; }

	 	public byte BasicArea { get; set; }

	 	public short BasicCooldown { get; set; }

	 	public byte BasicRange { get; set; }

	 	public short BasicSkill { get; set; }

	 	public short CloseDefence { get; set; }

	 	public short Concentrate { get; set; }

	 	public byte CriticalChance { get; set; }

	 	public short CriticalRate { get; set; }

	 	public short DamageMaximum { get; set; }

	 	public short DamageMinimum { get; set; }

	 	public short DarkResistance { get; set; }

	 	public short DefenceDodge { get; set; }

	 	public byte DefenceUpgrade { get; set; }

	 	public short DistanceDefence { get; set; }

	 	public short DistanceDefenceDodge { get; set; }

	 	public byte Element { get; set; }

	 	public short ElementRate { get; set; }

	 	public short FireResistance { get; set; }

	 	public byte HeroLevel { get; set; }

	 	public int HeroXp { get; set; }

	 	public bool IsHostile { get; set; }

	 	public int JobXp { get; set; }

	 	public byte Level { get; set; }

	 	public short LightResistance { get; set; }

	 	public short MagicDefence { get; set; }

	 	public int MaxHp { get; set; }

	 	public int MaxMp { get; set; }

	 	public NosCore.Data.Enumerations.Map.MonsterType MonsterType { get; set; }

	 	[I18NFrom(typeof(I18NNpcMonsterDto))]
		public I18NString Name { get; set; } = new I18NString();
		[AdaptMember("Name")]
		public string NameI18NKey { get; set; }

	 	public bool NoAggresiveIcon { get; set; }

	 	public byte NoticeRange { get; set; }

	 	[Key]
		public short NpcMonsterVNum { get; set; }

	 	public byte Race { get; set; }

	 	public byte RaceType { get; set; }

	 	public int RespawnTime { get; set; }

	 	public byte Speed { get; set; }

	 	public short VNumRequired { get; set; }

	 	public short WaterResistance { get; set; }

	 	public int Xp { get; set; }

	 	public bool IsPercent { get; set; }

	 	public int TakeDamages { get; set; }

	 	public int GiveDamagePercentage { get; set; }

	 }
}
/* Cheat Extension by ArcSummons */

using Kingmaker;
using Kingmaker.Cheats;
using Kingmaker.Designers;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.UI.Common;
using Kingmaker.UnitLogic;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace ToyBox.classes.Extends {
    public class CheatsExtended {
        public static void FullBuff1() {
            foreach (UnitEntityData Character in Game.Instance.Player.Party) {
                foreach (BlueprintBuff buffVar in Game.Instance.BlueprintRoot.Cheats.FullBuffList) {
                    GameHelper.ApplyBuff(Character, buffVar, null);
                }
            }
            UIUtility.SendWarning("Buff Simple Extended Applied");
        }

        public static void FullBuff2() {
            foreach (UnitEntityData unit in Game.Instance.Player.Party) {
                BlueprintBuff[] buffArray =
                {
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("09b4b69169304474296484c74aa12027"), /* True Seeing */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("0adecbf63b614e846bfe15c33f34507e"), /* See Invisibility */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("03464790f40c3c24aa684b57155f3280"), /* Haste */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("58d3b0b98ce4f9346b3c1fb4c7dbc9bf"), /* Haste - Angelic */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("87b8c6270ea85c743afc734dfe99afee"), /* Bless */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("0bd122cf77c3d6948929de45e18e4fed"), /* Bone Shield */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("35f3724d4e8877845af488d167cb8a89"), /* Mind Blank */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b0253e57a75b621428c1b89de5a937d1"), /* Death Ward */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("6784d2dfa2e552448828bffc9ca7a01b"), /* Feather Fall */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("235533b62159790499ced35860636bb2"), /* Freedom of Movement */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("1533e782fca42b84ea370fc1dcbf4fc1"), /* Freedom of Movement */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b87a0e8a961c63a44a952822fe975edb"), /* Resist Acid */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("90ce7dac4b9001e449eb44861397a65f"), /* Resist Cold */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("453201f110f49714fb1d713c1f7bc06d"), /* Resist Electricity */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b9ce1623447547946b8c58efd069f7c4"), /* Resist Fire */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("63e2a6323c2bbff40a87fcd522778032"), /* Resist Sonic */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("50a77710a7c4914499d0254e76a808e5"), /* Spell Resistance */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b175001b42b1a02479881b72fe132116"), /* Bull STR */

                    /* EXPERIMENTAL */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("9100128a9fd947b89344ad27f98833ff"), /* Angel Ward Weakness Divine Spell */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("68d82c1249d3e4c47a69946b1eea0dd6"), /* Angel Ward Weakness */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("3db4a1f9ffa46e7469f817bced1a0df2"), /* Ascendant Summon */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b8da3ec045ec04845a126948e1f4fc1a"), /* Heroism Greater */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("256ae19b117c40868248154da12d17b8"), /* Aeon Corruption Protection */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("444de30dc7a99144e852bd7dbaeddaad"), /* Azata Tree Strong */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("adcc8e0615fa4e37bd7e5854302203fe"), /* Trickster Double Damage */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("65ea55e5521d43409d102defd153757a"), /* Legend Rest */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("4652211718a2d9f4f860af19ad689663"), /* Protection of Nature */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("dea0dba1f7bff064987e03f1307bfa84"), /* Sense Vital */

                    /* Ring Stat Effect */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("a762480e419a3d948bceca0f68f00f3a"), /* AC */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5e228a4d56de60245a2671db14c2f864"), /* CHA */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b76f97e0b8da3d4478108ad62186b03f"), /* CON */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("73d674dd8d948fa4ab759e9cc8742c21"), /* DEX */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("51de1922182b81a49b5de907c011ac37"), /* INT */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("aa89de5e1d3a00b4d974f6a6ce055e7e"), /* MOV */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("ec0c5867b04c9c44eb89683f73a00c2b"), /* SAV */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("068035c7cd581c2419567062e573eaaa"), /* SKI */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("f7de309109e6ef24bbab17dce8fd547d"), /* SDC */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("2735973380b603c489dc2556edf485ae"), /* STR */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("e4a2e8fe03063104098d088f70ff1d62"), /* WIS */

                    /* Weapon Effect */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5fe69b8d755a4bd18e4e67c5613f76af"), /* Slasing Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("4bbff3a1c8894a46be2515029ea044b0"), /* Magic Damage Fighter Elemental */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("20fba7e5ceb64b6eaa459f4bb927029a"), /* Attack Bonus */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("526473a7500e4c439e675b500dcecf1f"), /* AC Bonus */

                    /* Feat Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("3de0359d9480cb549ab6cf1eac51f9dc"), /* Allied Spellcaster */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5274ddc289f4a7447b7ace68ad8bebb0"), /* Shield of Faith */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("60376ff2340b73346a555979d7763088"), /* Shield of Oracle */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("c6d44dc0d8c341748486ae8246cd1b59"), /* Army Bloodlust */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("2236ee9c037148f393d9b4537a303690"), /* Stat Bonus Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("51a51b32ee923dc4a9e9da6684658d92"), /* Blind Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("1044ac71f6200f84bbfbcfa2bcb3bd66"), /* Courage Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("bb3884b112618534c9199da8631634b5"), /* Hospitaler Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("317cf91bc976f49498b445d06ed89add"), /* Resolve Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("52608768f529ef840933e8e85841d7e0"), /* Golem Autumn Aura */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5d2833d39901b844b828f9f13a0353fe"), /* Divine Favor */
                };

                foreach (BlueprintBuff buffVar in buffArray) {
                    GameHelper.ApplyBuff(unit, buffVar, null);
                }

                UIUtility.SendWarning("Buff Complex Extended Applied");
            }
        }

        public static void StatInit() {
            GameHelper.GetPlayerCharacter().Stats.SkillMobility.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillAthletics.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillPerception.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillThievery.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillPersuasion.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillStealth.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillUseMagicDevice.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillKnowledgeArcana.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillKnowledgeWorld.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillLoreNature.BaseValue = 1;
            GameHelper.GetPlayerCharacter().Stats.SkillLoreReligion.BaseValue = 1;

            GameHelper.GetPlayerCharacter().Stats.Strength.BaseValue = 40;
            GameHelper.GetPlayerCharacter().Stats.Dexterity.BaseValue = 40;
            GameHelper.GetPlayerCharacter().Stats.Constitution.BaseValue = 40;
            GameHelper.GetPlayerCharacter().Stats.Intelligence.BaseValue = 40;
            GameHelper.GetPlayerCharacter().Stats.Wisdom.BaseValue = 40;
            GameHelper.GetPlayerCharacter().Stats.Charisma.BaseValue = 40;
            UIUtility.SendWarning("Stats init set to 40");
        }
    }
}

/** Cheat Extension by ArcSummons */

using Kingmaker;
using Kingmaker.Cheats;
using Kingmaker.Designers;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace ToyBox.classes.Extends {
    public class CheatsExtended {
        public static void FullBuff1() {
            foreach (UnitEntityData Character in Game.Instance.Player.Party) {
                foreach (BlueprintBuff buffVar in Game.Instance.BlueprintRoot.Cheats.FullBuffList) {
                    GameHelper.ApplyBuff(Character, buffVar, null);
                }
            }
        }

        public static void FullBuff2() {
            foreach (UnitEntityData unit in Game.Instance.Player.Party) {
                BlueprintBuff[] buffArray =
                {
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("09b4b69169304474296484c74aa12027"), /* True Seeing */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("03464790f40c3c24aa684b57155f3280"), /* Haste */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("9100128a9fd947b89344ad27f98833ff"), /* Angel Ward Divine Spell */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("87b8c6270ea85c743afc734dfe99afee"), /* Bless */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("0bd122cf77c3d6948929de45e18e4fed"), /* Bone Shield */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("35f3724d4e8877845af488d167cb8a89"), /* Mind Blank */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b0253e57a75b621428c1b89de5a937d1"), /* Death Ward */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5274ddc289f4a7447b7ace68ad8bebb0"), /* Shield of Faith */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("6784d2dfa2e552448828bffc9ca7a01b"), /* Feather Fall */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("235533b62159790499ced35860636bb2"), /* Freedom of Movement */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b87a0e8a961c63a44a952822fe975edb"), /* Resist Acid */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("90ce7dac4b9001e449eb44861397a65f"), /* Resist Cold */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("453201f110f49714fb1d713c1f7bc06d"), /* Resist Electricity */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b9ce1623447547946b8c58efd069f7c4"), /* Resist Fire */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("63e2a6323c2bbff40a87fcd522778032"), /* Resist Sonic */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("0adecbf63b614e846bfe15c33f34507e"), /* See Invisibility */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("50a77710a7c4914499d0254e76a808e5"), /* Spell Resistance */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b175001b42b1a02479881b72fe132116"), /* Bull STR */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("4814db563c105e64d948161162715661"), /* False Life */

                    /** EXPERIMENTAL **/
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("68d82c1249d3e4c47a69946b1eea0dd6"), /* Angel Ward Weakness */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("8801f41b253263249a3d3a46cdf3b276"), /* Angel Ward Harm */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("a00be2f66cc2ee34a847e19244b30239"), /* Angel Ward Disease */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("384e8507f54fd3342ad9fd6101bc106a"), /* Angel Ward Unclean */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("c5455f88975e16648b4abc47a28fa120"), /* Last Stand Effect */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("3db4a1f9ffa46e7469f817bced1a0df2"), /* Ascendant Summon */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b8da3ec045ec04845a126948e1f4fc1a"), /* Heroism Greater */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("07162c026878db04cabe4fc3edc90585"), /* Shaman Ward of Flame */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("add62fda83dcbfb408ef2976e0271d2c"), /* Shaman Ward of Wind */

                    Utilities.GetBlueprintByGuid<BlueprintBuff>("256ae19b117c40868248154da12d17b8"), /* Aeon Corruption Protection */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5d97cd157d9f52441b6e5ab665d1b36f"), /* Azata Rest */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("444de30dc7a99144e852bd7dbaeddaad"), /* Azata Tree Strong */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("adcc8e0615fa4e37bd7e5854302203fe"), /* Trickster Double Damage */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("65ea55e5521d43409d102defd153757a"), /* Legend Rest */

                    /** Ring Stat Effect **/
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
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("810a327cb197bc64d8984ed638fb554a"), /* DMG */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("e4a2e8fe03063104098d088f70ff1d62"), /* WIS */

                    /** Weapon Effect **/
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("2f2eb113da65b6b4fbf69e35c90afe02"), /* Chaos Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("418e078eb0eb6494ab65d124ab5eb7fe"), /* Evil Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("cbe785a099249164eb2204f553437e3d"), /* Good Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("57e74017b222b274790c5fa162855035"), /* Lawful Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5fe69b8d755a4bd18e4e67c5613f76af"), /* Slasing Buff */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("4bbff3a1c8894a46be2515029ea044b0"), /* Magic Damage Fighter Elemental */
                };

                foreach (BlueprintBuff buffVar in buffArray) {
                    GameHelper.ApplyBuff(unit, buffVar, null);
                }
            }
        }
    }
}

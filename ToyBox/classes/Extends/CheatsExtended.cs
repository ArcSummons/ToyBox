/** Cheat Extension by ArcSummons */

using Kingmaker;
using Kingmaker.Cheats;
using Kingmaker.Designers;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.UnitLogic.Buffs.Blueprints;

namespace ToyBox.classes.Extends 
{
    public class CheatsExtended
    {
        public static void FullBuff1()
        {
            foreach (UnitEntityData Character in Game.Instance.Player.Party)
            {
                foreach (BlueprintBuff buffVar in Game.Instance.BlueprintRoot.Cheats.FullBuffList)
                {
                    GameHelper.ApplyBuff(Character, buffVar, null);
                }
            }
        }

        public static void FullBuff2()
        {
            foreach (UnitEntityData unit in Game.Instance.Player.Party)
            {
                BlueprintBuff[] buffArray =
                {
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("09b4b69169304474296484c74aa12027"), /* True Seeing */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("03464790f40c3c24aa684b57155f3280"), /* Haste */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("9100128a9fd947b89344ad27f98833ff"), /* Angel Ward */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("87b8c6270ea85c743afc734dfe99afee"), /* Bless */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("0bd122cf77c3d6948929de45e18e4fed"), /* Bone Shield */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("35f3724d4e8877845af488d167cb8a89"), /* Mind Blank */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("a04d666d8b1f5a2419f1adc6874ae65a"), /* Death Ward */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("5274ddc289f4a7447b7ace68ad8bebb0"), /* Shield of Faith */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("6784d2dfa2e552448828bffc9ca7a01b"), /* Feather Fall */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("235533b62159790499ced35860636bb2"), /* Freedom of Movement */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b87a0e8a961c63a44a952822fe975edb"), /* Resist Acid */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("90ce7dac4b9001e449eb44861397a65f"), /* Resist Cold */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("453201f110f49714fb1d713c1f7bc06d"), /* Resist Electricity */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("b9ce1623447547946b8c58efd069f7c4"), /* Resist Fire */
                    Utilities.GetBlueprintByGuid<BlueprintBuff>("63e2a6323c2bbff40a87fcd522778032"), /* Resist Sonic */
                };

                foreach (BlueprintBuff buffVar in buffArray)
                {
                    GameHelper.ApplyBuff(unit, buffVar, null);
                }
            }
        }
    }
}

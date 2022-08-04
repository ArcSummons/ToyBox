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
                };

                foreach (BlueprintBuff buffVar in buffArray)
                {
                    GameHelper.ApplyBuff(unit, buffVar, null);
                }
            }
        }
    }
}

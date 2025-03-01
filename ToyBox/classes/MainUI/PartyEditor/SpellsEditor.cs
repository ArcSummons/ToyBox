﻿using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using Kingmaker;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Blueprints.Classes.Spells;
using Kingmaker.Designers;
using Kingmaker.EntitySystem.Entities;
using Kingmaker.EntitySystem.Stats;
using Kingmaker.UnitLogic;
using ToyBox.Multiclass;
using Alignment = Kingmaker.Enums.Alignment;
using ModKit;
using static ModKit.UI;
using ModKit.Utility;
using ToyBox.classes.Infrastructure;
using Kingmaker.PubSubSystem;
using Kingmaker.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.UnitLogic.Parts;
using static Kingmaker.Utility.UnitDescription.UnitDescription;
using ToyBox.BagOfPatches;


namespace ToyBox {
    public partial class PartyEditor {
        public static List<Action> OnSpellsGUI(UnitEntityData ch, IEnumerable<Spellbook> spellbooks) {
            List<Action> todo = new();
            Space(20);
            var names = spellbooks.Select((sb) => sb.Blueprint.GetDisplayName()).ToArray();
            var titles = names.Select((name, i) => $"{name} ({spellbooks.ElementAt(i).CasterLevel})").ToArray();
            if (spellbooks.Any()) {
                var spellbook = spellbooks.ElementAt(selectedSpellbook);
                using (HorizontalScope()) {
                    SelectionGrid(ref selectedSpellbook, titles, Math.Min(titles.Length, 7), AutoWidth());
                    if (selectedSpellbook >= names.Length) selectedSpellbook = 0;
                    DisclosureToggle("Edit".orange().bold(), ref editSpellbooks);
                    Space(-50);
                    var mergableClasses = ch.MergableClasses();
                    if (spellbook.IsStandaloneMythic || mergableClasses.Count() == 0) {
                        Label($"Merge Mythic".cyan(), AutoWidth());
                        25.space();
                        Label("When you get standalone mythic spellbooks you can merge them here.".green());
                    }
                    else {
                        Label($"Merge Mythic:".cyan(), 175.width());
                        25.space();
                        foreach (var cl in mergableClasses) {
                            ActionButton(cl.CharacterClass.LocalizedName.ToString(), () => spellbook.MergeMythicSpellbook(cl));
                            15.space();
                        }
                        25.space();
                        using (VerticalScope()) {
                            Label("Merging your mythic spellbook will cause you to transfer all mythic spells to your normal spellbook and gain caster levels equal to your mythic level. You will then be able to re-select spells on next level up or mythic level up. Merging a second mythic spellbook will transfer the spells but not increase your caster level further.  If you want more CL then increase it below.".green());
                            Label("Warning: This is irreversible. Please save before continuing!".Orange());
                        }
                    }
                }
                spellbook = spellbooks.ElementAt(selectedSpellbook);
                if (editSpellbooks) {
                    spellbookEditCharacter = ch;
                    var blueprints = BlueprintExtensions.GetBlueprints<BlueprintSpellbook>().OrderBy((bp) => bp.GetDisplayName());
                    todo = BlueprintListUI.OnGUI(ch, blueprints, 100);
                }
                else {
                    var maxLevel = spellbook.Blueprint.MaxSpellLevel;
                    var casterLevel = spellbook.CasterLevel;
                    using (HorizontalScope()) {
                        EnumerablePicker(
                            "Spells known",
                            ref selectedSpellbookLevel,
                            Enumerable.Range(0, spellbook.Blueprint.MaxSpellLevel + 1),
                            0,
                            (lvl) => {
                                var levelText = spellbook.Blueprint.SpellsPerDay.GetCount(casterLevel, lvl) != null ? $"L{lvl}".bold() : $"L{lvl}".grey();
                                var knownCount = spellbook.GetKnownSpells(lvl).Count;
                                var countText = knownCount > 0 ? $" ({knownCount})".white() : "";
                                return levelText + countText;
                            },
                            AutoWidth()
                        );
                        Space(20);
                        if (casterLevel > 0) {
                            ActionButton("-1 CL", () => CasterHelpers.LowerCasterLevel(spellbook), AutoWidth());
                        }
                        if (casterLevel < 40) {
                            ActionButton("+1 CL", () => CasterHelpers.AddCasterLevel(spellbook), AutoWidth());
                        }
                        // removes opposition schools; these are not cleared when removing facts; to add new opposition schools, simply add the corresponding fact again
                        if (spellbook.OppositionSchools.Any()) {
                            ActionButton("Clear Opposition Schools", () => {
                                spellbook.OppositionSchools.Clear();
                                spellbook.ExOppositionSchools.Clear();
                                ch.Facts.RemoveAll<UnitFact>(r => r.Blueprint.GetComponent<AddOppositionSchool>(), true);
                            }, AutoWidth());
                        }
                        if (spellbook.OppositionDescriptors != 0) {
                            ActionButton("Clear Opposition Descriptors", () => {
                                spellbook.OppositionDescriptors = 0;
                                ch.Facts.RemoveAll<UnitFact>(r => r.Blueprint.GetComponent<AddOppositionDescriptor>(), true);
                            }, AutoWidth());
                        }
                    }
                    SelectedSpellbook[ch.HashKey()] = spellbook;
                    todo = FactsEditor.OnGUI(ch, spellbook, selectedSpellbookLevel);
                }
            }
#if false
                    else {
                        spellbookEditCharacter = ch;
                        editSpellbooks = true;
                        var blueprints = BlueprintExensions.GetBlueprints<BlueprintSpellbook>().OrderBy((bp) => bp.GetDisplayName());
                        todo = BlueprintListUI.OnGUI(ch, blueprints, 100);
                    }
#endif
            return todo;
        }
    }
}

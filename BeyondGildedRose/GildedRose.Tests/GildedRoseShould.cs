namespace GildedRose.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using ApprovalTests;
    using ApprovalTests.Reporters;
    using Xunit;

    [UseReporter(typeof(DiffReporter))]
    public class GildedRoseShould
    {
        [Fact]
        public void FindTheGildedRoseClass()
        {
            var names = new string[] { "hammer", "Aged Brie", "Backstage passes to a TAFKAL80ETC concert", "Sulfuras, Hand of Ragnaros", "" };
            var sellIns = new int[] { 0, 1, 5, 6, 7, 10, 11, 12 };
            var qualities = new int[] { -1, 0, 1, 2, 49, 50, 51 };

            ApprovalTests.Combinations.CombinationApprovals.VerifyAllCombinations(DoAllApprovals, names, sellIns, qualities);
        }
        private string DoAllApprovals(string name, int sellIn, int quality)
        {
            var gr = new GildedRose(new Item[] {
                new Item(name,
                            sellIn,
                            quality,
                            "weapon",
                            1,
                            1,
                            new Character("Earl", "M", 1, "warrior", "Elf"),
                            new Realm("Atlantis"))});

            gr.UpdateQuality();

            var items = gr.Items.ToList<Item>();
            return string.Join("\n", items.Select(i => i.ToString()));
        }
    }
}

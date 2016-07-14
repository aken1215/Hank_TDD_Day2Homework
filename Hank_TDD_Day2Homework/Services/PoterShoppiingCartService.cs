using Hank_TDD_Day2Homework.Models;
using Hank_TDD_Day2Homework.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hank_TDD_Day2Homework.Services
{
    public class PoterShoppiingCartService : IShoppingCartService<PoterBook>
    {
        private ICollection<PoterBook> _books { get; set; }

        public PoterShoppiingCartService()
        {
            this._books = new List<PoterBook>();
        }

        public double Bill()
        {
            var bookGroupsList = this.GeneateBookGroupList();
            double total = 0;

            foreach (var item in bookGroupsList)
            {
                total += this.getSubtotal(item);
            }
            return total;
        }

        public void OrderProduct(PoterBook product)
        {
            _books.Add(product);
        }

        private List<ICollection<PoterBook>> GeneateBookGroupList()
        {
            var booksGroupsList = new List<ICollection<PoterBook>>();
            var booksGroupByVersion = this._books.GroupBy(i => i.Version);
            var booksGroupsLength = booksGroupByVersion.Select(i => i.Count()).Max();

            for (int i = 0; i <= booksGroupsLength - 1; i++)
            {
                booksGroupsList.Add(new List<PoterBook>());
            }

            foreach (var items in booksGroupByVersion)
            {
                for (int i = 0; i <= items.Count() - 1; i++)
                {
                    booksGroupsList.ElementAt(i).Add(items.ElementAt(i));
                }
            }

            return booksGroupsList;
        }

        private double getSubtotal(ICollection<PoterBook> items)
        {
            var subtotal = items.Select(i => i.Pirce).Sum();
            switch (items.Count)
            {
                case 2:
                    subtotal = subtotal * 0.95;
                    break;
                case 3:
                    subtotal = subtotal * 0.9;
                    break;
                case 4:
                    subtotal = subtotal * 0.8;
                    break;
                case 5:
                    subtotal = subtotal * 0.75;
                    break;
                default:
                    break;
            }
            return subtotal;
        }
    }
}
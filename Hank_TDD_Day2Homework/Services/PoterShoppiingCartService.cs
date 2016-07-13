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
        private double _total { get; set; }
        private ICollection<PoterBook> _books { get; set; }
        private ICollection<ICollection<PoterBook>> _booksGroups { get; set; }

        public PoterShoppiingCartService()
        {
            this._books = new List<PoterBook>();
            this._booksGroups = new List<ICollection<PoterBook>>();
        }

        public double Bill()
        {
            this.ProcessSale();
            return _total;
        }

        public void OrderProduct(PoterBook product)
        {
            _books.Add(product);
        }

        private void ProcessSale()
        {
            var _booksGroupByVersion = this._books.GroupBy(i => i.Version);
            var _booksGroupsLength = _booksGroupByVersion.Select(i => i.Count()).Max();

            for (int i = 0; i <= _booksGroupsLength - 1; i++)
            {
                this._booksGroups.Add(new List<PoterBook>());
            }

            foreach (var items in _booksGroupByVersion)
            {
                for (int i = 0; i <= items.Count() - 1; i++)
                {
                    this._booksGroups.ElementAt(i).Add(items.ElementAt(i));
                }
            }

            foreach (var item in this._booksGroups)
            {
                this._total += this.getSubtotal(item);
            }
          
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
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
        private int _total { get; set; }
        private ICollection<PoterBook> _books { get; set; }

        public PoterShoppiingCartService()
        {
            this._books = new List<PoterBook>();
        }

        public int Bill()
        {
            _total=_books.Select(i => i.Pirce).Sum();
            return _total;
        }

        public void OrderProduct(PoterBook product)
        {
            _books.Add(product);
        }
    }
}
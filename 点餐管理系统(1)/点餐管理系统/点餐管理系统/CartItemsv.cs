using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 点餐管理系统
{
    public class CartItemsv
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

       
        public(decimal,decimal) GetTotalPriceByCustomersId(int Customers_id)//计算总价
        {
            List<CartItem> list=(from c in db.CartItem
                                 where c.Customers_id == Customers_id
                                 select c).ToList();
            return ((decimal)list.Sum(c => c.Unit_Price * c.Qty), (decimal)list.Sum(c => (c.Unit_Price - c.list_Price) * c.Qty));
        }
        public CartItem Add(int customer_id,int Dishes_ID,int Qty)
        {
            CartItem cartItem = null;
            Dishes dishes = (from p in db.Dishes
                             where p.Dishes_ID == Dishes_ID
                             select p).First();
            //当前需要添加的CartItem对象
            cartItem = new CartItem();
            cartItem.Customers_id = customer_id;
            cartItem.Dishes_ID = dishes.Dishes_ID;
            cartItem.Dishes_Name = dishes.Dishes_Name;
            cartItem.Unit_Price = dishes.Unit_Price;
            cartItem.list_Price = dishes.list_Price;
            cartItem.Qty = Qty;

            //如果用户当前菜品已在购物车里，则只要修改数量即可
            int ExistCartItemCount = (from c in db.CartItem
                                      where c.Customers_id == customer_id && c.Dishes_ID == Dishes_ID
                                      select c).Count();
            if (ExistCartItemCount > 0)//修改
            {
                CartItem existCartItem=(from c in db.CartItem
                                        where c.Customers_id == customer_id && c.Dishes_ID == Dishes_ID
                                        select c).First();
                existCartItem.Qty += Qty;//添加
            }
            else
            {
                db.CartItem.InsertOnSubmit(cartItem);
            }
            db.SubmitChanges();
            return cartItem;
        }
        
    }
}
